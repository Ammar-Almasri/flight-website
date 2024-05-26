namespace Ammarinho_s_Airlines
{
    partial class frmBook
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabTripInfo = new System.Windows.Forms.TabPage();
            this.noOfGuests = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoneTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDonePersonal = new System.Windows.Forms.Button();
            this.txtboxNat = new System.Windows.Forms.TextBox();
            this.txtboxLName = new System.Windows.Forms.TextBox();
            this.txtboxPNum = new System.Windows.Forms.TextBox();
            this.txtboxFName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.tabBaggage = new System.Windows.Forms.TabPage();
            this.btnDoneBaggage = new System.Windows.Forms.Button();
            this.noOfHandBags = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noOfBags = new System.Windows.Forms.NumericUpDown();
            this.chkboxprohibited = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.btnViewTckt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnbook = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxCVV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtboxCardNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab.SuspendLayout();
            this.tabTripInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfGuests)).BeginInit();
            this.tabPersonal.SuspendLayout();
            this.tabBaggage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfHandBags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfBags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabTripInfo);
            this.tab.Controls.Add(this.tabPersonal);
            this.tab.Controls.Add(this.tabBaggage);
            this.tab.Controls.Add(this.tabPayment);
            this.tab.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(112, 99);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(849, 481);
            this.tab.TabIndex = 0;
            this.tab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_MouseDown);
            // 
            // tabTripInfo
            // 
            this.tabTripInfo.BackColor = System.Drawing.Color.LightBlue;
            this.tabTripInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabTripInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTripInfo.Controls.Add(this.noOfGuests);
            this.tabTripInfo.Controls.Add(this.label5);
            this.tabTripInfo.Controls.Add(this.btnDoneTrip);
            this.tabTripInfo.Controls.Add(this.label4);
            this.tabTripInfo.Controls.Add(this.label3);
            this.tabTripInfo.Controls.Add(this.dateTimePicker2);
            this.tabTripInfo.Controls.Add(this.dateTimePicker1);
            this.tabTripInfo.Controls.Add(this.label2);
            this.tabTripInfo.Controls.Add(this.label1);
            this.tabTripInfo.Controls.Add(this.comboBoxTo);
            this.tabTripInfo.Controls.Add(this.comboBoxFrom);
            this.tabTripInfo.Location = new System.Drawing.Point(4, 35);
            this.tabTripInfo.Name = "tabTripInfo";
            this.tabTripInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTripInfo.Size = new System.Drawing.Size(841, 442);
            this.tabTripInfo.TabIndex = 0;
            this.tabTripInfo.Text = "Trip Info";
