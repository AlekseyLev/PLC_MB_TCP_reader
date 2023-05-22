
namespace xxx_degazator

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnConnect = new Button();
            groupBox1 = new GroupBox();
            btnDisconnect = new Button();
            textBoxPort = new TextBox();
            label2 = new Label();
            textBoxIP = new TextBox();
            linkLabel1 = new LinkLabel();
            groupBox3 = new GroupBox();
            lbl_SysMsj = new Label();
            di_check_1 = new CheckBox();
            labelTextXXX = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblStatus = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            timerForProgressBar = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            Counters = new TabPage();
            hexCodirovka = new Label();
            label8 = new Label();
            count4 = new Label();
            count3 = new Label();
            count2 = new Label();
            count1 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            Settings = new TabPage();
            pictureBox_Lock = new PictureBox();
            pictureBox_Auto = new PictureBox();
            btn_Defolt = new Button();
            btn_Change = new Button();
            pictureBox_Manu = new PictureBox();
            tabControl2 = new TabControl();
            tabTEN = new TabPage();
            di_sk_1 = new CheckBox();
            tabPump = new TabPage();
            di_check_2 = new CheckBox();
            tabVakPump = new TabPage();
            di_press2_3 = new CheckBox();
            di_sl1_3 = new CheckBox();
            di_check_3 = new CheckBox();
            tabValve = new TabPage();
            di_slh_4 = new CheckBox();
            di_check_4 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox_SetSeconds = new TextBox();
            label3 = new Label();
            label_Read = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabControl1.SuspendLayout();
            Counters.SuspendLayout();
            Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Lock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Auto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Manu).BeginInit();
            tabControl2.SuspendLayout();
            tabTEN.SuspendLayout();
            tabPump.SuspendLayout();
            tabVakPump.SuspendLayout();
            tabValve.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "IP";
            label1.Click += label1_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(16, 98);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(156, 29);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += butConnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btnDisconnect);
            groupBox1.Controls.Add(textBoxPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxIP);
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(191, 199);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры соединения";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(16, 138);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(156, 29);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // textBoxPort
            // 
            textBoxPort.BackColor = Color.White;
            textBoxPort.Location = new Point(72, 57);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(100, 23);
            textBoxPort.TabIndex = 4;
            textBoxPort.Text = "502";
            textBoxPort.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            label2.Click += label2_Click;
            // 
            // textBoxIP
            // 
            textBoxIP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxIP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxIP.BackColor = Color.White;
            textBoxIP.Location = new Point(72, 25);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(100, 23);
            textBoxIP.TabIndex = 2;
            textBoxIP.Text = "192.168.8.79";
            textBoxIP.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(238, 127, 0);
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(459, 10);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = "https://avtotransformator.ru/";
            linkLabel1.Text = "yourwebsite.com";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_SysMsj);
            groupBox3.Location = new Point(11, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(552, 84);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Системные сообщения";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lbl_SysMsj
            // 
            lbl_SysMsj.AutoSize = true;
            lbl_SysMsj.Enabled = false;
            lbl_SysMsj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SysMsj.ForeColor = Color.FromArgb(238, 127, 0);
            lbl_SysMsj.Location = new Point(7, 19);
            lbl_SysMsj.MaximumSize = new Size(500, 50);
            lbl_SysMsj.Name = "lbl_SysMsj";
            lbl_SysMsj.Size = new Size(215, 17);
            lbl_SysMsj.TabIndex = 28;
            lbl_SysMsj.Text = "Отсутствует связь с контроллером";
            lbl_SysMsj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // di_check_1
            // 
            di_check_1.AutoSize = true;
            di_check_1.BackColor = Color.WhiteSmoke;
            di_check_1.Enabled = false;
            di_check_1.Location = new Point(6, 13);
            di_check_1.Name = "di_check_1";
            di_check_1.Size = new Size(80, 19);
            di_check_1.TabIndex = 0;
            di_check_1.Text = "DI_CHECK";
            di_check_1.UseVisualStyleBackColor = false;
            // 
            // labelTextXXX
            // 
            labelTextXXX.AutoSize = true;
            labelTextXXX.Location = new Point(467, 329);
            labelTextXXX.Name = "labelTextXXX";
            labelTextXXX.Size = new Size(94, 15);
            labelTextXXX.TabIndex = 7;
            labelTextXXX.Text = "ver. 1.0 (NET 7.0)";
            labelTextXXX.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(238, 127, 0);
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.ErrorImage = null;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(108, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.WaitOnLoad = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(238, 127, 0);
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(124, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(238, 127, 0);
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.ErrorImage = null;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(171, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(392, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.WaitOnLoad = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(238, 127, 0);
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.ErrorImage = null;
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(145, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.WaitOnLoad = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(11, 329);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(41, 15);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Ready";
            lblStatus.Click += label12_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.Location = new Point(280, 334);
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(117, 8);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 17;
            progressBar1.Click += progressBar1_Click;
            // 
            // timerForProgressBar
            // 
            timerForProgressBar.Tick += timerForProgressBar_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Counters);
            tabControl1.Controls.Add(Settings);
            tabControl1.Location = new Point(220, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(343, 199);
            tabControl1.TabIndex = 18;
            // 
            // Counters
            // 
            Counters.BackColor = Color.WhiteSmoke;
            Counters.Controls.Add(hexCodirovka);
            Counters.Controls.Add(label8);
            Counters.Controls.Add(count4);
            Counters.Controls.Add(count3);
            Counters.Controls.Add(count2);
            Counters.Controls.Add(count1);
            Counters.Controls.Add(label13);
            Counters.Controls.Add(label14);
            Counters.Controls.Add(label15);
            Counters.Controls.Add(label16);
            Counters.Location = new Point(4, 24);
            Counters.Name = "Counters";
            Counters.Padding = new Padding(3);
            Counters.Size = new Size(335, 171);
            Counters.TabIndex = 1;
            Counters.Text = "Счётчики";
            // 
            // hexCodirovka
            // 
            hexCodirovka.AutoSize = true;
            hexCodirovka.ForeColor = Color.FromArgb(238, 127, 0);
            hexCodirovka.Location = new Point(141, 120);
            hexCodirovka.Name = "hexCodirovka";
            hexCodirovka.Size = new Size(32, 15);
            hexCodirovka.TabIndex = 30;
            hexCodirovka.Text = "-----";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(18, 120);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 29;
            label8.Text = "Кодировка - ";
            // 
            // count4
            // 
            count4.AutoSize = true;
            count4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            count4.ForeColor = Color.FromArgb(238, 127, 0);
            count4.Location = new Point(141, 84);
            count4.Name = "count4";
            count4.Size = new Size(32, 15);
            count4.TabIndex = 28;
            count4.Text = "-----";
            // 
            // count3
            // 
            count3.AutoSize = true;
            count3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            count3.ForeColor = Color.FromArgb(238, 127, 0);
            count3.Location = new Point(141, 59);
            count3.Name = "count3";
            count3.Size = new Size(32, 15);
            count3.TabIndex = 27;
            count3.Text = "-----";
            // 
            // count2
            // 
            count2.AutoSize = true;
            count2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            count2.ForeColor = Color.FromArgb(238, 127, 0);
            count2.Location = new Point(141, 31);
            count2.Name = "count2";
            count2.Size = new Size(32, 15);
            count2.TabIndex = 26;
            count2.Text = "-----";
            // 
            // count1
            // 
            count1.AutoSize = true;
            count1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            count1.ForeColor = Color.FromArgb(238, 127, 0);
            count1.Location = new Point(141, 9);
            count1.Name = "count1";
            count1.Size = new Size(32, 15);
            count1.TabIndex = 25;
            count1.Text = "-----";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(18, 84);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 24;
            label13.Text = "ЭМ-клапан -";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(18, 59);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 23;
            label14.Text = "Вак. насос";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(18, 34);
            label15.Name = "label15";
            label15.Size = new Size(84, 15);
            label15.TabIndex = 22;
            label15.Text = "Маслонасос -";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(18, 9);
            label16.Name = "label16";
            label16.Size = new Size(46, 15);
            label16.TabIndex = 21;
            label16.Text = "ТЭНы -";
            // 
            // Settings
            // 
            Settings.BackColor = Color.WhiteSmoke;
            Settings.Controls.Add(pictureBox_Lock);
            Settings.Controls.Add(pictureBox_Auto);
            Settings.Controls.Add(btn_Defolt);
            Settings.Controls.Add(btn_Change);
            Settings.Controls.Add(pictureBox_Manu);
            Settings.Controls.Add(tabControl2);
            Settings.Controls.Add(label6);
            Settings.Controls.Add(label5);
            Settings.Controls.Add(label4);
            Settings.Controls.Add(textBox_SetSeconds);
            Settings.Controls.Add(label3);
            Settings.Location = new Point(4, 24);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(3);
            Settings.Size = new Size(335, 171);
            Settings.TabIndex = 0;
            Settings.Text = "Настройки";
            // 
            // pictureBox_Lock
            // 
            pictureBox_Lock.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Lock.Cursor = Cursors.Hand;
            pictureBox_Lock.ErrorImage = null;
            pictureBox_Lock.Image = (Image)resources.GetObject("pictureBox_Lock.Image");
            pictureBox_Lock.InitialImage = null;
            pictureBox_Lock.Location = new Point(296, 7);
            pictureBox_Lock.Name = "pictureBox_Lock";
            pictureBox_Lock.Size = new Size(29, 21);
            pictureBox_Lock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Lock.TabIndex = 23;
            pictureBox_Lock.TabStop = false;
            pictureBox_Lock.WaitOnLoad = true;
            pictureBox_Lock.Click += pictureBox_Lock_Click;
            // 
            // pictureBox_Auto
            // 
            pictureBox_Auto.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Auto.Cursor = Cursors.Hand;
            pictureBox_Auto.ErrorImage = null;
            pictureBox_Auto.Image = (Image)resources.GetObject("pictureBox_Auto.Image");
            pictureBox_Auto.InitialImage = null;
            pictureBox_Auto.Location = new Point(173, 4);
            pictureBox_Auto.Name = "pictureBox_Auto";
            pictureBox_Auto.Size = new Size(29, 21);
            pictureBox_Auto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Auto.TabIndex = 22;
            pictureBox_Auto.TabStop = false;
            pictureBox_Auto.WaitOnLoad = true;
            pictureBox_Auto.Click += pictureBox6_Click_1;
            // 
            // btn_Defolt
            // 
            btn_Defolt.Enabled = false;
            btn_Defolt.Location = new Point(173, 139);
            btn_Defolt.Name = "btn_Defolt";
            btn_Defolt.Size = new Size(152, 29);
            btn_Defolt.TabIndex = 21;
            btn_Defolt.Text = "По умолчанию";
            btn_Defolt.UseVisualStyleBackColor = true;
            btn_Defolt.Click += btn_Defolt_Click;
            // 
            // btn_Change
            // 
            btn_Change.Enabled = false;
            btn_Change.Location = new Point(19, 139);
            btn_Change.Name = "btn_Change";
            btn_Change.Size = new Size(143, 29);
            btn_Change.TabIndex = 20;
            btn_Change.Text = "Изменить";
            btn_Change.UseVisualStyleBackColor = true;
            btn_Change.Click += btn_Change_Click;
            // 
            // pictureBox_Manu
            // 
            pictureBox_Manu.BackgroundImageLayout = ImageLayout.None;
            pictureBox_Manu.Cursor = Cursors.Hand;
            pictureBox_Manu.ErrorImage = null;
            pictureBox_Manu.Image = (Image)resources.GetObject("pictureBox_Manu.Image");
            pictureBox_Manu.InitialImage = null;
            pictureBox_Manu.Location = new Point(115, 50);
            pictureBox_Manu.Name = "pictureBox_Manu";
            pictureBox_Manu.Size = new Size(29, 21);
            pictureBox_Manu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Manu.TabIndex = 19;
            pictureBox_Manu.TabStop = false;
            pictureBox_Manu.WaitOnLoad = true;
            pictureBox_Manu.Click += pictureBox6_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabTEN);
            tabControl2.Controls.Add(tabPump);
            tabControl2.Controls.Add(tabVakPump);
            tabControl2.Controls.Add(tabValve);
            tabControl2.Location = new Point(15, 71);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(314, 66);
            tabControl2.TabIndex = 10;
            // 
            // tabTEN
            // 
            tabTEN.BackColor = Color.WhiteSmoke;
            tabTEN.Controls.Add(di_sk_1);
            tabTEN.Controls.Add(di_check_1);
            tabTEN.Location = new Point(4, 24);
            tabTEN.Name = "tabTEN";
            tabTEN.Padding = new Padding(3);
            tabTEN.Size = new Size(306, 38);
            tabTEN.TabIndex = 0;
            tabTEN.Text = "ТЭНы";
            // 
            // di_sk_1
            // 
            di_sk_1.AutoSize = true;
            di_sk_1.Enabled = false;
            di_sk_1.Location = new Point(88, 12);
            di_sk_1.Name = "di_sk_1";
            di_sk_1.Size = new Size(55, 19);
            di_sk_1.TabIndex = 1;
            di_sk_1.Text = "DI_SK";
            di_sk_1.UseVisualStyleBackColor = true;
            // 
            // tabPump
            // 
            tabPump.BackColor = Color.WhiteSmoke;
            tabPump.Controls.Add(di_check_2);
            tabPump.Location = new Point(4, 24);
            tabPump.Name = "tabPump";
            tabPump.Padding = new Padding(3);
            tabPump.Size = new Size(306, 38);
            tabPump.TabIndex = 1;
            tabPump.Text = "Маслонасос";
            // 
            // di_check_2
            // 
            di_check_2.AutoSize = true;
            di_check_2.Enabled = false;
            di_check_2.Location = new Point(6, 13);
            di_check_2.Name = "di_check_2";
            di_check_2.Size = new Size(80, 19);
            di_check_2.TabIndex = 3;
            di_check_2.Text = "DI_CHECK";
            di_check_2.UseVisualStyleBackColor = true;
            // 
            // tabVakPump
            // 
            tabVakPump.BackColor = Color.WhiteSmoke;
            tabVakPump.Controls.Add(di_press2_3);
            tabVakPump.Controls.Add(di_sl1_3);
            tabVakPump.Controls.Add(di_check_3);
            tabVakPump.Location = new Point(4, 24);
            tabVakPump.Name = "tabVakPump";
            tabVakPump.Size = new Size(306, 38);
            tabVakPump.TabIndex = 2;
            tabVakPump.Text = "Вак.насос";
            // 
            // di_press2_3
            // 
            di_press2_3.AutoSize = true;
            di_press2_3.Enabled = false;
            di_press2_3.Location = new Point(149, 12);
            di_press2_3.Name = "di_press2_3";
            di_press2_3.Size = new Size(80, 19);
            di_press2_3.TabIndex = 4;
            di_press2_3.Text = "DI_PRESS2";
            di_press2_3.UseVisualStyleBackColor = true;
            // 
            // di_sl1_3
            // 
            di_sl1_3.AutoSize = true;
            di_sl1_3.Enabled = false;
            di_sl1_3.Location = new Point(88, 12);
            di_sl1_3.Name = "di_sl1_3";
            di_sl1_3.Size = new Size(60, 19);
            di_sl1_3.TabIndex = 3;
            di_sl1_3.Text = "DI_SL1";
            di_sl1_3.UseVisualStyleBackColor = true;
            // 
            // di_check_3
            // 
            di_check_3.AutoSize = true;
            di_check_3.Enabled = false;
            di_check_3.Location = new Point(6, 13);
            di_check_3.Name = "di_check_3";
            di_check_3.Size = new Size(80, 19);
            di_check_3.TabIndex = 2;
            di_check_3.Text = "DI_CHECK";
            di_check_3.UseVisualStyleBackColor = true;
            // 
            // tabValve
            // 
            tabValve.BackColor = Color.WhiteSmoke;
            tabValve.Controls.Add(di_slh_4);
            tabValve.Controls.Add(di_check_4);
            tabValve.Location = new Point(4, 24);
            tabValve.Name = "tabValve";
            tabValve.Size = new Size(306, 38);
            tabValve.TabIndex = 3;
            tabValve.Text = "ЭМ-клапан";
            // 
            // di_slh_4
            // 
            di_slh_4.AutoSize = true;
            di_slh_4.Enabled = false;
            di_slh_4.Location = new Point(88, 12);
            di_slh_4.Name = "di_slh_4";
            di_slh_4.Size = new Size(63, 19);
            di_slh_4.TabIndex = 3;
            di_slh_4.Text = "DI_SLH";
            di_slh_4.UseVisualStyleBackColor = true;
            // 
            // di_check_4
            // 
            di_check_4.AutoSize = true;
            di_check_4.Enabled = false;
            di_check_4.Location = new Point(6, 13);
            di_check_4.Name = "di_check_4";
            di_check_4.Size = new Size(80, 19);
            di_check_4.TabIndex = 2;
            di_check_4.Text = "DI_CHECK";
            di_check_4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 51);
            label6.Name = "label6";
            label6.Size = new Size(103, 17);
            label6.TabIndex = 9;
            label6.Text = "Ручной режим";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 7);
            label5.Name = "label5";
            label5.Size = new Size(162, 17);
            label5.TabIndex = 8;
            label5.Text = "Автоматический режим";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 29);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "сек.";
            label4.Click += label4_Click;
            // 
            // textBox_SetSeconds
            // 
            textBox_SetSeconds.BackColor = Color.White;
            textBox_SetSeconds.Enabled = false;
            textBox_SetSeconds.Location = new Point(173, 25);
            textBox_SetSeconds.Name = "textBox_SetSeconds";
            textBox_SetSeconds.Size = new Size(32, 23);
            textBox_SetSeconds.TabIndex = 6;
            textBox_SetSeconds.Text = "x";
            textBox_SetSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 29);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 5;
            label3.Text = "Таймер выдержки КМ1-К4";
            label3.Click += label3_Click_1;
            // 
            // label_Read
            // 
            label_Read.AutoSize = true;
            label_Read.Enabled = false;
            label_Read.ForeColor = Color.Black;
            label_Read.Location = new Point(158, 329);
            label_Read.Name = "label_Read";
            label_Read.Size = new Size(120, 15);
            label_Read.TabIndex = 31;
            label_Read.Text = "Обновление данных";
            label_Read.Click += label7_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(574, 350);
            Controls.Add(progressBar1);
            Controls.Add(label_Read);
            Controls.Add(tabControl1);
            Controls.Add(linkLabel1);
            Controls.Add(lblStatus);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(labelTextXXX);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            MaximumSize = new Size(590, 389);
            MinimumSize = new Size(590, 389);
            Name = "Form1";
            Text = "xxx - дегазатор";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabControl1.ResumeLayout(false);
            Counters.ResumeLayout(false);
            Counters.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Lock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Auto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Manu).EndInit();
            tabControl2.ResumeLayout(false);
            tabTEN.ResumeLayout(false);
            tabTEN.PerformLayout();
            tabPump.ResumeLayout(false);
            tabPump.PerformLayout();
            tabVakPump.ResumeLayout(false);
            tabVakPump.PerformLayout();
            tabValve.ResumeLayout(false);
            tabValve.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConnect;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBoxIP;
        private Button btnDisconnect;
        private TextBox textBoxPort;
        private LinkLabel linkLabel1;
        private GroupBox groupBox3;
        private Label labelTextXXX;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerForProgressBar;
        private TabControl tabControl1;
        private TabPage Settings;
        private TabPage Counters;
        private Label hexCodirovka;
        private Label label8;
        private Label count4;
        private Label count3;
        private Label count2;
        private Label count1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox_SetSeconds;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TabControl tabControl2;
        private TabPage tabTEN;
        private TabPage tabPump;
        private TabPage tabVakPump;
        private TabPage tabValve;
        private PictureBox pictureBox_Manu;
        private CheckBox di_check_1;
        private CheckBox di_sk_1;
        private CheckBox di_check_2;
        private CheckBox di_check_3;
        private CheckBox di_press2_3;
        private CheckBox di_sl1_3;
        private CheckBox di_slh_4;
        private CheckBox di_check_4;
        private Button btn_Defolt;
        private Button btn_Change;
        private Label label_Read;
        private PictureBox pictureBox_Auto;
        private PictureBox pictureBox_Lock;
        private Label lbl_SysMsj;
    }
}