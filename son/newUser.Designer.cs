namespace son
{
    partial class newUser
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
            this.userName = new System.Windows.Forms.TextBox();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.userEposta = new System.Windows.Forms.TextBox();
            this.userPhonNum = new System.Windows.Forms.TextBox();
            this.userPwd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userGG = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.userBload = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.userHomeNo = new System.Windows.Forms.TextBox();
            this.userDoorNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.userSex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.userRool = new System.Windows.Forms.ComboBox();
            this.dbLoginDataSet6 = new son.dbLoginDataSet6();
            this.tbusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbusTableAdapter = new son.dbLoginDataSet6TableAdapters.tbusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(177, 28);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(212, 22);
            this.userName.TabIndex = 3;
            // 
            // userSurname
            // 
            this.userSurname.Location = new System.Drawing.Point(177, 57);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(212, 22);
            this.userSurname.TabIndex = 4;
            // 
            // userEposta
            // 
            this.userEposta.Location = new System.Drawing.Point(177, 85);
            this.userEposta.Name = "userEposta";
            this.userEposta.Size = new System.Drawing.Size(212, 22);
            this.userEposta.TabIndex = 5;
            // 
            // userPhonNum
            // 
            this.userPhonNum.Location = new System.Drawing.Point(177, 141);
            this.userPhonNum.Name = "userPhonNum";
            this.userPhonNum.Size = new System.Drawing.Size(212, 22);
            this.userPhonNum.TabIndex = 6;
            // 
            // userPwd1
            // 
            this.userPwd1.Location = new System.Drawing.Point(177, 197);
            this.userPwd1.Name = "userPwd1";
            this.userPwd1.Size = new System.Drawing.Size(212, 22);
            this.userPwd1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "İSİM :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "SOY İSİM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-POSTA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "DOĞUM TARİHİ :";
            // 
            // userDateTime
            // 
            this.userDateTime.Location = new System.Drawing.Point(177, 113);
            this.userDateTime.Name = "userDateTime";
            this.userDateTime.Size = new System.Drawing.Size(212, 22);
            this.userDateTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "TELEFON :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "MEDENİ DURUMU :";
            // 
            // userGG
            // 
            this.userGG.FormattingEnabled = true;
            this.userGG.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR"});
            this.userGG.Location = new System.Drawing.Point(177, 167);
            this.userGG.Name = "userGG";
            this.userGG.Size = new System.Drawing.Size(212, 24);
            this.userGG.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(77, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "ŞİFRE :";
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(406, 318);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(254, 67);
            this.kaydet.TabIndex = 21;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.button3_Click);
            // 
            // userBload
            // 
            this.userBload.Location = new System.Drawing.Point(177, 225);
            this.userBload.Name = "userBload";
            this.userBload.Size = new System.Drawing.Size(212, 22);
            this.userBload.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(44, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "KAN GRUBU :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(68, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "KAT NO :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(55, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "DAİRE NO :";
            // 
            // userHomeNo
            // 
            this.userHomeNo.Location = new System.Drawing.Point(177, 253);
            this.userHomeNo.Name = "userHomeNo";
            this.userHomeNo.Size = new System.Drawing.Size(212, 22);
            this.userHomeNo.TabIndex = 26;
            // 
            // userDoorNo
            // 
            this.userDoorNo.Location = new System.Drawing.Point(177, 284);
            this.userDoorNo.Name = "userDoorNo";
            this.userDoorNo.Size = new System.Drawing.Size(212, 22);
            this.userDoorNo.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(57, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "CİNSİYET :";
            // 
            // userSex
            // 
            this.userSex.Location = new System.Drawing.Point(177, 312);
            this.userSex.Name = "userSex";
            this.userSex.Size = new System.Drawing.Size(212, 22);
            this.userSex.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::son.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(86, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "ROL :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(636, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 34;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // userRool
            // 
            this.userRool.FormattingEnabled = true;
            this.userRool.Items.AddRange(new object[] {
            "Kullanıcı",
            "Admin"});
            this.userRool.Location = new System.Drawing.Point(177, 343);
            this.userRool.Name = "userRool";
            this.userRool.Size = new System.Drawing.Size(212, 24);
            this.userRool.TabIndex = 35;
            // 
            // dbLoginDataSet6
            // 
            this.dbLoginDataSet6.DataSetName = "dbLoginDataSet6";
            this.dbLoginDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusBindingSource
            // 
            this.tbusBindingSource.DataMember = "tbus";
            this.tbusBindingSource.DataSource = this.dbLoginDataSet6;
            // 
            // tbusTableAdapter
            // 
            this.tbusTableAdapter.ClearBeforeFill = true;
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.userRool);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.userSex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userDoorNo);
            this.Controls.Add(this.userHomeNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userBload);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userGG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPwd1);
            this.Controls.Add(this.userPhonNum);
            this.Controls.Add(this.userEposta);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newUser";
            this.Text = "newUser";
            this.Load += new System.EventHandler(this.newUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.TextBox userEposta;
        private System.Windows.Forms.TextBox userPhonNum;
        private System.Windows.Forms.TextBox userPwd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker userDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userGG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox userBload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userHomeNo;
        private System.Windows.Forms.TextBox userDoorNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox userSex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox userRool;
        private dbLoginDataSet6 dbLoginDataSet6;
        private System.Windows.Forms.BindingSource tbusBindingSource;
        private dbLoginDataSet6TableAdapters.tbusTableAdapter tbusTableAdapter;
    }
}