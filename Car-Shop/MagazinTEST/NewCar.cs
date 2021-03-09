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
    public partial class NewCar : Form
    {
        public NewCar()
        {
            InitializeComponent();
        }

        private void bAddCar_Click(object sender, EventArgs e)
        {

            DataTable cars = new DataTable();

            DB db = new DB();
            db.openConnection();

            String Brand = textBoxBrand.Text;
            String Year = textBoxYear.Text;
            String Model = textBoxModel.Text;
            String Descriere = "Cilindrical Capacity: " + textBoxCapacity.Text + " m³; \nGearbox: " + textBoxGearbox.Text + ";\nMileage meter: " + textBoxMileage.Text + " km; \nCar Body: " + textBoxBody.Text;
            string Pret = textBoxPret.Text;
            string id = textBoxID.Text;

            int num;
            
            if (int.TryParse(Pret, out num))
            {
                if (int.TryParse(Year, out num))
                {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                try
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `cars`(`id`,`Brand`, `Year`, `Model`, `Descriere`, `Pret`) " +
                                                           " values('" + id + "','" + Brand + "','" + Year + "','" + Model + "','" + Descriere + "','" + Pret + "')",
                                                            db.getConnection());
                    command.ExecuteNonQuery();
                    db.closeConnection();

                    MessageBox.Show("Car added succesfully");

                    textBoxYear.Clear();
                    textBoxBrand.Clear();
                    textBoxModel.Clear();
                    textBoxPret.Clear();
                    textBoxID.Clear();
                    textBoxCapacity.Clear();
                    textBoxGearbox.Clear();
                    textBoxMileage.Clear();
                    textBoxBody.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Duplicate ID");
                }
            }
                else
                {
                    MessageBox.Show("Please introduce correct year format ! ", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please introduce a correct price ! ", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            DataTable cars = new DataTable();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `id`,`Brand`, `Year`, `Model`, `Descriere`, `Pret` FROM `cars` ",
                db.getConnection());
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(cars);
            dataGridViewShowCars.DataSource = cars;

            db.closeConnection();            
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DataTable cars = new DataTable();

            DB db = new DB();
            db.openConnection();

            string id = textBoxID.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Delete from `cars` where ID='"+id+"'",
                                                    db.getConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Car deleted succesfully");
            }
            else if (command.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Please choose an id!");
            }

            db.closeConnection();

            textBoxBrand.Clear();
            textBoxYear.Clear();
            textBoxModel.Clear();
            textBoxPret.Clear();


        }
    }
}
