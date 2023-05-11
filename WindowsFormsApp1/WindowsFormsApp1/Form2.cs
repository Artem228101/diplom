using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form2 : Form
    {
        private readonly checkuser _user;

        DB db = new DB();

        int selectRow;
        public Form2()
        {

            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
 
        }
       
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_цеха", "ID_цеха");
            dataGridView1.Columns.Add("ID_оборудования", "ID_оборудования");
            dataGridView1.Columns.Add("Состояние", "Состояние");
            dataGridView1.Columns.Add("Наименование", "Наименование");
      
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)// доступ к значениям столбоов для каждой строки (для дата ридер)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3),RowState.ModifiedNew);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qew = $"select * from Оборудование";
            SqlCommand command = new SqlCommand(qew, db.GetConnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearField();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
           
            CreateColumns();
            RefreshDataGrid(dataGridView1);
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавление login = new Добавление();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectRow];

                textBox_ID_цеха.Text = row.Cells[0].Value.ToString();
                textBox_ID_оборудования.Text = row.Cells[1].Value.ToString();
                textBox_Состояние.Text = row.Cells[2].Value.ToString();
                textBox_Наименование.Text = row.Cells[3].Value.ToString();
             
            }

            }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Оборудование where concat (ID_цеха ,ID_оборудования, Наименование, Состояние)   like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, db.GetConnection());

            db.openConnection();

       
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
             dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
            }
        }
        private void ClearField()
        {
            textBox_ID_цеха.Text = "";
            textBox_ID_оборудования.Text = "";
            textBox_Состояние.Text = "";
            textBox_Наименование.Text = "";

        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var ID_цеха = textBox_ID_цеха.Text;
            var ID_оборудования = textBox_ID_оборудования.Text;
            var Наименование = textBox_Наименование.Text;
            int Состояние;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_Состояние.Text, out Состояние))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(ID_цеха, ID_оборудования, Наименование, Состояние);
                    dataGridView1.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Состояние должно иметь буквенный формат");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Update()
        {
            db.openConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[0].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_цеха = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Оборудование where id_цеха = {id_цеха}";

                    var command = new SqlCommand(deleteQuery,db.GetConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var ID_цеха = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var ID_оборудования = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var Состояние = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var Наименование = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update Оборудование set ID_цеха= '{ID_цеха},ID_оборудования = '{ID_оборудования}',Состояние = '{Состояние}',Наименование = '{Наименование}'";
                    var command = new SqlCommand(changeQuery,db.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearField();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change();
            ClearField();
        }
    }
    }

