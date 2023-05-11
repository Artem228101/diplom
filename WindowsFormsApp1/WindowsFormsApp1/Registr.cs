using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registr : Form
    {
        DB db = new DB();
        public Registr()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 28);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loginField.Text = " ";
            passField.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = true;
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            passField.PasswordChar = '•';
            pictureBox4.Visible = true;
            loginField.MaxLength = 50;
            passField.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                return;

            }


            var login = loginField.Text;
            var pass = md5.hashPassword(passField.Text);
            if (loginField.Text == "" || passField.Text == "" || loginField.Text == "" && passField.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string str = $"insert into рабочие(id_рабочего, Логин, Пароль, id_цеха) values(0,'{login}', '{pass}',0)";
            SqlCommand command = new SqlCommand(str,db.GetConnection());
            db.openConnection();
            if(command.ExecuteNonQuery() == 1 )
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Form3 l = new Form3();
                this.Hide();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            db.closeConnection();
        }
        private bool checkuser()
        {
            var loginUser = loginField.Text;
        

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_рабочего,Логин,Пароль,id_цеха  from Рабочие where Логин='{loginUser}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
         
       

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
