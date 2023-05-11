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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DB dataBase = new DB();
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.passField.AutoSize = false;
     
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = md5.hashPassword(passField.Text);


            DataTable datatable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            string querystring = $"select id_рабочего,Логин,Пароль,id_цеха  from Рабочие " +
             $"where Логин='{loginUser}' and Пароль='{passUser}'";

            // объект для того чтобы это все работало - передаем строку и подключение
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());



            adapter.SelectCommand = command;
            adapter.Fill(datatable);
            if (datatable.Rows.Count == 1)
            {
                var user = new checkuser(datatable.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(datatable.Rows[0].ItemArray[3]));


                MessageBox.Show("Вход выполняется");
                loginField.Clear();
                passField.Clear();
                Form2 login = new Form2();
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
            else if (loginField.Text == "" || loginField.Text == "" || passField.Text == "")
                MessageBox.Show("Заполенены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
            else if (datatable.Rows.Count == 0)
            {
                MessageBox.Show("Нет такого аккаунта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

}

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loginField.Text = " ";
            passField.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = false;
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            passField.PasswordChar = '•';
            pictureBox4.Visible = true;
            loginField.MaxLength = 50;
            passField.MaxLength = 50;   

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registr login = new Registr();
            this.Hide();
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
