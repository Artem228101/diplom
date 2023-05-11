using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Добавление : Form
    {
        DB db = new DB();
        public Добавление()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var ID_цеха = textBox_ID_цеха.Text;
            int ID_обор;
            var Состояние = textBox_Состояние.Text;
            var Наименование = textBox_Наименование.Text;
          
            if (int.TryParse(textBox_ID_оборудования.Text, out ID_обор))
            {
                var addQuerry = $"insert Оборудование (ID_цеха,ID_оборудования,Состояние,Наименование) values('{ID_цеха}','{ID_обор}','{Состояние}','{Наименование}')";
                var command = new SqlCommand(addQuerry, db.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте вводимые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            db.closeConnection();

        
    }
    }
}
