namespace son
{
    partial class faturacs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usEpostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usPhonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usDoorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet7 = new son.usersDataSet7();
            this.userid = new System.Windows.Forms.TextBox();
            this.faturafiyat = new System.Windows.Forms.TextBox();
            this.faturaN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbuseTableAdapter = new son.usersDataSet7TableAdapters.tbuseTableAdapter();
            this.usersDataSet12 = new son.usersDataSet12();
            this.tbuseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbuseTableAdapter1 = new son.usersDataSet12TableAdapters.tbuseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::son.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersidDataGridViewTextBoxColumn,
            this.usNameDataGridViewTextBoxColumn,
            this.usSurnameDataGridViewTextBoxColumn,
            this.usEpostaDataGridViewTextBoxColumn,
            this.usPhonDataGridViewTextBoxColumn,
            this.usDoorNoDataGridViewTextBoxColumn,
            this.roolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbuseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 152);
            this.dataGridView1.TabIndex = 2;
            // 
            // usersidDataGridViewTextBoxColumn
            // 
            this.usersidDataGridViewTextBoxColumn.DataPropertyName = "users_id";
            this.usersidDataGridViewTextBoxColumn.HeaderText = "users_id";
            this.usersidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersidDataGridViewTextBoxColumn.Name = "usersidDataGridViewTextBoxColumn";
            this.usersidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usNameDataGridViewTextBoxColumn
            // 
            this.usNameDataGridViewTextBoxColumn.DataPropertyName = "usName";
            this.usNameDataGridViewTextBoxColumn.HeaderText = "usName";
            this.usNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usNameDataGridViewTextBoxColumn.Name = "usNameDataGridViewTextBoxColumn";
            // 
            // usSurnameDataGridViewTextBoxColumn
            // 
            this.usSurnameDataGridViewTextBoxColumn.DataPropertyName = "usSurname";
            this.usSurnameDataGridViewTextBoxColumn.HeaderText = "usSurname";
            this.usSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usSurnameDataGridViewTextBoxColumn.Name = "usSurnameDataGridViewTextBoxColumn";
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
            // usDoorNoDataGridViewTextBoxColumn
            // 
            this.usDoorNoDataGridViewTextBoxColumn.DataPropertyName = "usDoorNo";
            this.usDoorNoDataGridViewTextBoxColumn.HeaderText = "usDoorNo";
            this.usDoorNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usDoorNoDataGridViewTextBoxColumn.Name = "usDoorNoDataGridViewTextBoxColumn";
            // 
            // roolDataGridViewTextBoxColumn
            // 
            this.roolDataGridViewTextBoxColumn.DataPropertyName = "rool";
            this.roolDataGridViewTextBoxColumn.HeaderText = "rool";
            this.roolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roolDataGridViewTextBoxColumn.Name = "roolDataGridViewTextBoxColumn";
            // 
            // tbuseBindingSource
            // 
            this.tbuseBindingSource.DataMember = "tbuse";
            this.tbuseBindingSource.DataSource = this.usersDataSet7;
            // 
            // usersDataSet7
            // 
            this.usersDataSet7.DataSetName = "usersDataSet7";
            this.usersDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(130, 290);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(277, 22);
            this.userid.TabIndex = 3;
            // 
            // faturafiyat
            // 
            this.faturafiyat.Location = new System.Drawing.Point(130, 318);
            this.faturafiyat.Name = "faturafiyat";
            this.faturafiyat.Size = new System.Drawing.Size(277, 22);
            this.faturafiyat.TabIndex = 4;
            // 
            // faturaN
            // 
            this.faturaN.FormattingEnabled = true;
            this.faturaN.Items.AddRange(new object[] {
            "ELEKTİRİK",
            "DOĞALGAZ",
            "SU",
            "AİDİAT"});
            this.faturaN.Location = new System.Drawing.Point(130, 346);
            this.faturaN.Name = "faturaN";
            this.faturaN.Size = new System.Drawing.Size(277, 24);
            this.faturaN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "KULLANICI NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "FATURA FİYATI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "FATURA TÜRÜ :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(430, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "FATURA EKLE ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbuseTableAdapter
            // 
            this.tbuseTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet12
            // 
            this.usersDataSet12.DataSetName = "usersDataSet12";
            this.usersDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseBindingSource1
            // 
            this.tbuseBindingSource1.DataMember = "tbuse";
            this.tbuseBindingSource1.DataSource = this.usersDataSet12;
            // 
            // tbuseTableAdapter1
            // 
            this.tbuseTableAdapter1.ClearBeforeFill = true;
            // 
            // faturacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(806, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faturaN);
            this.Controls.Add(this.faturafiyat);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faturacs";
            this.Text = "faturacs";
            this.Load += new System.EventHandler(this.faturacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox faturafiyat;
        private System.Windows.Forms.ComboBox faturaN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private usersDataSet7 usersDataSet7;
        private System.Windows.Forms.BindingSource tbuseBindingSource;
        private usersDataSet7TableAdapters.tbuseTableAdapter tbuseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usEpostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usPhonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDoorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roolDataGridViewTextBoxColumn;
        private usersDataSet12 usersDataSet12;
        private System.Windows.Forms.BindingSource tbuseBindingSource1;
        private usersDataSet12TableAdapters.tbuseTableAdapter tbuseTableAdapter1;
    }
}