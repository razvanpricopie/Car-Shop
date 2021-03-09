using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinTEST
{
    public partial class LoginForm : Form
    {
 
        public LoginForm()
        { 
            InitializeComponent();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Width, 30);
            this.textBoxUserName.AutoSize = false;
            this.textBoxUserName.Size = new Size(this.textBoxPassword.Width, 30);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String username = textBoxUserName.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @usn and password = @pass", 
                db.getConnection());


            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value= username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            // verificam daca exista user
          if(table.Rows.Count > 0)
            {
                for(int i=0;i<table.Rows.Count;i++)
                {
                    if(table.Rows[i]["IsAdmin"].ToString()=="Admin")
                    {
                        this.Hide();
                        Dash dash = new Dash();
                        dash.ShowDialog();
                    }

                    else
                    {
                        //deschide pagina pt user !
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                    }

                }

            }
            else
            {
                MessageBox.Show("Wrong username or password !");
            }
        }

        private void buttonGoReg_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            this.Hide();
            regform.ShowDialog();
            this.Close();
        }
    }
}
