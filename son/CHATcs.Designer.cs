namespace son
{
    partial class chat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersDataSet6 = new son.usersDataSet6();
            this.tbchatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbchatTableAdapter = new son.usersDataSet6TableAdapters.tbchatTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.chat_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablo = new System.Windows.Forms.DataGridView();
            this.chatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbchatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet14 = new son.usersDataSet14();
            this.dbLoginDataSet1 = new son.dbLoginDataSet();
            this.tbchatTableAdapter1 = new son.usersDataSet14TableAdapters.tbchatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataSet6
            // 
            this.usersDataSet6.DataSetName = "usersDataSet6";
            this.usersDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbchatBindingSource
            // 
            this.tbchatBindingSource.DataMember = "tbchat";
            this.tbchatBindingSource.DataSource = this.usersDataSet6;
            // 
            // tbchatTableAdapter
            // 
            this.tbchatTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::son.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chat_id
            // 
            this.chat_id.Location = new System.Drawing.Point(110, 265);
            this.chat_id.Name = "chat_id";
            this.chat_id.Size = new System.Drawing.Size(224, 22);
            this.chat_id.TabIndex = 3;
            this.chat_id.TextChanged += new System.EventHandler(this.chat_id_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(377, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "MESAJI SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "MESAJ NO :";
            // 
            // tablo
            // 
            this.tablo.AllowUserToAddRows = false;
            this.tablo.AllowUserToDeleteRows = false;
            this.tablo.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chatidDataGridViewTextBoxColumn,
            this.chatDataGridViewTextBoxColumn,
            this.usersidDataGridViewTextBoxColumn});
            this.tablo.DataSource = this.tbchatBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablo.Location = new System.Drawing.Point(0, 44);
            this.tablo.Name = "tablo";
            this.tablo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablo.RowHeadersVisible = false;
            this.tablo.RowHeadersWidth = 51;
            this.tablo.RowTemplate.Height = 24;
            this.tablo.Size = new System.Drawing.Size(725, 150);
            this.tablo.TabIndex = 6;
            this.tablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chatidDataGridViewTextBoxColumn
            // 
            this.chatidDataGridViewTextBoxColumn.DataPropertyName = "chat_id";
            this.chatidDataGridViewTextBoxColumn.FillWeight = 200F;
            this.chatidDataGridViewTextBoxColumn.Frozen = true;
            this.chatidDataGridViewTextBoxColumn.HeaderText = "MESAJ NO";
            this.chatidDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.chatidDataGridViewTextBoxColumn.Name = "chatidDataGridViewTextBoxColumn";
            this.chatidDataGridViewTextBoxColumn.ReadOnly = true;
            this.chatidDataGridViewTextBoxColumn.Width = 125;
            // 
            // chatDataGridViewTextBoxColumn
            // 
            this.chatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chatDataGridViewTextBoxColumn.DataPropertyName = "chat";
            this.chatDataGridViewTextBoxColumn.FillWeight = 200F;
            this.chatDataGridViewTextBoxColumn.HeaderText = "MESAJ";
            this.chatDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.chatDataGridViewTextBoxColumn.Name = "chatDataGridViewTextBoxColumn";
            this.chatDataGridViewTextBoxColumn.ReadOnly = true;
            this.chatDataGridViewTextBoxColumn.Width = 81;
            // 
            // usersidDataGridViewTextBoxColumn
            // 
            this.usersidDataGridViewTextBoxColumn.DataPropertyName = "users_id";
            this.usersidDataGridViewTextBoxColumn.FillWeight = 200F;
            this.usersidDataGridViewTextBoxColumn.HeaderText = "KULLANICI NO";
            this.usersidDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.usersidDataGridViewTextBoxColumn.Name = "usersidDataGridViewTextBoxColumn";
            this.usersidDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersidDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbchatBindingSource1
            // 
            this.tbchatBindingSource1.DataMember = "tbchat";
            this.tbchatBindingSource1.DataSource = this.usersDataSet14;
            // 
            // usersDataSet14
            // 
            this.usersDataSet14.DataSetName = "usersDataSet14";
            this.usersDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbLoginDataSet1
            // 
            this.dbLoginDataSet1.DataSetName = "dbLoginDataSet";
            this.dbLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbchatTableAdapter1
            // 
            this.tbchatTableAdapter1.ClearBeforeFill = true;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(724, 394);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chat_id);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chat";
            this.Text = "CHATcs";
            this.Load += new System.EventHandler(this.chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private usersDataSet6 usersDataSet6;
        private System.Windows.Forms.BindingSource tbchatBindingSource;
        private usersDataSet6TableAdapters.tbchatTableAdapter tbchatTableAdapter;
        private System.Windows.Forms.TextBox chat_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablo;
        private dbLoginDataSet dbLoginDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersidDataGridViewTextBoxColumn;
        private usersDataSet14 usersDataSet14;
        private System.Windows.Forms.BindingSource tbchatBindingSource1;
        private usersDataSet14TableAdapters.tbchatTableAdapter tbchatTableAdapter1;
    }
}