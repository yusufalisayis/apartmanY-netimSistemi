namespace son
{
    partial class userfatura
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
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet8 = new son.usersDataSet8();
            this.tbfaturaTableAdapter = new son.usersDataSet8TableAdapters.tbfaturaTableAdapter();
            this.okFatura = new System.Windows.Forms.TextBox();
            this.okUserfatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::son.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaidDataGridViewTextBoxColumn,
            this.faturaIsimDataGridViewTextBoxColumn,
            this.faturaFiyatDataGridViewTextBoxColumn,
            this.usersidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbfaturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // faturaidDataGridViewTextBoxColumn
            // 
            this.faturaidDataGridViewTextBoxColumn.DataPropertyName = "fatura_id";
            this.faturaidDataGridViewTextBoxColumn.HeaderText = "fatura_id";
            this.faturaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaidDataGridViewTextBoxColumn.Name = "faturaidDataGridViewTextBoxColumn";
            this.faturaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaIsimDataGridViewTextBoxColumn
            // 
            this.faturaIsimDataGridViewTextBoxColumn.DataPropertyName = "faturaIsim";
            this.faturaIsimDataGridViewTextBoxColumn.HeaderText = "faturaIsim";
            this.faturaIsimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaIsimDataGridViewTextBoxColumn.Name = "faturaIsimDataGridViewTextBoxColumn";
            this.faturaIsimDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaFiyatDataGridViewTextBoxColumn
            // 
            this.faturaFiyatDataGridViewTextBoxColumn.DataPropertyName = "faturaFiyat";
            this.faturaFiyatDataGridViewTextBoxColumn.HeaderText = "faturaFiyat";
            this.faturaFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaFiyatDataGridViewTextBoxColumn.Name = "faturaFiyatDataGridViewTextBoxColumn";
            this.faturaFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersidDataGridViewTextBoxColumn
            // 
            this.usersidDataGridViewTextBoxColumn.DataPropertyName = "users_id";
            this.usersidDataGridViewTextBoxColumn.HeaderText = "users_id";
            this.usersidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersidDataGridViewTextBoxColumn.Name = "usersidDataGridViewTextBoxColumn";
            this.usersidDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbfaturaBindingSource
            // 
            this.tbfaturaBindingSource.DataMember = "tbfatura";
            this.tbfaturaBindingSource.DataSource = this.usersDataSet8;
            // 
            // usersDataSet8
            // 
            this.usersDataSet8.DataSetName = "usersDataSet8";
            this.usersDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfaturaTableAdapter
            // 
            this.tbfaturaTableAdapter.ClearBeforeFill = true;
            // 
            // okFatura
            // 
            this.okFatura.Location = new System.Drawing.Point(101, 278);
            this.okFatura.Name = "okFatura";
            this.okFatura.Size = new System.Drawing.Size(220, 22);
            this.okFatura.TabIndex = 3;
            // 
            // okUserfatura
            // 
            this.okUserfatura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.okUserfatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okUserfatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okUserfatura.Location = new System.Drawing.Point(352, 278);
            this.okUserfatura.Name = "okUserfatura";
            this.okUserfatura.Size = new System.Drawing.Size(245, 46);
            this.okUserfatura.TabIndex = 4;
            this.okUserfatura.Text = "FATURAYI SİL";
            this.okUserfatura.UseVisualStyleBackColor = false;
            this.okUserfatura.Click += new System.EventHandler(this.okUserfatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = " FATURA NO :";
            // 
            // userfatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(767, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okUserfatura);
            this.Controls.Add(this.okFatura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userfatura";
            this.Text = "userfatura";
            this.Load += new System.EventHandler(this.userfatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private usersDataSet8 usersDataSet8;
        private System.Windows.Forms.BindingSource tbfaturaBindingSource;
        private usersDataSet8TableAdapters.tbfaturaTableAdapter tbfaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox okFatura;
        private System.Windows.Forms.Button okUserfatura;
        private System.Windows.Forms.Label label1;
    }
}