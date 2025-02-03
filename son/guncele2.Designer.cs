namespace son
{
    partial class guncele2
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
            this.tbusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLoginDataSet4 = new son.dbLoginDataSet4();
            this.tbusTableAdapter = new son.dbLoginDataSet4TableAdapters.tbusTableAdapter();
            this.tbuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet5 = new son.usersDataSet5();
            this.tbuseTableAdapter = new son.usersDataSet5TableAdapters.tbuseTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userGG = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userPhonNum = new System.Windows.Forms.TextBox();
            this.userEposta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.userDoorNo = new System.Windows.Forms.TextBox();
            this.userHomeNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.usersid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usEpostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usPhonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usGGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usHomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usDoorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRool = new System.Windows.Forms.ComboBox();
            this.usersDataSet11 = new son.usersDataSet11();
            this.tbuseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbuseTableAdapter1 = new son.usersDataSet11TableAdapters.tbuseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbusBindingSource
            // 
            this.tbusBindingSource.DataMember = "tbus";
            this.tbusBindingSource.DataSource = this.dbLoginDataSet4;
            // 
            // dbLoginDataSet4
            // 
            this.dbLoginDataSet4.DataSetName = "dbLoginDataSet4";
            this.dbLoginDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusTableAdapter
            // 
            this.tbusTableAdapter.ClearBeforeFill = true;
            // 
            // tbuseBindingSource
            // 
            this.tbuseBindingSource.DataMember = "tbuse";
            this.tbuseBindingSource.DataSource = this.usersDataSet5;
            // 
            // usersDataSet5
            // 
            this.usersDataSet5.DataSetName = "usersDataSet5";
            this.usersDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseTableAdapter
            // 
            this.tbuseTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::son.Properties.Resources.back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(0, -6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 28);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(372, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "KULLANICIYI GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userGG
            // 
            this.userGG.DataSource = this.tbuseBindingSource;
            this.userGG.DisplayMember = "usGG";
            this.userGG.FormattingEnabled = true;
            this.userGG.Location = new System.Drawing.Point(122, 325);
            this.userGG.Name = "userGG";
            this.userGG.Size = new System.Drawing.Size(212, 24);
            this.userGG.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-5, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "MEDENİ DURUMU :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "E-POSTA :";
            // 
            // userPhonNum
            // 
            this.userPhonNum.Location = new System.Drawing.Point(122, 296);
            this.userPhonNum.Name = "userPhonNum";
            this.userPhonNum.Size = new System.Drawing.Size(212, 22);
            this.userPhonNum.TabIndex = 24;
            // 
            // userEposta
            // 
            this.userEposta.Location = new System.Drawing.Point(122, 268);
            this.userEposta.Name = "userEposta";
            this.userEposta.Size = new System.Drawing.Size(212, 22);
            this.userEposta.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(70, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 47;
            this.label14.Text = "ROL :";
            // 
            // userDoorNo
            // 
            this.userDoorNo.Location = new System.Drawing.Point(122, 383);
            this.userDoorNo.Name = "userDoorNo";
            this.userDoorNo.Size = new System.Drawing.Size(212, 22);
            this.userDoorNo.TabIndex = 43;
            // 
            // userHomeNo
            // 
            this.userHomeNo.Location = new System.Drawing.Point(122, 355);
            this.userHomeNo.Name = "userHomeNo";
            this.userHomeNo.Size = new System.Drawing.Size(212, 22);
            this.userHomeNo.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(39, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "DAİRE NO :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(52, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "KAT NO :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(19, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 49;
            this.label15.Text = "KULLANICI İD :";
            // 
            // usersid
            // 
            this.usersid.Location = new System.Drawing.Point(122, 240);
            this.usersid.Name = "usersid";
            this.usersid.Size = new System.Drawing.Size(212, 22);
            this.usersid.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersidDataGridViewTextBoxColumn,
            this.usEpostaDataGridViewTextBoxColumn,
            this.usPhonDataGridViewTextBoxColumn,
            this.usGGDataGridViewTextBoxColumn,
            this.usHomNoDataGridViewTextBoxColumn,
            this.usDoorNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbuseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // usersidDataGridViewTextBoxColumn
            // 
            this.usersidDataGridViewTextBoxColumn.DataPropertyName = "users_id";
            this.usersidDataGridViewTextBoxColumn.HeaderText = "users_id";
            this.usersidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersidDataGridViewTextBoxColumn.Name = "usersidDataGridViewTextBoxColumn";
            this.usersidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usEpostaDataGridViewTextBoxColumn
            // 
            this.usEpostaDataGridViewTextBoxColumn.DataPropertyName = "usEposta";
            this.usEpostaDataGridViewTextBoxColumn.HeaderText = "usEposta";
            this.usEpostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usEpostaDataGridViewTextBoxColumn.Name = "usEpostaDataGridViewTextBoxColumn";
            // 
            // usPhonDataGridViewTextBoxColumn
            // 
            this.usPhonDataGridViewTextBoxColumn.DataPropertyName = "usPhon";
            this.usPhonDataGridViewTextBoxColumn.HeaderText = "usPhon";
            this.usPhonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usPhonDataGridViewTextBoxColumn.Name = "usPhonDataGridViewTextBoxColumn";
            // 
            // usGGDataGridViewTextBoxColumn
            // 
            this.usGGDataGridViewTextBoxColumn.DataPropertyName = "usGG";
            this.usGGDataGridViewTextBoxColumn.HeaderText = "usGG";
            this.usGGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usGGDataGridViewTextBoxColumn.Name = "usGGDataGridViewTextBoxColumn";
            // 
            // usHomNoDataGridViewTextBoxColumn
            // 
            this.usHomNoDataGridViewTextBoxColumn.DataPropertyName = "usHomNo";
            this.usHomNoDataGridViewTextBoxColumn.HeaderText = "usHomNo";
            this.usHomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usHomNoDataGridViewTextBoxColumn.Name = "usHomNoDataGridViewTextBoxColumn";
            // 
            // usDoorNoDataGridViewTextBoxColumn
            // 
            this.usDoorNoDataGridViewTextBoxColumn.DataPropertyName = "usDoorNo";
            this.usDoorNoDataGridViewTextBoxColumn.HeaderText = "usDoorNo";
            this.usDoorNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usDoorNoDataGridViewTextBoxColumn.Name = "usDoorNoDataGridViewTextBoxColumn";
            // 
            // userRool
            // 
            this.userRool.FormattingEnabled = true;
            this.userRool.Items.AddRange(new object[] {
            "Kullanıcı",
            "Admin"});
            this.userRool.Location = new System.Drawing.Point(122, 415);
            this.userRool.Name = "userRool";
            this.userRool.Size = new System.Drawing.Size(212, 24);
            this.userRool.TabIndex = 53;
            // 
            // usersDataSet11
            // 
            this.usersDataSet11.DataSetName = "usersDataSet11";
            this.usersDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseBindingSource1
            // 
            this.tbuseBindingSource1.DataMember = "tbuse";
            this.tbuseBindingSource1.DataSource = this.usersDataSet11;
            // 
            // tbuseTableAdapter1
            // 
            this.tbuseTableAdapter1.ClearBeforeFill = true;
            // 
            // guncele2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(636, 496);
            this.Controls.Add(this.userRool);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.usersid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.userDoorNo);
            this.Controls.Add(this.userHomeNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userGG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userPhonNum);
            this.Controls.Add(this.userEposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guncele2";
            this.Text = "guncele2";
            this.Load += new System.EventHandler(this.guncele2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private dbLoginDataSet4 dbLoginDataSet4;
        private System.Windows.Forms.BindingSource tbusBindingSource;
        private dbLoginDataSet4TableAdapters.tbusTableAdapter tbusTableAdapter;
        private usersDataSet5 usersDataSet5;
        private System.Windows.Forms.BindingSource tbuseBindingSource;
        private usersDataSet5TableAdapters.tbuseTableAdapter tbuseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox userGG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPhonNum;
        private System.Windows.Forms.TextBox userEposta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox userDoorNo;
        private System.Windows.Forms.TextBox userHomeNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox usersid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usEpostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usPhonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usGGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usHomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDoorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox userRool;
        private usersDataSet11 usersDataSet11;
        private System.Windows.Forms.BindingSource tbuseBindingSource1;
        private usersDataSet11TableAdapters.tbuseTableAdapter tbuseTableAdapter1;
    }
}