﻿namespace son
{
    partial class ADMİN
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLoginDataSet2 = new son.dbLoginDataSet2();
            this.tbusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLoginDataSet1 = new son.dbLoginDataSet1();
            this.tbusersTableAdapter = new son.dbLoginDataSet1TableAdapters.tbusersTableAdapter();
            this.tbusTableAdapter = new son.dbLoginDataSet2TableAdapters.tbusTableAdapter();
            this.tbuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet4 = new son.usersDataSet4();
            this.tbuseTableAdapter = new son.usersDataSet4TableAdapters.tbuseTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(-1, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "KULLANICI  \r\nEKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(-2, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "KULLANICI\r\n SİL\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(126, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "KULLANICI GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbusBindingSource
            // 
            this.tbusBindingSource.DataMember = "tbus";
            this.tbusBindingSource.DataSource = this.dbLoginDataSet2;
            // 
            // dbLoginDataSet2
            // 
            this.dbLoginDataSet2.DataSetName = "dbLoginDataSet2";
            this.dbLoginDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusersBindingSource
            // 
            this.tbusersBindingSource.DataMember = "tbusers";
            this.tbusersBindingSource.DataSource = this.dbLoginDataSet1;
            // 
            // dbLoginDataSet1
            // 
            this.dbLoginDataSet1.DataSetName = "dbLoginDataSet1";
            this.dbLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusersTableAdapter
            // 
            this.tbusersTableAdapter.ClearBeforeFill = true;
            // 
            // tbusTableAdapter
            // 
            this.tbusTableAdapter.ClearBeforeFill = true;
            // 
            // tbuseBindingSource
            // 
            this.tbuseBindingSource.DataMember = "tbuse";
            this.tbuseBindingSource.DataSource = this.usersDataSet4;
            // 
            // usersDataSet4
            // 
            this.usersDataSet4.DataSetName = "usersDataSet4";
            this.usersDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseTableAdapter
            // 
            this.tbuseTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(126, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 81);
            this.button4.TabIndex = 7;
            this.button4.Text = "KULLANICI MESAJLARI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(0, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 75);
            this.button5.TabIndex = 8;
            this.button5.Text = "FATURA\r\n EKLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(231, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 26);
            this.button7.TabIndex = 10;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button8.BackgroundImage = global::son.Properties.Resources.log_out1;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 26);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::son.Properties.Resources.businessman;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ADMİN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(258, 364);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMİN";
            this.Text = "ADMİN";
            this.Load += new System.EventHandler(this.ADMİN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private dbLoginDataSet1 dbLoginDataSet1;
        private System.Windows.Forms.BindingSource tbusersBindingSource;
        private dbLoginDataSet1TableAdapters.tbusersTableAdapter tbusersTableAdapter;
        private dbLoginDataSet2 dbLoginDataSet2;
        private System.Windows.Forms.BindingSource tbusBindingSource;
        private dbLoginDataSet2TableAdapters.tbusTableAdapter tbusTableAdapter;
        private System.Windows.Forms.Button button3;
        private usersDataSet4 usersDataSet4;
        private System.Windows.Forms.BindingSource tbuseBindingSource;
        private usersDataSet4TableAdapters.tbuseTableAdapter tbuseTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}