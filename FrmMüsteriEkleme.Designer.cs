namespace Dilpek_Otel
{
    partial class FrmMüsteriEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüsteriEkleme));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOda108 = new System.Windows.Forms.Button();
            this.BtnOda109 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda104 = new System.Windows.Forms.Button();
            this.BtnOda105 = new System.Windows.Forms.Button();
            this.BtnOda106 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.BtnOda107 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(216, -82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "DİLPEK OTEL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtKimlikNo);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 394);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "0";
            this.label12.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(106, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(52, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Cinsiyet:";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(106, 299);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 24);
            this.DtpCikisTarihi.TabIndex = 40;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(106, 269);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 24);
            this.DtpGirisTarihi.TabIndex = 39;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUcret.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(106, 239);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(200, 24);
            this.TxtUcret.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(63, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ücret:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnKaydet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(136, 344);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(91, 40);
            this.BtnKaydet.TabIndex = 34;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MskTxtTelefon.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(106, 120);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(200, 24);
            this.MskTxtTelefon.TabIndex = 31;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSoyad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(106, 60);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(200, 24);
            this.TxtSoyad.TabIndex = 30;
            this.TxtSoyad.TextChanged += new System.EventHandler(this.TxtSoyad_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMail.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(106, 152);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(200, 24);
            this.TxtMail.TabIndex = 29;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtKimlikNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKimlikNo.Location = new System.Drawing.Point(106, 179);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(200, 24);
            this.TxtKimlikNo.TabIndex = 28;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtOdaNo.Enabled = false;
            this.TxtOdaNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNo.Location = new System.Drawing.Point(106, 209);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(200, 24);
            this.TxtOdaNo.TabIndex = 27;
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtAd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(106, 26);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(200, 24);
            this.TxtAd.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Daire No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(54, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "T.C.Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(304, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 27);
            this.label14.TabIndex = 21;
            this.label14.Text = "DİLPEK PANSİYON";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.Red;
            this.BtnDoluOda.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoluOda.Location = new System.Drawing.Point(105, 248);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(77, 45);
            this.BtnDoluOda.TabIndex = 26;
            this.BtnDoluOda.Text = "Dolu";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.Gold;
            this.BtnBosOda.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBosOda.Location = new System.Drawing.Point(198, 248);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(76, 45);
            this.BtnBosOda.TabIndex = 25;
            this.BtnBosOda.Text = "Boş";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.BtnOda108);
            this.groupBox2.Controls.Add(this.BtnDoluOda);
            this.groupBox2.Controls.Add(this.BtnBosOda);
            this.groupBox2.Controls.Add(this.BtnOda109);
            this.groupBox2.Controls.Add(this.BtnOda102);
            this.groupBox2.Controls.Add(this.BtnOda103);
            this.groupBox2.Controls.Add(this.BtnOda104);
            this.groupBox2.Controls.Add(this.BtnOda105);
            this.groupBox2.Controls.Add(this.BtnOda106);
            this.groupBox2.Controls.Add(this.BtnOda101);
            this.groupBox2.Controls.Add(this.BtnOda107);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(376, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 314);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // BtnOda108
            // 
            this.BtnOda108.BackColor = System.Drawing.Color.Gold;
            this.BtnOda108.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda108.Location = new System.Drawing.Point(148, 169);
            this.BtnOda108.Name = "BtnOda108";
            this.BtnOda108.Size = new System.Drawing.Size(77, 45);
            this.BtnOda108.TabIndex = 7;
            this.BtnOda108.Text = "108";
            this.BtnOda108.UseVisualStyleBackColor = false;
            this.BtnOda108.Click += new System.EventHandler(this.BtnOda108_Click);
            // 
            // BtnOda109
            // 
            this.BtnOda109.BackColor = System.Drawing.Color.Gold;
            this.BtnOda109.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda109.Location = new System.Drawing.Point(241, 169);
            this.BtnOda109.Name = "BtnOda109";
            this.BtnOda109.Size = new System.Drawing.Size(77, 45);
            this.BtnOda109.TabIndex = 6;
            this.BtnOda109.Text = "109";
            this.BtnOda109.UseVisualStyleBackColor = false;
            this.BtnOda109.Click += new System.EventHandler(this.BtnOda109_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.Gold;
            this.BtnOda102.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda102.Location = new System.Drawing.Point(148, 46);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(77, 46);
            this.BtnOda102.TabIndex = 5;
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda102_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.Gold;
            this.BtnOda103.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda103.Location = new System.Drawing.Point(241, 46);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(77, 46);
            this.BtnOda103.TabIndex = 4;
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda103_Click);
            // 
            // BtnOda104
            // 
            this.BtnOda104.BackColor = System.Drawing.Color.Gold;
            this.BtnOda104.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda104.Location = new System.Drawing.Point(50, 108);
            this.BtnOda104.Name = "BtnOda104";
            this.BtnOda104.Size = new System.Drawing.Size(82, 46);
            this.BtnOda104.TabIndex = 3;
            this.BtnOda104.Text = "104";
            this.BtnOda104.UseVisualStyleBackColor = false;
            this.BtnOda104.Click += new System.EventHandler(this.BtnOda104_Click);
            // 
            // BtnOda105
            // 
            this.BtnOda105.BackColor = System.Drawing.Color.Gold;
            this.BtnOda105.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda105.Location = new System.Drawing.Point(148, 108);
            this.BtnOda105.Name = "BtnOda105";
            this.BtnOda105.Size = new System.Drawing.Size(77, 46);
            this.BtnOda105.TabIndex = 2;
            this.BtnOda105.Text = "105";
            this.BtnOda105.UseVisualStyleBackColor = false;
            this.BtnOda105.Click += new System.EventHandler(this.BtnOda105_Click);
            // 
            // BtnOda106
            // 
            this.BtnOda106.BackColor = System.Drawing.Color.Gold;
            this.BtnOda106.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda106.Location = new System.Drawing.Point(241, 108);
            this.BtnOda106.Name = "BtnOda106";
            this.BtnOda106.Size = new System.Drawing.Size(77, 46);
            this.BtnOda106.TabIndex = 1;
            this.BtnOda106.Text = "106";
            this.BtnOda106.UseVisualStyleBackColor = false;
            this.BtnOda106.Click += new System.EventHandler(this.BtnOda106_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.Gold;
            this.BtnOda101.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda101.Location = new System.Drawing.Point(50, 46);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(82, 46);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // BtnOda107
            // 
            this.BtnOda107.BackColor = System.Drawing.Color.Gold;
            this.BtnOda107.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOda107.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOda107.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOda107.Location = new System.Drawing.Point(50, 169);
            this.BtnOda107.Name = "BtnOda107";
            this.BtnOda107.Size = new System.Drawing.Size(82, 45);
            this.BtnOda107.TabIndex = 8;
            this.BtnOda107.Text = "107";
            this.BtnOda107.UseVisualStyleBackColor = false;
            this.BtnOda107.Click += new System.EventHandler(this.BtnOda107_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(436, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ana Forma Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMüsteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Name = "FrmMüsteriEkleme";
            this.Text = "Yeni Müşteri Ekleme";
            this.Load += new System.EventHandler(this.FrmMüsteriEkleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOda108;
        private System.Windows.Forms.Button BtnOda109;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda104;
        private System.Windows.Forms.Button BtnOda105;
        private System.Windows.Forms.Button BtnOda106;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.Button BtnOda107;
        private System.Windows.Forms.Button button1;

    }
}