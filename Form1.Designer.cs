namespace SocketClientServerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lvClientDebug = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbClientAddressOfServer = new System.Windows.Forms.TextBox();
            this.tbClientPortOfServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bClientSend = new System.Windows.Forms.Button();
            this.bClientClear = new System.Windows.Forms.Button();
            this.tbClientSend = new System.Windows.Forms.TextBox();
            this.tbClientReceive = new System.Windows.Forms.TextBox();
            this.bClientConnect = new System.Windows.Forms.Button();
            this.bClientDisconnect = new System.Windows.Forms.Button();
            this.cbClientReconnect = new System.Windows.Forms.CheckBox();
            this.tbClientReconnectTimeout = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bServerSend = new System.Windows.Forms.Button();
            this.bServerClear = new System.Windows.Forms.Button();
            this.tbServerSend = new System.Windows.Forms.TextBox();
            this.tbServerReceive = new System.Windows.Forms.TextBox();
            this.bServerConnect = new System.Windows.Forms.Button();
            this.bServerDisconnect = new System.Windows.Forms.Button();
            this.lvServerClients = new System.Windows.Forms.ListView();
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 653);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.48812F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.51188F));
            this.tableLayoutPanel2.Controls.Add(this.lvClientDebug, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbClientAddressOfServer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbClientPortOfServer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bClientSend, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.bClientClear, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbClientSend, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbClientReceive, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.bClientConnect, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.bClientDisconnect, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbClientReconnect, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbClientReconnectTimeout, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 630);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lvClientDebug
            // 
            this.lvClientDebug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.tableLayoutPanel2.SetColumnSpan(this.lvClientDebug, 2);
            this.lvClientDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClientDebug.FullRowSelect = true;
            this.lvClientDebug.GridLines = true;
            this.lvClientDebug.Location = new System.Drawing.Point(3, 462);
            this.lvClientDebug.MultiSelect = false;
            this.lvClientDebug.Name = "lvClientDebug";
            this.lvClientDebug.Size = new System.Drawing.Size(541, 165);
            this.lvClientDebug.TabIndex = 11;
            this.lvClientDebug.UseCompatibleStateImageBehavior = false;
            this.lvClientDebug.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 400;
            // 
            // tbClientAddressOfServer
            // 
            this.tbClientAddressOfServer.Location = new System.Drawing.Point(219, 3);
            this.tbClientAddressOfServer.Name = "tbClientAddressOfServer";
            this.tbClientAddressOfServer.Size = new System.Drawing.Size(100, 22);
            this.tbClientAddressOfServer.TabIndex = 0;
            this.tbClientAddressOfServer.Text = "192.168.1.31";
            // 
            // tbClientPortOfServer
            // 
            this.tbClientPortOfServer.Location = new System.Drawing.Point(219, 33);
            this.tbClientPortOfServer.Name = "tbClientPortOfServer";
            this.tbClientPortOfServer.Size = new System.Drawing.Size(100, 22);
            this.tbClientPortOfServer.TabIndex = 1;
            this.tbClientPortOfServer.Text = "8000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Connect to";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // bClientSend
            // 
            this.bClientSend.Location = new System.Drawing.Point(3, 388);
            this.bClientSend.Name = "bClientSend";
            this.bClientSend.Size = new System.Drawing.Size(193, 31);
            this.bClientSend.TabIndex = 4;
            this.bClientSend.Text = "Send";
            this.bClientSend.UseVisualStyleBackColor = true;
            this.bClientSend.Click += new System.EventHandler(this.bClientSend_Click);
            // 
            // bClientClear
            // 
            this.bClientClear.Location = new System.Drawing.Point(219, 388);
            this.bClientClear.Name = "bClientClear";
            this.bClientClear.Size = new System.Drawing.Size(193, 31);
            this.bClientClear.TabIndex = 5;
            this.bClientClear.Text = "Clear";
            this.bClientClear.UseVisualStyleBackColor = true;
            this.bClientClear.Click += new System.EventHandler(this.bClientReceive_Click);
            // 
            // tbClientSend
            // 
            this.tbClientSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClientSend.Location = new System.Drawing.Point(3, 89);
            this.tbClientSend.Multiline = true;
            this.tbClientSend.Name = "tbClientSend";
            this.tbClientSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClientSend.Size = new System.Drawing.Size(210, 256);
            this.tbClientSend.TabIndex = 2;
            this.tbClientSend.Text = "nnnnnn";
            // 
            // tbClientReceive
            // 
            this.tbClientReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClientReceive.Location = new System.Drawing.Point(219, 89);
            this.tbClientReceive.Multiline = true;
            this.tbClientReceive.Name = "tbClientReceive";
            this.tbClientReceive.ReadOnly = true;
            this.tbClientReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClientReceive.Size = new System.Drawing.Size(325, 256);
            this.tbClientReceive.TabIndex = 3;
            // 
            // bClientConnect
            // 
            this.bClientConnect.Location = new System.Drawing.Point(3, 425);
            this.bClientConnect.Name = "bClientConnect";
            this.bClientConnect.Size = new System.Drawing.Size(193, 31);
            this.bClientConnect.TabIndex = 6;
            this.bClientConnect.Text = "Connect";
            this.bClientConnect.UseVisualStyleBackColor = true;
            this.bClientConnect.Click += new System.EventHandler(this.bClientConnect_Click);
            // 
            // bClientDisconnect
            // 
            this.bClientDisconnect.Location = new System.Drawing.Point(219, 425);
            this.bClientDisconnect.Name = "bClientDisconnect";
            this.bClientDisconnect.Size = new System.Drawing.Size(193, 31);
            this.bClientDisconnect.TabIndex = 7;
            this.bClientDisconnect.Text = "Disconnect";
            this.bClientDisconnect.UseVisualStyleBackColor = true;
            this.bClientDisconnect.Click += new System.EventHandler(this.bClientDisconnect_Click);
            // 
            // cbClientReconnect
            // 
            this.cbClientReconnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbClientReconnect.AutoSize = true;
            this.cbClientReconnect.Location = new System.Drawing.Point(97, 63);
            this.cbClientReconnect.Name = "cbClientReconnect";
            this.cbClientReconnect.Size = new System.Drawing.Size(116, 20);
            this.cbClientReconnect.TabIndex = 12;
            this.cbClientReconnect.Text = "Auto reconnect";
            this.cbClientReconnect.UseVisualStyleBackColor = true;
            // 
            // tbClientReconnectTimeout
            // 
            this.tbClientReconnectTimeout.Location = new System.Drawing.Point(219, 63);
            this.tbClientReconnectTimeout.Name = "tbClientReconnectTimeout";
            this.tbClientReconnectTimeout.Size = new System.Drawing.Size(100, 22);
            this.tbClientReconnectTimeout.TabIndex = 13;
            this.tbClientReconnectTimeout.Text = "5000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(567, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(555, 653);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tbServerPort, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.bServerSend, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.bServerClear, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbServerSend, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbServerReceive, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.bServerConnect, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.bServerDisconnect, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lvServerClients, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(547, 630);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(276, 33);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(100, 22);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // bServerSend
            // 
            this.bServerSend.Location = new System.Drawing.Point(3, 215);
            this.bServerSend.Name = "bServerSend";
            this.bServerSend.Size = new System.Drawing.Size(193, 49);
            this.bServerSend.TabIndex = 4;
            this.bServerSend.Text = "Broadcast";
            this.bServerSend.UseVisualStyleBackColor = true;
            this.bServerSend.Click += new System.EventHandler(this.bServerSend_Click);
            // 
            // bServerClear
            // 
            this.bServerClear.Location = new System.Drawing.Point(276, 215);
            this.bServerClear.Name = "bServerClear";
            this.bServerClear.Size = new System.Drawing.Size(193, 49);
            this.bServerClear.TabIndex = 5;
            this.bServerClear.Text = "Clear";
            this.bServerClear.UseVisualStyleBackColor = true;
            this.bServerClear.Click += new System.EventHandler(this.bServerReceive_Click);
            // 
            // tbServerSend
            // 
            this.tbServerSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServerSend.Location = new System.Drawing.Point(3, 93);
            this.tbServerSend.Multiline = true;
            this.tbServerSend.Name = "tbServerSend";
            this.tbServerSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServerSend.Size = new System.Drawing.Size(267, 91);
            this.tbServerSend.TabIndex = 2;
            this.tbServerSend.Text = "nnnnnn";
            // 
            // tbServerReceive
            // 
            this.tbServerReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServerReceive.Location = new System.Drawing.Point(276, 93);
            this.tbServerReceive.Multiline = true;
            this.tbServerReceive.Name = "tbServerReceive";
            this.tbServerReceive.ReadOnly = true;
            this.tbServerReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServerReceive.Size = new System.Drawing.Size(268, 91);
            this.tbServerReceive.TabIndex = 3;
            // 
            // bServerConnect
            // 
            this.bServerConnect.Location = new System.Drawing.Point(3, 273);
            this.bServerConnect.Name = "bServerConnect";
            this.bServerConnect.Size = new System.Drawing.Size(193, 49);
            this.bServerConnect.TabIndex = 6;
            this.bServerConnect.Text = "Start";
            this.bServerConnect.UseVisualStyleBackColor = true;
            this.bServerConnect.Click += new System.EventHandler(this.bServerConnect_Click);
            // 
            // bServerDisconnect
            // 
            this.bServerDisconnect.Location = new System.Drawing.Point(276, 273);
            this.bServerDisconnect.Name = "bServerDisconnect";
            this.bServerDisconnect.Size = new System.Drawing.Size(193, 49);
            this.bServerDisconnect.TabIndex = 7;
            this.bServerDisconnect.Text = "Stop";
            this.bServerDisconnect.UseVisualStyleBackColor = true;
            this.bServerDisconnect.Click += new System.EventHandler(this.bServerDisconnect_Click);
            // 
            // lvServerClients
            // 
            this.lvServerClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client});
            this.tableLayoutPanel3.SetColumnSpan(this.lvServerClients, 2);
            this.lvServerClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServerClients.FullRowSelect = true;
            this.lvServerClients.GridLines = true;
            this.lvServerClients.Location = new System.Drawing.Point(3, 329);
            this.lvServerClients.MultiSelect = false;
            this.lvServerClients.Name = "lvServerClients";
            this.lvServerClients.Size = new System.Drawing.Size(541, 298);
            this.lvServerClients.TabIndex = 10;
            this.lvServerClients.UseCompatibleStateImageBehavior = false;
            this.lvServerClients.View = System.Windows.Forms.View.Details;
            this.lvServerClients.SelectedIndexChanged += new System.EventHandler(this.lvServerClients_SelectedIndexChanged);
            // 
            // Client
            // 
            this.Client.Width = 200;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Socket Client Server Test";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbClientAddressOfServer;
        private System.Windows.Forms.TextBox tbClientPortOfServer;
        private System.Windows.Forms.TextBox tbClientSend;
        private System.Windows.Forms.TextBox tbClientReceive;
        private System.Windows.Forms.Button bClientSend;
        private System.Windows.Forms.Button bClientClear;
        private System.Windows.Forms.Button bClientConnect;
        private System.Windows.Forms.Button bClientDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bServerConnect;
        private System.Windows.Forms.Button bServerDisconnect;
        private System.Windows.Forms.Button bServerSend;
        private System.Windows.Forms.Button bServerClear;
        private System.Windows.Forms.TextBox tbServerSend;
        private System.Windows.Forms.TextBox tbServerReceive;
        private System.Windows.Forms.ListView lvServerClients;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ListView lvClientDebug;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbClientReconnect;
        private System.Windows.Forms.TextBox tbClientReconnectTimeout;
    }
}

