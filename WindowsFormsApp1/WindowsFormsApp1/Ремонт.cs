﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ремонт : Form
    {
        public Ремонт()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Ремонт_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet1.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.workshopDataSet1.Ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            this.Hide();
            login.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
