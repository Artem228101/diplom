namespace WindowsFormsApp1
{
    partial class Ремонт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ремонт));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.плановыйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аварийныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.капитальныйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet1 = new WindowsFormsApp1.workshopDataSet1();
            this.ремонтTableAdapter = new WindowsFormsApp1.workshopDataSet1TableAdapters.РемонтTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 92);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(319, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ремонт";
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
            this.label1.Location = new System.Drawing.Point(470, 57);
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
            this.iDоборудованияDataGridViewTextBoxColumn,
            this.плановыйDataGridViewTextBoxColumn,
            this.аварийныйDataGridViewTextBoxColumn,
            this.капитальныйDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ремонтBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(96, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDоборудованияDataGridViewTextBoxColumn
            // 
            this.iDоборудованияDataGridViewTextBoxColumn.DataPropertyName = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn.HeaderText = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDоборудованияDataGridViewTextBoxColumn.Name = "iDоборудованияDataGridViewTextBoxColumn";
            this.iDоборудованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDоборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // плановыйDataGridViewTextBoxColumn
            // 
            this.плановыйDataGridViewTextBoxColumn.DataPropertyName = "Плановый";
            this.плановыйDataGridViewTextBoxColumn.HeaderText = "Плановый";
            this.плановыйDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.плановыйDataGridViewTextBoxColumn.Name = "плановыйDataGridViewTextBoxColumn";
            this.плановыйDataGridViewTextBoxColumn.ReadOnly = true;
            this.плановыйDataGridViewTextBoxColumn.Width = 125;
            // 
            // аварийныйDataGridViewTextBoxColumn
            // 
            this.аварийныйDataGridViewTextBoxColumn.DataPropertyName = "Аварийный";
            this.аварийныйDataGridViewTextBoxColumn.HeaderText = "Аварийный";
            this.аварийныйDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.аварийныйDataGridViewTextBoxColumn.Name = "аварийныйDataGridViewTextBoxColumn";
            this.аварийныйDataGridViewTextBoxColumn.ReadOnly = true;
            this.аварийныйDataGridViewTextBoxColumn.Width = 125;
            // 
            // капитальныйDataGridViewTextBoxColumn
            // 
            this.капитальныйDataGridViewTextBoxColumn.DataPropertyName = "Капитальный";
            this.капитальныйDataGridViewTextBoxColumn.HeaderText = "Капитальный";
            this.капитальныйDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.капитальныйDataGridViewTextBoxColumn.Name = "капитальныйDataGridViewTextBoxColumn";
            this.капитальныйDataGridViewTextBoxColumn.ReadOnly = true;
            this.капитальныйDataGridViewTextBoxColumn.Width = 125;
            // 
            // ремонтBindingSource
            // 
            this.ремонтBindingSource.DataMember = "Ремонт";
            this.ремонтBindingSource.DataSource = this.workshopDataSet1;
            // 
            // workshopDataSet1
            // 
            this.workshopDataSet1.DataSetName = "workshopDataSet1";
            this.workshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ремонтTableAdapter
            // 
            this.ремонтTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(46, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вернутся";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ремонт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Ремонт";
            this.Text = "Ремонт";
            this.Load += new System.EventHandler(this.Ремонт_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private workshopDataSet1 workshopDataSet1;
        private System.Windows.Forms.BindingSource ремонтBindingSource;
        private workshopDataSet1TableAdapters.РемонтTableAdapter ремонтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn плановыйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аварийныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn капитальныйDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}