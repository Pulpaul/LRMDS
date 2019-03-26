namespace LRMDSp
{
    partial class AccountNw
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountNw));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txLn = new System.Windows.Forms.TextBox();
            this.txFn = new System.Windows.Forms.TextBox();
            this.txMi = new System.Windows.Forms.TextBox();
            this.txUn = new System.Windows.Forms.TextBox();
            this.txPn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbSq = new System.Windows.Forms.ComboBox();
            this.txAns = new System.Windows.Forms.TextBox();
            this.cbAt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txBd = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Account";
            // 
            // txLn
            // 
            this.txLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLn.ForeColor = System.Drawing.Color.Gray;
            this.txLn.Location = new System.Drawing.Point(320, 135);
            this.txLn.Multiline = true;
            this.txLn.Name = "txLn";
            this.txLn.Size = new System.Drawing.Size(161, 28);
            this.txLn.TabIndex = 2;
            this.txLn.Text = "Lastname";
            this.txLn.TextChanged += new System.EventHandler(this.txLn_TextChanged);
            this.txLn.Enter += new System.EventHandler(this.txLn_Enter);
            this.txLn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txLn_KeyPress);
            this.txLn.Leave += new System.EventHandler(this.txLn_Leave);
            // 
            // txFn
            // 
            this.txFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFn.ForeColor = System.Drawing.Color.Gray;
            this.txFn.Location = new System.Drawing.Point(499, 135);
            this.txFn.Multiline = true;
            this.txFn.Name = "txFn";
            this.txFn.Size = new System.Drawing.Size(161, 28);
            this.txFn.TabIndex = 3;
            this.txFn.Text = "Firstname";
            this.txFn.Enter += new System.EventHandler(this.txFn_Enter);
            this.txFn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFn_KeyPress);
            this.txFn.Leave += new System.EventHandler(this.txFn_Leave);
            // 
            // txMi
            // 
            this.txMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMi.ForeColor = System.Drawing.Color.Gray;
            this.txMi.Location = new System.Drawing.Point(677, 135);
            this.txMi.MaxLength = 3;
            this.txMi.Multiline = true;
            this.txMi.Name = "txMi";
            this.txMi.Size = new System.Drawing.Size(48, 28);
            this.txMi.TabIndex = 4;
            this.txMi.Text = "M.I";
            this.txMi.Enter += new System.EventHandler(this.txMi_Enter);
            this.txMi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMi_KeyPress);
            this.txMi.Leave += new System.EventHandler(this.txMi_Leave);
            // 
            // txUn
            // 
            this.txUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUn.ForeColor = System.Drawing.Color.Gray;
            this.txUn.Location = new System.Drawing.Point(320, 191);
            this.txUn.Multiline = true;
            this.txUn.Name = "txUn";
            this.txUn.Size = new System.Drawing.Size(161, 28);
            this.txUn.TabIndex = 5;
            this.txUn.Text = "Enter username";
            this.txUn.Enter += new System.EventHandler(this.txUn_Enter);
            this.txUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUn_KeyPress);
            this.txUn.Leave += new System.EventHandler(this.txUn_Leave);
            // 
            // txPn
            // 
            this.txPn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPn.ForeColor = System.Drawing.Color.Gray;
            this.txPn.Location = new System.Drawing.Point(320, 246);
            this.txPn.Multiline = true;
            this.txPn.Name = "txPn";
            this.txPn.Size = new System.Drawing.Size(161, 28);
            this.txPn.TabIndex = 6;
            this.txPn.Text = "Enter password";
            this.txPn.Enter += new System.EventHandler(this.txPn_Enter);
            this.txPn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPn_KeyPress);
            this.txPn.Leave += new System.EventHandler(this.txPn_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBox1.Location = new System.Drawing.Point(320, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.ForeColor = System.Drawing.Color.Gray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox2.Location = new System.Drawing.Point(422, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Enter += new System.EventHandler(this.comboBox2_Enter);
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.ForeColor = System.Drawing.Color.Gray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971"});
            this.comboBox3.Location = new System.Drawing.Point(499, 304);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(87, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.Enter += new System.EventHandler(this.comboBox3_Enter);
            this.comboBox3.Leave += new System.EventHandler(this.comboBox3_Leave);
            // 
            // cbSq
            // 
            this.cbSq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSq.ForeColor = System.Drawing.Color.Gray;
            this.cbSq.FormattingEnabled = true;
            this.cbSq.Items.AddRange(new object[] {
            "What is your pet name?",
            "What is your favorite food?",
            "What is your favorite subject?"});
            this.cbSq.Location = new System.Drawing.Point(320, 356);
            this.cbSq.Name = "cbSq";
            this.cbSq.Size = new System.Drawing.Size(161, 21);
            this.cbSq.TabIndex = 10;
            this.cbSq.SelectedIndexChanged += new System.EventHandler(this.cbSq_SelectedIndexChanged);
            this.cbSq.Enter += new System.EventHandler(this.cbSq_Enter);
            this.cbSq.Leave += new System.EventHandler(this.cbSq_Leave);
            // 
            // txAns
            // 
            this.txAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAns.ForeColor = System.Drawing.Color.Gray;
            this.txAns.Location = new System.Drawing.Point(320, 403);
            this.txAns.Multiline = true;
            this.txAns.Name = "txAns";
            this.txAns.Size = new System.Drawing.Size(161, 28);
            this.txAns.TabIndex = 11;
            this.txAns.Text = "Answer";
            this.txAns.Enter += new System.EventHandler(this.txAns_Enter);
            this.txAns.Leave += new System.EventHandler(this.txAns_Leave);
            // 
            // cbAt
            // 
            this.cbAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAt.ForeColor = System.Drawing.Color.Gray;
            this.cbAt.FormattingEnabled = true;
            this.cbAt.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbAt.Location = new System.Drawing.Point(320, 455);
            this.cbAt.Name = "cbAt";
            this.cbAt.Size = new System.Drawing.Size(161, 21);
            this.cbAt.TabIndex = 12;
            this.cbAt.SelectedIndexChanged += new System.EventHandler(this.cbAt_SelectedIndexChanged);
            this.cbAt.Enter += new System.EventHandler(this.cbAt_Enter);
            this.cbAt.Leave += new System.EventHandler(this.cbAt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(316, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(316, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(316, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(316, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(316, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Secret Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(316, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(316, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Account Type";
            // 
            // txBd
            // 
            this.txBd.AutoSize = true;
            this.txBd.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBd.ForeColor = System.Drawing.Color.Black;
            this.txBd.Location = new System.Drawing.Point(624, 304);
            this.txBd.Name = "txBd";
            this.txBd.Size = new System.Drawing.Size(70, 21);
            this.txBd.TabIndex = 21;
            this.txBd.Text = "Fullname";
            this.txBd.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Register";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(604, 488);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(121, 52);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(324, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(426, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(503, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(324, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Select secret question";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(324, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Select account type";
            // 
            // AccountNw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txBd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAt);
            this.Controls.Add(this.txAns);
            this.Controls.Add(this.cbSq);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txPn);
            this.Controls.Add(this.txUn);
            this.Controls.Add(this.txMi);
            this.Controls.Add(this.txFn);
            this.Controls.Add(this.txLn);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AccountNw";
            this.Size = new System.Drawing.Size(1051, 556);
            this.Load += new System.EventHandler(this.AccountNw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TextBox txLn;
        private System.Windows.Forms.TextBox txFn;
        private System.Windows.Forms.TextBox txMi;
        private System.Windows.Forms.TextBox txUn;
        private System.Windows.Forms.TextBox txPn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbSq;
        private System.Windows.Forms.TextBox txAns;
        private System.Windows.Forms.ComboBox cbAt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txBd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
