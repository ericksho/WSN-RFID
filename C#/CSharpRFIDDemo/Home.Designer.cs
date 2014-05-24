namespace CSharpRFIDDemo
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.CSPicture = new System.Windows.Forms.PictureBox();
            this.CSLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.readerNameLabel = new System.Windows.Forms.Label();
            this.readerModelLabel = new System.Windows.Forms.Label();
            this.readerIPLabel = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.office = new System.Windows.Forms.TextBox();
            this.readerID = new System.Windows.Forms.TextBox();
            this.readerName = new System.Windows.Forms.TextBox();
            this.readerModel = new System.Windows.Forms.TextBox();
            this.readerIP = new System.Windows.Forms.TextBox();
            this.readerPower = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readerPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.readerSerial = new System.Windows.Forms.TextBox();
            this.listViewCard = new System.Windows.Forms.ListView();
            this.colCardNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerUpdateListView = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CSPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CSPicture
            // 
            this.CSPicture.Image = global::CSharpRFIDDemo.Properties.Resources.connectionNo;
            this.CSPicture.Location = new System.Drawing.Point(33, 10);
            this.CSPicture.Margin = new System.Windows.Forms.Padding(2);
            this.CSPicture.Name = "CSPicture";
            this.CSPicture.Size = new System.Drawing.Size(100, 105);
            this.CSPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CSPicture.TabIndex = 0;
            this.CSPicture.TabStop = false;
            // 
            // CSLabel
            // 
            this.CSLabel.AutoSize = true;
            this.CSLabel.Location = new System.Drawing.Point(30, 117);
            this.CSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CSLabel.Name = "CSLabel";
            this.CSLabel.Size = new System.Drawing.Size(108, 13);
            this.CSLabel.TabIndex = 1;
            this.CSLabel.Text = "Sin conexión al lector";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(45, 149);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Información del dispositivo:";
            // 
            // readerNameLabel
            // 
            this.readerNameLabel.AutoSize = true;
            this.readerNameLabel.Location = new System.Drawing.Point(12, 250);
            this.readerNameLabel.Name = "readerNameLabel";
            this.readerNameLabel.Size = new System.Drawing.Size(47, 13);
            this.readerNameLabel.TabIndex = 4;
            this.readerNameLabel.Text = "Nombre:";
            // 
            // readerModelLabel
            // 
            this.readerModelLabel.AutoSize = true;
            this.readerModelLabel.Location = new System.Drawing.Point(12, 270);
            this.readerModelLabel.Name = "readerModelLabel";
            this.readerModelLabel.Size = new System.Drawing.Size(42, 13);
            this.readerModelLabel.TabIndex = 5;
            this.readerModelLabel.Text = "Modelo";
            // 
            // readerIPLabel
            // 
            this.readerIPLabel.AutoSize = true;
            this.readerIPLabel.Location = new System.Drawing.Point(12, 290);
            this.readerIPLabel.Name = "readerIPLabel";
            this.readerIPLabel.Size = new System.Drawing.Size(20, 13);
            this.readerIPLabel.TabIndex = 6;
            this.readerIPLabel.Text = "IP:";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(12, 337);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(152, 108);
            this.lstResult.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mensajes:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(178, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 433);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewCard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lecturas Recientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readerSerial);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.readerPort);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.readerPower);
            this.tabPage2.Controls.Add(this.readerIP);
            this.tabPage2.Controls.Add(this.readerModel);
            this.tabPage2.Controls.Add(this.readerName);
            this.tabPage2.Controls.Add(this.readerID);
            this.tabPage2.Controls.Add(this.office);
            this.tabPage2.Controls.Add(this.company);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "IP del Lector RFID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Modelo del Lector RFID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre del Lector RFID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID del Lector RFID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sucursal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Potencia del Lector RFID:";
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(81, 9);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(495, 20);
            this.company.TabIndex = 7;
            // 
            // office
            // 
            this.office.Location = new System.Drawing.Point(75, 39);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(501, 20);
            this.office.TabIndex = 8;
            // 
            // readerID
            // 
            this.readerID.Location = new System.Drawing.Point(132, 80);
            this.readerID.Name = "readerID";
            this.readerID.Size = new System.Drawing.Size(444, 20);
            this.readerID.TabIndex = 9;
            // 
            // readerName
            // 
            this.readerName.Location = new System.Drawing.Point(168, 109);
            this.readerName.Name = "readerName";
            this.readerName.Size = new System.Drawing.Size(408, 20);
            this.readerName.TabIndex = 10;
            // 
            // readerModel
            // 
            this.readerModel.Enabled = false;
            this.readerModel.Location = new System.Drawing.Point(165, 139);
            this.readerModel.Name = "readerModel";
            this.readerModel.Size = new System.Drawing.Size(411, 20);
            this.readerModel.TabIndex = 11;
            // 
            // readerIP
            // 
            this.readerIP.Location = new System.Drawing.Point(131, 199);
            this.readerIP.Name = "readerIP";
            this.readerIP.Size = new System.Drawing.Size(445, 20);
            this.readerIP.TabIndex = 12;
            this.readerIP.TextChanged += new System.EventHandler(this.readerIP_TextChanged);
            // 
            // readerPower
            // 
            this.readerPower.FormattingEnabled = true;
            this.readerPower.Location = new System.Drawing.Point(172, 259);
            this.readerPower.Name = "readerPower";
            this.readerPower.Size = new System.Drawing.Size(404, 21);
            this.readerPower.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Puerto del Lector RFID:";
            // 
            // readerPort
            // 
            this.readerPort.Location = new System.Drawing.Point(158, 229);
            this.readerPort.Name = "readerPort";
            this.readerPort.Size = new System.Drawing.Size(418, 20);
            this.readerPort.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Serial del Lector RFID:";
            // 
            // readerSerial
            // 
            this.readerSerial.Enabled = false;
            this.readerSerial.Location = new System.Drawing.Point(154, 169);
            this.readerSerial.Name = "readerSerial";
            this.readerSerial.Size = new System.Drawing.Size(422, 20);
            this.readerSerial.TabIndex = 17;
            // 
            // listViewCard
            // 
            this.listViewCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCardNumber,
            this.colLastTime});
            this.listViewCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCard.FullRowSelect = true;
            this.listViewCard.Location = new System.Drawing.Point(3, 3);
            this.listViewCard.Name = "listViewCard";
            this.listViewCard.Size = new System.Drawing.Size(576, 401);
            this.listViewCard.TabIndex = 5;
            this.listViewCard.UseCompatibleStateImageBehavior = false;
            this.listViewCard.View = System.Windows.Forms.View.Details;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Text = "ID";
            this.colCardNumber.Width = 169;
            // 
            // colLastTime
            // 
            this.colLastTime.Text = "Fecha y Hora";
            this.colLastTime.Width = 131;
            // 
            // timerUpdateListView
            // 
            this.timerUpdateListView.Enabled = true;
            this.timerUpdateListView.Tick += new System.EventHandler(this.timerUpdateListView_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.readerIPLabel);
            this.Controls.Add(this.readerModelLabel);
            this.Controls.Add(this.readerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.CSLabel);
            this.Controls.Add(this.CSPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSN Chile - RFID Reader Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CSPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CSPicture;
        private System.Windows.Forms.Label CSLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label readerNameLabel;
        private System.Windows.Forms.Label readerModelLabel;
        private System.Windows.Forms.Label readerIPLabel;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox readerPower;
        private System.Windows.Forms.TextBox readerIP;
        private System.Windows.Forms.TextBox readerModel;
        private System.Windows.Forms.TextBox readerName;
        private System.Windows.Forms.TextBox readerID;
        private System.Windows.Forms.TextBox office;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox readerPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox readerSerial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewCard;
        public System.Windows.Forms.ColumnHeader colLastTime;
        public System.Windows.Forms.ColumnHeader colCardNumber;
        private System.Windows.Forms.Timer timerUpdateListView;

    }
}