//            this.tabTripInfo.Click += new System.EventHandler(this.tabTripInfo_Click);
            // 
            // noOfGuests
            // 
            this.noOfGuests.Font = new System.Drawing.Font("Bahnschrift Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfGuests.Location = new System.Drawing.Point(427, 271);
            this.noOfGuests.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.noOfGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noOfGuests.Name = "noOfGuests";
            this.noOfGuests.Size = new System.Drawing.Size(123, 40);
            this.noOfGuests.TabIndex = 27;
            this.noOfGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(304, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "Guests : ";
            // 
            // btnDoneTrip
            // 
            this.btnDoneTrip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneTrip.Location = new System.Drawing.Point(351, 366);
            this.btnDoneTrip.Name = "btnDoneTrip";
            this.btnDoneTrip.Size = new System.Drawing.Size(140, 51);
            this.btnDoneTrip.TabIndex = 24;
            this.btnDoneTrip.Text = "Done";
            this.btnDoneTrip.UseVisualStyleBackColor = true;
            this.btnDoneTrip.Click += new System.EventHandler(this.btnDoneTrip_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Return : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Outbound : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(446, 168);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(320, 27);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.Value = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 168);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 27);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(440, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Flying to : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Flying from : ";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "Abu Dhabi, AUH",
            "London, LHR",
            "Turin, TRN"});
            this.comboBoxTo.Location = new System.Drawing.Point(599, 52);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(191, 27);
            this.comboBoxTo.TabIndex = 14;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "Amman, AMM",
            "Irbid, IRB"});
            this.comboBoxFrom.Location = new System.Drawing.Point(191, 52);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(191, 27);
            this.comboBoxFrom.TabIndex = 15;
            // 
            // tabPersonal
            // 
            this.tabPersonal.BackColor = System.Drawing.Color.LightBlue;
            this.tabPersonal.Controls.Add(this.txtBoxAge);
            this.tabPersonal.Controls.Add(this.label9);
            this.tabPersonal.Controls.Add(this.label8);
            this.tabPersonal.Controls.Add(this.btnDonePersonal);
            this.tabPersonal.Controls.Add(this.txtboxNat);
            this.tabPersonal.Controls.Add(this.txtboxLName);
            this.tabPersonal.Controls.Add(this.txtboxPNum);
            this.tabPersonal.Controls.Add(this.txtboxFName);
            this.tabPersonal.Controls.Add(this.label6);
            this.tabPersonal.Controls.Add(this.label7);
            this.tabPersonal.Controls.Add(this.lblLName);
            this.tabPersonal.Controls.Add(this.lblFname);
            this.tabPersonal.Location = new System.Drawing.Point(4, 35);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(841, 442);
            this.tabPersonal.TabIndex = 1;
            this.tabPersonal.Text = "Personal Info";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAge.Location = new System.Drawing.Point(32, 260);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(176, 27);
            this.txtBoxAge.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 34);
            this.label9.TabIndex = 38;
            this.label9.Text = "Age :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(666, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 34);
            this.label8.TabIndex = 37;
            this.label8.Text = "* Must Fill";
            // 
            // btnDonePersonal
            // 
            this.btnDonePersonal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonePersonal.Location = new System.Drawing.Point(355, 375);
            this.btnDonePersonal.Name = "btnDonePersonal";
            this.btnDonePersonal.Size = new System.Drawing.Size(140, 51);
            this.btnDonePersonal.TabIndex = 36;
            this.btnDonePersonal.Text = "Done";
            this.btnDonePersonal.UseVisualStyleBackColor = true;
            this.btnDonePersonal.Click += new System.EventHandler(this.btnDonePersonal_Click);
            // 
            // txtboxNat
            // 
            this.txtboxNat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNat.Location = new System.Drawing.Point(466, 168);
            this.txtboxNat.Name = "txtboxNat";
            this.txtboxNat.Size = new System.Drawing.Size(176, 27);
            this.txtboxNat.TabIndex = 34;
            // 
            // txtboxLName
            // 
            this.txtboxLName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLName.Location = new System.Drawing.Point(466, 82);
            this.txtboxLName.Name = "txtboxLName";
            this.txtboxLName.Size = new System.Drawing.Size(176, 27);
            this.txtboxLName.TabIndex = 32;
            // 
            // txtboxPNum
            // 
            this.txtboxPNum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPNum.Location = new System.Drawing.Point(32, 168);
            this.txtboxPNum.Name = "txtboxPNum";
            this.txtboxPNum.Size = new System.Drawing.Size(176, 27);
            this.txtboxPNum.TabIndex = 33;
            // 
            // txtboxFName
            // 
            this.txtboxFName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFName.Location = new System.Drawing.Point(32, 77);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(176, 27);
            this.txtboxFName.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(466, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 34);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nationality *: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 34);
            this.label7.TabIndex = 29;
            this.label7.Text = "Passport no.*";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.LightGray;
            this.lblLName.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.Black;
            this.lblLName.Location = new System.Drawing.Point(466, 45);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(175, 34);
            this.lblLName.TabIndex = 28;
            this.lblLName.Text = "Last Name* :";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.LightGray;
            this.lblFname.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Black;
            this.lblFname.Location = new System.Drawing.Point(32, 40);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(180, 34);
            this.lblFname.TabIndex = 27;
            this.lblFname.Text = "First Name* :";
            // 
            // tabBaggage
            // 
            this.tabBaggage.BackColor = System.Drawing.Color.LightBlue;
            this.tabBaggage.Controls.Add(this.btnDoneBaggage);
            this.tabBaggage.Controls.Add(this.noOfHandBags);
            this.tabBaggage.Controls.Add(this.label12);
            this.tabBaggage.Controls.Add(this.label11);
            this.tabBaggage.Controls.Add(this.noOfBags);
            this.tabBaggage.Controls.Add(this.chkboxprohibited);
            this.tabBaggage.Controls.Add(this.pictureBox1);
            this.tabBaggage.Controls.Add(this.label10);
            this.tabBaggage.Location = new System.Drawing.Point(4, 35);
            this.tabBaggage.Name = "tabBaggage";
            this.tabBaggage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaggage.Size = new System.Drawing.Size(841, 442);
            this.tabBaggage.TabIndex = 2;
            this.tabBaggage.Text = "Baggage Info";
            // 
            // btnDoneBaggage
            // 
            this.btnDoneBaggage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneBaggage.Location = new System.Drawing.Point(360, 385);
            this.btnDoneBaggage.Name = "btnDoneBaggage";
            this.btnDoneBaggage.Size = new System.Drawing.Size(140, 51);
            this.btnDoneBaggage.TabIndex = 35;
            this.btnDoneBaggage.Text = "Done";
            this.btnDoneBaggage.UseVisualStyleBackColor = true;
            this.btnDoneBaggage.Click += new System.EventHandler(this.btnDoneBaggage_Click);
            // 
            // noOfHandBags
            // 
            this.noOfHandBags.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfHandBags.Location = new System.Drawing.Point(537, 313);
            this.noOfHandBags.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.noOfHandBags.Name = "noOfHandBags";
            this.noOfHandBags.Size = new System.Drawing.Size(158, 34);
            this.noOfHandBags.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(537, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 34);
            this.label12.TabIndex = 33;
            this.label12.Text = "Hand Bags : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Font = new System.Drawing.Font("Bodoni MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(537, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 32);
            this.label11.TabIndex = 32;
            this.label11.Text = "Baggage Count : ";
            // 
            // noOfBags
            // 
            this.noOfBags.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfBags.Location = new System.Drawing.Point(537, 133);
            this.noOfBags.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.noOfBags.Name = "noOfBags";
            this.noOfBags.Size = new System.Drawing.Size(158, 34);
            this.noOfBags.TabIndex = 31;
            // 
            // chkboxprohibited
            // 
            this.chkboxprohibited.AutoSize = true;
            this.chkboxprohibited.Location = new System.Drawing.Point(12, 353);
            this.chkboxprohibited.Name = "chkboxprohibited";
            this.chkboxprohibited.Size = new System.Drawing.Size(488, 30);
            this.chkboxprohibited.TabIndex = 30;
            this.chkboxprohibited.Text = "I confirm that i do NOT carry any of those items";
            this.chkboxprohibited.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ammarinho_s_Airlines.Properties.Resources.imgprohibited;
            this.pictureBox1.Location = new System.Drawing.Point(6, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(417, 34);
            this.label10.TabIndex = 28;
            this.label10.Text = "Do you carry any of those Items? ";
            // 
            // tabPayment
            // 
            this.tabPayment.BackColor = System.Drawing.Color.LightBlue;
            this.tabPayment.Controls.Add(this.btnViewTckt);
            this.tabPayment.Controls.Add(this.progressBar1);
            this.tabPayment.Controls.Add(this.btnbook);
            this.tabPayment.Controls.Add(this.lblMoney);
            this.tabPayment.Controls.Add(this.label16);
            this.tabPayment.Controls.Add(this.txtBoxCVV);
            this.tabPayment.Controls.Add(this.label15);
            this.tabPayment.Controls.Add(this.txtboxCardNo);
            this.tabPayment.Controls.Add(this.label14);
            this.tabPayment.Controls.Add(this.label13);
            this.tabPayment.Controls.Add(this.comBoxPayMethod);
            this.tabPayment.Location = new System.Drawing.Point(4, 35);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(841, 442);
            this.tabPayment.TabIndex = 3;
            this.tabPayment.Text = "Payment";
            // 
            // btnViewTckt
            // 
            this.btnViewTckt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTckt.Location = new System.Drawing.Point(12, 370);
            this.btnViewTckt.Name = "btnViewTckt";
            this.btnViewTckt.Size = new System.Drawing.Size(188, 51);
            this.btnViewTckt.TabIndex = 39;
            this.btnViewTckt.Text = "View Ticket";
            this.btnViewTckt.UseVisualStyleBackColor = true;
            this.btnViewTckt.Visible = false;
            this.btnViewTckt.Click += new System.EventHandler(this.btnViewTckt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(191, 195);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(407, 47);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnbook
            // 
            this.btnbook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(12, 195);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(140, 51);
            this.btnbook.TabIndex = 37;
            this.btnbook.Text = "Book Trip!";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click_1);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMoney.Font = new System.Drawing.Font("Bell MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMoney.Location = new System.Drawing.Point(541, 359);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(167, 57);
            this.lblMoney.TabIndex = 36;
            this.lblMoney.Text = "0 JOD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(451, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 49);
            this.label16.TabIndex = 35;
            this.label16.Text = "TOTAL :";
            // 
            // txtBoxCVV
            // 
            this.txtBoxCVV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCVV.Location = new System.Drawing.Point(716, 142);
            this.txtBoxCVV.MaxLength = 3;
            this.txtBoxCVV.Name = "txtBoxCVV";
            this.txtBoxCVV.PasswordChar = '*';
            this.txtBoxCVV.Size = new System.Drawing.Size(75, 27);
            this.txtBoxCVV.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(621, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 34);
            this.label15.TabIndex = 33;
            this.label15.Text = "CVV :";
            // 
            // txtboxCardNo
            // 
            this.txtboxCardNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCardNo.Location = new System.Drawing.Point(337, 142);
            this.txtboxCardNo.MaxLength = 19;
            this.txtboxCardNo.Name = "txtboxCardNo";
            this.txtboxCardNo.Size = new System.Drawing.Size(237, 27);
            this.txtboxCardNo.TabIndex = 32;
            this.txtboxCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCardNo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(325, 34);
            this.label14.TabIndex = 19;
            this.label14.Text = "Enter your card number  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Font = new System.Drawing.Font("Bodoni MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(371, 34);
            this.label13.TabIndex = 18;
            this.label13.Text = "Select your payment method :";
            // 
            // comBoxPayMethod
            // 
            this.comBoxPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPayMethod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comBoxPayMethod.FormattingEnabled = true;
            this.comBoxPayMethod.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "PAYPAL"});
            this.comBoxPayMethod.Location = new System.Drawing.Point(398, 83);
            this.comBoxPayMethod.Name = "comBoxPayMethod";
            this.comBoxPayMethod.Size = new System.Drawing.Size(191, 27);
            this.comBoxPayMethod.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ammarinho_s_Airlines.Properties.Resources.imgbook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 689);
            this.Controls.Add(this.tab);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.tab.ResumeLayout(false);
            this.tabTripInfo.ResumeLayout(false);
            this.tabTripInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfGuests)).EndInit();
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.tabBaggage.ResumeLayout(false);
            this.tabBaggage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noOfHandBags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfBags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabTripInfo;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxTo;
        public System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Button btnDoneTrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.NumericUpDown noOfGuests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtboxFName;
        private System.Windows.Forms.TextBox txtboxLName;
        private System.Windows.Forms.TextBox txtboxPNum;
        private System.Windows.Forms.TextBox txtboxNat;
        private System.Windows.Forms.Button btnDonePersonal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TabPage tabBaggage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown noOfBags;
        private System.Windows.Forms.CheckBox chkboxprohibited;
        private System.Windows.Forms.Button btnDoneBaggage;
        private System.Windows.Forms.NumericUpDown noOfHandBags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comBoxPayMethod;
        private System.Windows.Forms.TextBox txtBoxCVV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtboxCardNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnViewTckt;
    }
}