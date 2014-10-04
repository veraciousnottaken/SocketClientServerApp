using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using SocketClientServer;

namespace SocketClientServerApp
{
    public partial class Form1 : Form
    {
        private readonly SocketClient _client = new SocketClient();
        private readonly SocketServer _server = new SocketServer();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            UpdateStart();
        }

        private void InitializeForm()
        {
            tbClientAddressOfServer.Text = ConfigurationManager.AppSettings["ConnectTo"].Trim();
            tbClientPortOfServer.Text = ConfigurationManager.AppSettings["ConnectToPort"].Trim();
        }

        public void InvokeUpdateReceivedClient(object data)
        {
            Action<object> t = UpdateReceivedClient;
            if (this.InvokeRequired)
            {
                this.Invoke(t, data);
            }
            else
            {
                t(data);
            }
        }

        private void bClientConnect_Click(object sender, EventArgs e)
        {
            int port = Int16.Parse(tbClientPortOfServer.Text);

            _client.OnReadCallback = InvokeUpdateReceivedClient;
            _client.OnCloseCallback = InvokeToggleButtonsClient;
            _client.OnOpenCallback = InvokeToggleButtonsClient;
            _client.OnErrorCallback = InvokeErrorClient;
            _client.Reconnect = cbClientReconnect.Checked;
            _client.ReconnectTimeout = Int16.Parse(tbClientReconnectTimeout.Text);

            _client.Open(tbClientAddressOfServer.Text, port);
        }

        private void bClientDisconnect_Click(object sender, EventArgs e)
        {
            _client.Close();
        }

        private void bClientReceive_Click(object sender, EventArgs e)
        {
        }

        private void bClientSend_Click(object sender, EventArgs e)
        {
            _client.Send(tbClientSend.Text);
        }

        private void bServerConnect_Click(object sender, EventArgs e)
        {
            int port = Int16.Parse(tbServerPort.Text);
            var address = comboBox1.Items[comboBox1.SelectedIndex].ToString();

            _server.OnClientConnectCallback = InvokeUpdateClientList;
            _server.OnClientDisconnectCallback = InvokeUpdateClientList;
            _server.OnStopCallback = InvokeUpdateClientList;
            _server.OnDataReceivedCallback = InvokeUpdateServerControls;
            _server.OnStartCallback = InvokeUpdateServerControls;

            _server.Start(address, port);
        }

        private void bServerDisconnect_Click(object sender, EventArgs e)
        {
            _server.Stop();
        }

        private void bServerReceive_Click(object sender, EventArgs e)
        {
            tbServerReceive.Text = string.Empty;
        }

        private void bServerSend_Click(object sender, EventArgs e)
        {
            _server.Broadcast(tbServerSend.Text);
        }

        private void ErrorClient(Exception obj)
        {
            lvClientDebug.Items.Add(obj.Message);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void InvokeErrorClient(Exception e)
        {
            Action<Exception> t = ErrorClient;

            if (InvokeRequired)
            {
                Invoke(t, e);
            }
            else
            {
                t(e);
            }
        }

        private void InvokeToggleButtonsClient(bool state)
        {
            Action t = ToggleButtonsClient;

            if (InvokeRequired)
            {
                Invoke(t);
            }
            else
            {
                t();
            }
        }

        private void InvokeUpdateClientList(ArrayList list)
        {
            Action<ArrayList> t = UpdateClientList;

            if (InvokeRequired)
                Invoke(t, list);
            else
            {
                t(list);
            }
        }

        private void InvokeUpdateServerControls(SocketServer.SocketPacket socketpacket)
        {
            Action<SocketServer.SocketPacket> t = UpdateServerControls;
            if (InvokeRequired)
            {
                Invoke(t, socketpacket);
            }
            else
            {
                t(socketpacket);
            }
        }

        private void lvServerClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ToggleButtonsClient()
        {
            bClientConnect.Enabled = !_client.Connected;
            bClientDisconnect.Enabled = !bClientConnect.Enabled;
            bClientSend.Enabled = !bClientConnect.Enabled;
            bClientClear.Enabled = !string.IsNullOrEmpty(tbClientReceive.Text);
            cbClientReconnect.Enabled = !_client.Connected;

            lvClientDebug.Items.Add(_client.Connected ? "Podłączony" : "Odłączony");
        }

        private void ToggleButtonsServer()
        {
            bServerConnect.Enabled = !_server.IsStarted;
            bServerDisconnect.Enabled = !bServerConnect.Enabled;
            bServerSend.Enabled = _server.ClientCount > 0;
            bServerClear.Enabled = !string.IsNullOrEmpty(tbServerReceive.Text);
        }

        // Update the list of clients that is displayed
        private void UpdateClientList(ArrayList socketList)
        {
            lvServerClients.Items.Clear();

            for (int i = 0; i < socketList.Count; i++)
            {
                string clientKey = Convert.ToString(i + 1);
                Socket workerSocket = (Socket)socketList[i];

                if (workerSocket != null)
                {
                    if (workerSocket.Connected)
                    {
                        var txt = workerSocket.RemoteEndPoint.Serialize().ToString();
                        lvServerClients.Items.Add(txt);
                    }
                }
            }

            ToggleButtonsServer();
        }

        private void UpdateReceivedClient(object data)
        {
            tbClientReceive.AppendText((string) data);
            tbClientReceive.AppendText(Environment.NewLine);
            tbClientReceive.ScrollToCaret();
        }

        private void UpdateServerControls(SocketServer.SocketPacket socketpacket)
        {
            tbServerReceive.AppendText(SocketServer.GetPacketAsString(socketpacket));
            tbServerReceive.AppendText(Environment.NewLine);
            tbServerReceive.ScrollToCaret();

            ToggleButtonsServer();
        }

        private void UpdateStart()
        {
            foreach (var item in SocketServer
                .GetServerIp()
                .AddressList
                .Where(ip => ip.AddressFamily == AddressFamily.InterNetwork)
                .Select(ip => ip.ToString()))
            {
                comboBox1.Items.Add(item);
            }

            /*foreach (var networkInterface in _server.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    object item = networkInterface.Name;
                    comboBox1.Items.Add(item);
                }
            }*/

            if (comboBox1.Items.Count > 0)
            {
                var item = comboBox1.Items[0];
                comboBox1.SelectedItem = item;
                //tbClientAddressOfServer.Text = comboBox1.SelectedItem.ToString();
            }

            //System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces().First().GetIPProperties().GetIPv4Properties().;
            ToggleButtonsClient();
            ToggleButtonsServer();
        }
    }
}