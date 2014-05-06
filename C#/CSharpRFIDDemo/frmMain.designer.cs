namespace CSharpRFIDDemo
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenConn = new System.Windows.Forms.Button();
            this.gbxCommModel = new System.Windows.Forms.GroupBox();
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.rbnCom = new System.Windows.Forms.RadioButton();
            this.rbnTCP = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxBeep = new System.Windows.Forms.CheckBox();
            this.btnReadCards = new System.Windows.Forms.Button();
            this.listViewCard = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReadCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBeginTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerUpdateListView = new System.Windows.Forms.Timer(this.components);
            this.btnStopReadCards = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListViewCard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelDisTig = new System.Windows.Forms.Label();
            this.btnShowCopyright = new System.Windows.Forms.Button();
            this.btnSetReaderName = new System.Windows.Forms.Button();
            this.btnLoadSysInfo = new System.Windows.Forms.Button();
            this.txtBaseHardVersion = new System.Windows.Forms.TextBox();
            this.txtProcessVersion = new System.Windows.Forms.TextBox();
            this.txtReaderSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReaderType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIOOperate = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbxCommModel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenConn
            // 
            this.btnOpenConn.Location = new System.Drawing.Point(24, 317);
            this.btnOpenConn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenConn.Name = "btnOpenConn";
            this.btnOpenConn.Size = new System.Drawing.Size(192, 48);
            this.btnOpenConn.TabIndex = 0;
            this.btnOpenConn.Text = "Open(&O)";
            this.btnOpenConn.UseVisualStyleBackColor = true;
            this.btnOpenConn.Click += new System.EventHandler(this.btnOpenConn_Click);
            // 
            // gbxCommModel
            // 
            this.gbxCommModel.Controls.Add(this.cbxCom);
            this.gbxCommModel.Controls.Add(this.txtPoint);
            this.gbxCommModel.Controls.Add(this.txtIP);
            this.gbxCommModel.Controls.Add(this.rbnCom);
            this.gbxCommModel.Controls.Add(this.rbnTCP);
            this.gbxCommModel.Controls.Add(this.label11);
            this.gbxCommModel.Controls.Add(this.label10);
            this.gbxCommModel.Location = new System.Drawing.Point(24, 17);
            this.gbxCommModel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxCommModel.Name = "gbxCommModel";
            this.gbxCommModel.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxCommModel.Size = new System.Drawing.Size(304, 287);
            this.gbxCommModel.TabIndex = 1;
            this.gbxCommModel.TabStop = false;
            this.gbxCommModel.Text = "Connect Type";
            // 
            // cbxCom
            // 
            this.cbxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cbxCom.Location = new System.Drawing.Point(86, 227);
            this.cbxCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(200, 33);
            this.cbxCom.TabIndex = 7;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(86, 133);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(200, 31);
            this.txtPoint.TabIndex = 4;
            this.txtPoint.TextChanged += new System.EventHandler(this.txtPoint_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(86, 79);
            this.txtIP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(200, 31);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // rbnCom
            // 
            this.rbnCom.AutoSize = true;
            this.rbnCom.Location = new System.Drawing.Point(20, 190);
            this.rbnCom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbnCom.Name = "rbnCom";
            this.rbnCom.Size = new System.Drawing.Size(92, 29);
            this.rbnCom.TabIndex = 1;
            this.rbnCom.TabStop = true;
            this.rbnCom.Text = "COM";
            this.rbnCom.UseVisualStyleBackColor = true;
            // 
            // rbnTCP
            // 
            this.rbnTCP.AutoSize = true;
            this.rbnTCP.Location = new System.Drawing.Point(20, 48);
            this.rbnTCP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbnTCP.Name = "rbnTCP";
            this.rbnTCP.Size = new System.Drawing.Size(85, 29);
            this.rbnTCP.TabIndex = 1;
            this.rbnTCP.TabStop = true;
            this.rbnTCP.Text = "NET";
            this.rbnTCP.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Port:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "IP:";
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Location = new System.Drawing.Point(24, 377);
            this.btnCloseConn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(192, 48);
            this.btnCloseConn.TabIndex = 0;
            this.btnCloseConn.Text = "Close(&C)";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 1017);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxBeep
            // 
            this.cbxBeep.AutoSize = true;
            this.cbxBeep.Location = new System.Drawing.Point(24, 460);
            this.cbxBeep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxBeep.Name = "cbxBeep";
            this.cbxBeep.Size = new System.Drawing.Size(106, 29);
            this.cbxBeep.TabIndex = 2;
            this.cbxBeep.Text = "Sound";
            this.cbxBeep.UseVisualStyleBackColor = true;
            this.cbxBeep.CheckedChanged += new System.EventHandler(this.cbxBeep_CheckedChanged);
            // 
            // btnReadCards
            // 
            this.btnReadCards.Location = new System.Drawing.Point(90, 42);
            this.btnReadCards.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadCards.Name = "btnReadCards";
            this.btnReadCards.Size = new System.Drawing.Size(150, 48);
            this.btnReadCards.TabIndex = 3;
            this.btnReadCards.Text = "Start";
            this.btnReadCards.UseVisualStyleBackColor = true;
            this.btnReadCards.Click += new System.EventHandler(this.btnReadCards_Click);
            // 
            // listViewCard
            // 
            this.listViewCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colCardNumber,
            this.colReadCount,
            this.colBeginTime,
            this.colLastTime});
            this.listViewCard.FullRowSelect = true;
            this.listViewCard.Location = new System.Drawing.Point(12, 102);
            this.listViewCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewCard.Name = "listViewCard";
            this.listViewCard.Size = new System.Drawing.Size(1178, 346);
            this.listViewCard.TabIndex = 4;
            this.listViewCard.UseCompatibleStateImageBehavior = false;
            this.listViewCard.View = System.Windows.Forms.View.Details;
            // 
            // colNumber
            // 
            this.colNumber.Text = "Index";
            // 
            // colCardNumber
            // 
            this.colCardNumber.Text = "ID";
            this.colCardNumber.Width = 200;
            // 
            // colReadCount
            // 
            this.colReadCount.Text = "Count";
            this.colReadCount.Width = 127;
            // 
            // colBeginTime
            // 
            this.colBeginTime.Text = "Begin time";
            this.colBeginTime.Width = 80;
            // 
            // colLastTime
            // 
            this.colLastTime.Text = "Latest time";
            this.colLastTime.Width = 86;
            // 
            // timerUpdateListView
            // 
            this.timerUpdateListView.Enabled = true;
            this.timerUpdateListView.Interval = 200;
            this.timerUpdateListView.Tick += new System.EventHandler(this.timerUpdateListView_Tick);
            // 
            // btnStopReadCards
            // 
            this.btnStopReadCards.Location = new System.Drawing.Point(252, 42);
            this.btnStopReadCards.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStopReadCards.Name = "btnStopReadCards";
            this.btnStopReadCards.Size = new System.Drawing.Size(150, 48);
            this.btnStopReadCards.TabIndex = 3;
            this.btnStopReadCards.Text = "Stop";
            this.btnStopReadCards.UseVisualStyleBackColor = true;
            this.btnStopReadCards.Click += new System.EventHandler(this.btnStopReadCards_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListViewCard);
            this.groupBox1.Controls.Add(this.btnReadCards);
            this.groupBox1.Controls.Add(this.btnStopReadCards);
            this.groupBox1.Controls.Add(this.listViewCard);
            this.groupBox1.Location = new System.Drawing.Point(340, 477);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1206, 465);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read";
            // 
            // btnListViewCard
            // 
            this.btnListViewCard.Location = new System.Drawing.Point(492, 44);
            this.btnListViewCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnListViewCard.Name = "btnListViewCard";
            this.btnListViewCard.Size = new System.Drawing.Size(150, 48);
            this.btnListViewCard.TabIndex = 5;
            this.btnListViewCard.Text = "Reset";
            this.btnListViewCard.UseVisualStyleBackColor = true;
            this.btnListViewCard.Click += new System.EventHandler(this.btnListViewCard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelDisTig);
            this.groupBox2.Controls.Add(this.btnShowCopyright);
            this.groupBox2.Controls.Add(this.btnSetReaderName);
            this.groupBox2.Controls.Add(this.btnLoadSysInfo);
            this.groupBox2.Controls.Add(this.txtBaseHardVersion);
            this.groupBox2.Controls.Add(this.txtProcessVersion);
            this.groupBox2.Controls.Add(this.txtReaderSerial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtReaderType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtReaderName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(340, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1206, 448);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Config";
            // 
            // LabelDisTig
            // 
            this.LabelDisTig.BackColor = System.Drawing.Color.Transparent;
            this.LabelDisTig.Font = new System.Drawing.Font("SimSun", 20F);
            this.LabelDisTig.ForeColor = System.Drawing.Color.Red;
            this.LabelDisTig.Location = new System.Drawing.Point(418, 25);
            this.LabelDisTig.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDisTig.Name = "LabelDisTig";
            this.LabelDisTig.Size = new System.Drawing.Size(776, 67);
            this.LabelDisTig.TabIndex = 6;
            // 
            // btnShowCopyright
            // 
            this.btnShowCopyright.Location = new System.Drawing.Point(256, 42);
            this.btnShowCopyright.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowCopyright.Name = "btnShowCopyright";
            this.btnShowCopyright.Size = new System.Drawing.Size(150, 48);
            this.btnShowCopyright.TabIndex = 5;
            this.btnShowCopyright.Text = "Copyright";
            this.btnShowCopyright.UseVisualStyleBackColor = true;
            this.btnShowCopyright.Click += new System.EventHandler(this.btnShowCopyright_Click);
            // 
            // btnSetReaderName
            // 
            this.btnSetReaderName.Location = new System.Drawing.Point(990, 108);
            this.btnSetReaderName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSetReaderName.Name = "btnSetReaderName";
            this.btnSetReaderName.Size = new System.Drawing.Size(150, 42);
            this.btnSetReaderName.TabIndex = 3;
            this.btnSetReaderName.Text = "Set";
            this.btnSetReaderName.UseVisualStyleBackColor = true;
            this.btnSetReaderName.Click += new System.EventHandler(this.btnSetReaderName_Click);
            // 
            // btnLoadSysInfo
            // 
            this.btnLoadSysInfo.Location = new System.Drawing.Point(94, 42);
            this.btnLoadSysInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadSysInfo.Name = "btnLoadSysInfo";
            this.btnLoadSysInfo.Size = new System.Drawing.Size(150, 48);
            this.btnLoadSysInfo.TabIndex = 2;
            this.btnLoadSysInfo.Text = "Read System Infomation";
            this.btnLoadSysInfo.UseVisualStyleBackColor = true;
            this.btnLoadSysInfo.Click += new System.EventHandler(this.btnLoadSysInfo_Click);
            // 
            // txtBaseHardVersion
            // 
            this.txtBaseHardVersion.Location = new System.Drawing.Point(278, 333);
            this.txtBaseHardVersion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBaseHardVersion.Name = "txtBaseHardVersion";
            this.txtBaseHardVersion.ReadOnly = true;
            this.txtBaseHardVersion.Size = new System.Drawing.Size(676, 31);
            this.txtBaseHardVersion.TabIndex = 1;
            // 
            // txtProcessVersion
            // 
            this.txtProcessVersion.Location = new System.Drawing.Point(278, 277);
            this.txtProcessVersion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProcessVersion.Name = "txtProcessVersion";
            this.txtProcessVersion.ReadOnly = true;
            this.txtProcessVersion.Size = new System.Drawing.Size(676, 31);
            this.txtProcessVersion.TabIndex = 1;
            // 
            // txtReaderSerial
            // 
            this.txtReaderSerial.Location = new System.Drawing.Point(278, 165);
            this.txtReaderSerial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReaderSerial.MaxLength = 8;
            this.txtReaderSerial.Name = "txtReaderSerial";
            this.txtReaderSerial.ReadOnly = true;
            this.txtReaderSerial.Size = new System.Drawing.Size(676, 31);
            this.txtReaderSerial.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hardware version";
            // 
            // txtReaderType
            // 
            this.txtReaderType.Location = new System.Drawing.Point(278, 221);
            this.txtReaderType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReaderType.MaxLength = 5;
            this.txtReaderType.Name = "txtReaderType";
            this.txtReaderType.ReadOnly = true;
            this.txtReaderType.Size = new System.Drawing.Size(676, 31);
            this.txtReaderType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Software version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product type";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(278, 108);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReaderName.MaxLength = 8;
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(676, 31);
            this.txtReaderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serial No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device name";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 25;
            this.lstResult.Location = new System.Drawing.Point(24, 698);
            this.lstResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(300, 304);
            this.lstResult.TabIndex = 8;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(24, 640);
            this.btnClearResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(192, 48);
            this.btnClearResult.TabIndex = 9;
            this.btnClearResult.Text = "Clear List";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIOOperate);
            this.groupBox3.Controls.Add(this.cbxState);
            this.groupBox3.Controls.Add(this.cbxPort);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(342, 956);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1204, 108);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IO output operation";
            // 
            // btnIOOperate
            // 
            this.btnIOOperate.Location = new System.Drawing.Point(470, 42);
            this.btnIOOperate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnIOOperate.Name = "btnIOOperate";
            this.btnIOOperate.Size = new System.Drawing.Size(114, 48);
            this.btnIOOperate.TabIndex = 36;
            this.btnIOOperate.Text = "Ok";
            this.btnIOOperate.UseVisualStyleBackColor = true;
            this.btnIOOperate.Click += new System.EventHandler(this.btnIOOperate_Click);
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "Out low level",
            "Out high level",
            "Out positive pulse",
            "Out negative pulse"});
            this.cbxState.Location = new System.Drawing.Point(326, 46);
            this.cbxState.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(128, 33);
            this.cbxState.TabIndex = 35;
            // 
            // cbxPort
            // 
            this.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Items.AddRange(new object[] {
            "All port",
            "port 1",
            "port 2"});
            this.cbxPort.Location = new System.Drawing.Point(182, 48);
            this.cbxPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(128, 33);
            this.cbxPort.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "output:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1562, 1079);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxBeep);
            this.Controls.Add(this.gbxCommModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCloseConn);
            this.Controls.Add(this.btnOpenConn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSN Chile - RFID Reader Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxCommModel.ResumeLayout(false);
            this.gbxCommModel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenConn;
        private System.Windows.Forms.GroupBox gbxCommModel;
        private System.Windows.Forms.RadioButton rbnTCP;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbxBeep;
        private System.Windows.Forms.Button btnReadCards;
        private System.Windows.Forms.ListView listViewCard;
        public System.Windows.Forms.ColumnHeader colNumber;
        public System.Windows.Forms.ColumnHeader colCardNumber;
        public System.Windows.Forms.ColumnHeader colReadCount;
        public System.Windows.Forms.ColumnHeader colBeginTime;
        public System.Windows.Forms.ColumnHeader colLastTime;
        private System.Windows.Forms.Timer timerUpdateListView;
        private System.Windows.Forms.Button btnStopReadCards;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReaderSerial;
        private System.Windows.Forms.TextBox txtReaderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseHardVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadSysInfo;
        private System.Windows.Forms.Button btnSetReaderName;
        private System.Windows.Forms.Button btnShowCopyright;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnListViewCard;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.RadioButton rbnCom;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Button btnIOOperate;
        private System.Windows.Forms.Label LabelDisTig;
    }
}

