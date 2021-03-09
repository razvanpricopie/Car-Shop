using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MagazinTEST
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Equals(""))
            {
                textBoxFirstname.Text = "first name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            //remove the focus from the textboxes
            this.ActiveControl = label1;
            comboBox1.SelectedIndex = 1;
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String usname = textBoxUsername.Text;
            if (usname.Equals("username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String usname = textBoxUsername.Text;
            if (usname.ToLower().Trim().Equals("username") || usname.Trim().Equals(""))
            {
                textBoxUsername.Text = "username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email adress") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email adress";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String pass = textBoxPassword.Text;
            if (pass.Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String pass = textBoxPassword.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            String cpass = textBoxConfirmPassword.Text;
            if (cpass.Equals("confirm password"))
            {
                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            String cpass = textBoxConfirmPassword.Text;
            if (cpass.ToLower().Trim().Equals("confirm password") ||
                cpass.ToLower().Trim().Equals("password") ||
                cpass.Trim().Equals(""))
            {
                textBoxConfirmPassword.Text = "confirm password";
                textBoxConfirmPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_Enter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Leave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {

            
            DB db = new DB();
            //add a new user
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `firstname`, `lastname`, `email`, `IsAdmin`) VALUES (@usn,@pass,@fn,@ln,@email,@admin)", db.getConnection());
            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value=textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@admin", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //open conn
            db.openConnection();

            if(!checkTextBoxesValues())
            {
                if (Regex.IsMatch(textBoxEmail.Text, pattern))
                {
                    if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
                    {
                        if (textBoxPassword.Text.Length > 5)
                        {
                            if (checkUsername())
                            {
                                MessageBox.Show("This username already exist !", "Duplicate username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                textBoxUsername.Clear();
                            }
                            else
                            {
                                //execute query
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Account created", "Acount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    textBoxUsername.Clear();
                                    textBoxFirstname.Clear();
                                    textBoxLastname.Clear();
                                    textBoxPassword.Clear();
                                    textBoxConfirmPassword.Clear();
                                    textBoxEmail.Clear();
                                    LoginForm logform = new LoginForm();
                                    this.Hide();
                                    logform.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password length must be at least 6 characters ! ", "Password error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            textBoxPassword.Clear();
                            textBoxConfirmPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm must match ! ", "Password error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        textBoxPassword.Clear();
                        textBoxConfirmPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email");
                    textBoxEmail.Clear();
                }

            }
            else
            {
                MessageBox.Show("Enter your information first !","Empty data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            //close conn
            db.closeConnection();
            
        }

        public Boolean checkUsername()
        {

            DB db = new DB();
            String username = textBoxUsername.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn",
                db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);
            // verificam daca exista user
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if(fname.Equals("first name") || lname.Equals("last name") || email.Equals("Email address") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm logform = new LoginForm();
            this.Hide();
            logform.ShowDialog();
            this.Close();
        }
    }
}
