namespace son
{
    partial class refkey
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
            this.tbuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet9 = new son.usersDataSet9();
            this.tbuseTableAdapter = new son.usersDataSet9TableAdapters.tbuseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUserSex = new System.Windows.Forms.Label();
            this.labelUserDoorNo = new System.Windows.Forms.Label();
            this.labelUserHomeNo = new System.Windows.Forms.Label();
            this.labelUserGG = new System.Windows.Forms.Label();
            this.labelUserPhonNum = new System.Windows.Forms.Label();
            this.labelUserEposta = new System.Windows.Forms.Label();
            this.labelUserSurname = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // tbuseBindingSource
            // 
            this.tbuseBindingSource.DataMember = "tbuse";
            this.tbuseBindingSource.DataSource = this.usersDataSet9;
            // 
            // usersDataSet9
            // 
            this.usersDataSet9.DataSetName = "usersDataSet9";
            this.usersDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseTableAdapter
            // 
            this.tbuseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::son.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(-2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUserSex
            // 
            this.labelUserSex.AutoSize = true;
            this.labelUserSex.BackColor = System.Drawing.Color.Transparent;
            this.labelUserSex.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSex.Location = new System.Drawing.Point(288, 271);
            this.labelUserSex.Name = "labelUserSex";
            this.labelUserSex.Size = new System.Drawing.Size(71, 16);
            this.labelUserSex.TabIndex = 56;
            this.labelUserSex.Text = "CİNSİYET :";
            // 
            // labelUserDoorNo
            // 
            this.labelUserDoorNo.AutoSize = true;
            this.labelUserDoorNo.BackColor = System.Drawing.Color.Transparent;
            this.labelUserDoorNo.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserDoorNo.Location = new System.Drawing.Point(287, 241);
            this.labelUserDoorNo.Name = "labelUserDoorNo";
            this.labelUserDoorNo.Size = new System.Drawing.Size(76, 16);
            this.labelUserDoorNo.TabIndex = 53;
            this.labelUserDoorNo.Text = "DAİRE NO :";
            // 
            // labelUserHomeNo
            // 
            this.labelUserHomeNo.AutoSize = true;
            this.labelUserHomeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelUserHomeNo.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserHomeNo.Location = new System.Drawing.Point(293, 208);
            this.labelUserHomeNo.Name = "labelUserHomeNo";
            this.labelUserHomeNo.Size = new System.Drawing.Size(64, 16);
            this.labelUserHomeNo.TabIndex = 52;
            this.labelUserHomeNo.Text = "KAT NO :";
            // 
            // labelUserGG
            // 
            this.labelUserGG.AutoSize = true;
            this.labelUserGG.BackColor = System.Drawing.Color.Transparent;
            this.labelUserGG.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGG.Location = new System.Drawing.Point(265, 176);
            this.labelUserGG.Name = "labelUserGG";
            this.labelUserGG.Size = new System.Drawing.Size(125, 16);
            this.labelUserGG.TabIndex = 47;
            this.labelUserGG.Text = "MEDENİ DURUMU :";
            this.labelUserGG.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelUserPhonNum
            // 
            this.labelUserPhonNum.AutoSize = true;
            this.labelUserPhonNum.BackColor = System.Drawing.Color.Transparent;
            this.labelUserPhonNum.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPhonNum.Location = new System.Drawing.Point(288, 150);
            this.labelUserPhonNum.Name = "labelUserPhonNum";
            this.labelUserPhonNum.Size = new System.Drawing.Size(73, 16);
            this.labelUserPhonNum.TabIndex = 46;
            this.labelUserPhonNum.Text = "TELEFON :";
            // 
            // labelUserEposta
            // 
            this.labelUserEposta.AutoSize = true;
            this.labelUserEposta.BackColor = System.Drawing.Color.Transparent;
            this.labelUserEposta.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEposta.Location = new System.Drawing.Point(291, 121);
            this.labelUserEposta.Name = "labelUserEposta";
            this.labelUserEposta.Size = new System.Drawing.Size(70, 16);
            this.labelUserEposta.TabIndex = 43;
            this.labelUserEposta.Text = "E-POSTA :";
            // 
            // labelUserSurname
            // 
            this.labelUserSurname.AutoSize = true;
            this.labelUserSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelUserSurname.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSurname.Location = new System.Drawing.Point(289, 93);
            this.labelUserSurname.Name = "labelUserSurname";
            this.labelUserSurname.Size = new System.Drawing.Size(70, 16);
            this.labelUserSurname.TabIndex = 42;
            this.labelUserSurname.Text = "SOY İSİM :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(301, 65);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(40, 16);
            this.labelUserName.TabIndex = 41;
            this.labelUserName.Text = "İSİM :";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(697, 414);
            this.Controls.Add(this.labelUserSex);
            this.Controls.Add(this.labelUserDoorNo);
            this.Controls.Add(this.labelUserHomeNo);
            this.Controls.Add(this.labelUserGG);
            this.Controls.Add(this.labelUserPhonNum);
            this.Controls.Add(this.labelUserEposta);
            this.Controls.Add(this.labelUserSurname);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "refkey";
            this.Text = "refkey";
            this.Load += new System.EventHandler(this.refkey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private usersDataSet9 usersDataSet9;
        private System.Windows.Forms.BindingSource tbuseBindingSource;
        private usersDataSet9TableAdapters.tbuseTableAdapter tbuseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUserSex;
        private System.Windows.Forms.Label labelUserDoorNo;
        private System.Windows.Forms.Label labelUserHomeNo;
        private System.Windows.Forms.Label labelUserGG;
        private System.Windows.Forms.Label labelUserPhonNum;
        private System.Windows.Forms.Label labelUserEposta;
        private System.Windows.Forms.Label labelUserSurname;
        private System.Windows.Forms.Label labelUserName;
    }
}