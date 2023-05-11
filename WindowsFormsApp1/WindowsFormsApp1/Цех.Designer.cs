namespace WindowsFormsApp1
{
    partial class Цех
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Цех));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDцехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоРабочихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоОборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цехBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet1 = new WindowsFormsApp1.workshopDataSet1();
            this.цехTableAdapter = new WindowsFormsApp1.workshopDataSet1TableAdapters.ЦехTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 92);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(333, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цех";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(456, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работник";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDцехаDataGridViewTextBoxColumn,
            this.количествоРабочихDataGridViewTextBoxColumn,
            this.количествоОборудованияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.цехBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(143, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 245);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDцехаDataGridViewTextBoxColumn
            // 
            this.iDцехаDataGridViewTextBoxColumn.DataPropertyName = "ID_цеха";
            this.iDцехаDataGridViewTextBoxColumn.HeaderText = "ID_цеха";
            this.iDцехаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDцехаDataGridViewTextBoxColumn.Name = "iDцехаDataGridViewTextBoxColumn";
            this.iDцехаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDцехаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоРабочихDataGridViewTextBoxColumn
            // 
            this.количествоРабочихDataGridViewTextBoxColumn.DataPropertyName = "Количество рабочих";
            this.количествоРабочихDataGridViewTextBoxColumn.HeaderText = "Количество рабочих";
            this.количествоРабочихDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоРабочихDataGridViewTextBoxColumn.Name = "количествоРабочихDataGridViewTextBoxColumn";
            this.количествоРабочихDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоРабочихDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоОборудованияDataGridViewTextBoxColumn
            // 
            this.количествоОборудованияDataGridViewTextBoxColumn.DataPropertyName = "Количество оборудования";
            this.количествоОборудованияDataGridViewTextBoxColumn.HeaderText = "Количество оборудования";
            this.количествоОборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоОборудованияDataGridViewTextBoxColumn.Name = "количествоОборудованияDataGridViewTextBoxColumn";
            this.количествоОборудованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоОборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // цехBindingSource
            // 
            this.цехBindingSource.DataMember = "Цех";
            this.цехBindingSource.DataSource = this.workshopDataSet1;
            // 
            // workshopDataSet1
            // 
            this.workshopDataSet1.DataSetName = "workshopDataSet1";
            this.workshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цехTableAdapter
            // 
            this.цехTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(50, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Цех
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Цех";
            this.Text = "Цех";
            this.Load += new System.EventHandler(this.Цех_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private workshopDataSet1 workshopDataSet1;
        private System.Windows.Forms.BindingSource цехBindingSource;
        private workshopDataSet1TableAdapters.ЦехTableAdapter цехTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDцехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоРабочихDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоОборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}