namespace son
{
    partial class userDelet
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
            this.dbLoginDataSet3 = new son.dbLoginDataSet3();
            this.tbusTableAdapter = new son.dbLoginDataSet3TableAdapters.tbusTableAdapter();
            this.users_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.usersDataSet1 = new son.usersDataSet1();
            this.tbuseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbuseTableAdapter = new son.usersDataSet1TableAdapters.tbuseTableAdapter();
            this.usersDataSet2 = new son.usersDataSet2();
            this.tbuseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbuseTableAdapter1 = new son.usersDataSet2TableAdapters.tbuseTableAdapter();
            this.tbuseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet3 = new son.usersDataSet3();
            this.tbuseTableAdapter2 = new son.usersDataSet3TableAdapters.tbuseTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usPhonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usHomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usDoorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataSet13 = new son.usersDataSet13();
            this.tbuseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbuseTableAdapter3 = new son.usersDataSet13TableAdapters.tbuseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbusBindingSource
            // 
            this.tbusBindingSource.DataMember = "tbus";
            this.tbusBindingSource.DataSource = this.dbLoginDataSet3;
            // 
            // dbLoginDataSet3
            // 
            this.dbLoginDataSet3.DataSetName = "dbLoginDataSet3";
            this.dbLoginDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusTableAdapter
            // 
            this.tbusTableAdapter.ClearBeforeFill = true;
            // 
            // users_id
            // 
            this.users_id.Location = new System.Drawing.Point(189, 296);
            this.users_id.Name = "users_id";
            this.users_id.Size = new System.Drawing.Size(248, 22);
            this.users_id.TabIndex = 4;
            this.users_id.TextChanged += new System.EventHandler(this.users_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANIDI İD :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(484, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "KULLANICIYI SİL ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "usersDataSet1";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseBindingSource
            // 
            this.tbuseBindingSource.DataMember = "tbuse";
            this.tbuseBindingSource.DataSource = this.usersDataSet1;
            // 
            // tbuseTableAdapter
            // 
            this.tbuseTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet2
            // 
            this.usersDataSet2.DataSetName = "usersDataSet2";
            this.usersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseBindingSource1
            // 
            this.tbuseBindingSource1.DataMember = "tbuse";
            this.tbuseBindingSource1.DataSource = this.usersDataSet2;
            // 
            // tbuseTableAdapter1
            // 
            this.tbuseTableAdapter1.ClearBeforeFill = true;
            // 
            // tbuseBindingSource2
            // 
            this.tbuseBindingSource2.DataMember = "tbuse";
            this.tbuseBindingSource2.DataSource = this.usersDataSet3;
            // 
            // usersDataSet3
            // 
            this.usersDataSet3.DataSetName = "usersDataSet3";
            this.usersDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseTableAdapter2
            // 
            this.tbuseTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::son.Properties.Resources.back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 34);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.usPhonDataGridViewTextBoxColumn,
            this.usHomNoDataGridViewTextBoxColumn,
            this.usDoorNoDataGridViewTextBoxColumn,
            this.roolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbuseBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 167);
            this.dataGridView1.TabIndex = 10;
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
            // usPhonDataGridViewTextBoxColumn
            // 
            this.usPhonDataGridViewTextBoxColumn.DataPropertyName = "usPhon";
            this.usPhonDataGridViewTextBoxColumn.HeaderText = "usPhon";
            this.usPhonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usPhonDataGridViewTextBoxColumn.Name = "usPhonDataGridViewTextBoxColumn";
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
            // roolDataGridViewTextBoxColumn
            // 
            this.roolDataGridViewTextBoxColumn.DataPropertyName = "rool";
            this.roolDataGridViewTextBoxColumn.HeaderText = "rool";
            this.roolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roolDataGridViewTextBoxColumn.Name = "roolDataGridViewTextBoxColumn";
            // 
            // usersDataSet13
            // 
            this.usersDataSet13.DataSetName = "usersDataSet13";
            this.usersDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbuseBindingSource3
            // 
            this.tbuseBindingSource3.DataMember = "tbuse";
            this.tbuseBindingSource3.DataSource = this.usersDataSet13;
            // 
            // tbuseTableAdapter3
            // 
            this.tbuseTableAdapter3.ClearBeforeFill = true;
            // 
            // userDelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(767, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.users_id);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userDelet";
            this.Text = "userDelet";
            this.Load += new System.EventHandler(this.userDelet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbuseBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private dbLoginDataSet3 dbLoginDataSet3;
        private System.Windows.Forms.BindingSource tbusBindingSource;
        private dbLoginDataSet3TableAdapters.tbusTableAdapter tbusTableAdapter;
        private System.Windows.Forms.TextBox users_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private usersDataSet1 usersDataSet1;
        private System.Windows.Forms.BindingSource tbuseBindingSource;
        private usersDataSet1TableAdapters.tbuseTableAdapter tbuseTableAdapter;
        private usersDataSet2 usersDataSet2;
        private System.Windows.Forms.BindingSource tbuseBindingSource1;
        private usersDataSet2TableAdapters.tbuseTableAdapter tbuseTableAdapter1;
        private usersDataSet3 usersDataSet3;
        private System.Windows.Forms.BindingSource tbuseBindingSource2;
        private usersDataSet3TableAdapters.tbuseTableAdapter tbuseTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usPhonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usHomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usDoorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roolDataGridViewTextBoxColumn;
        private usersDataSet13 usersDataSet13;
        private System.Windows.Forms.BindingSource tbuseBindingSource3;
        private usersDataSet13TableAdapters.tbuseTableAdapter tbuseTableAdapter3;
    }
}