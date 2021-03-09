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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            dataGridViewCars.DataSource = GetCarList();
            dataGridViewCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private DataTable GetCarList()
        {
            DataTable cars = new DataTable();

            DB db = new DB();
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `Brand`, `Year`, `Model`, `Descriere`, `Pret` FROM `cars` ",
                db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(cars);
            db.closeConnection();
            return cars;
        }

        private void bShowDetails_Click(object sender, EventArgs e)
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.textBoxDetailsBrand.Text= dataGridViewCars.CurrentRow.Cells[0].Value.ToString();
            showDetails.textBoxDetailsYear.Text=dataGridViewCars.CurrentRow.Cells[1].Value.ToString();
            showDetails.textBoxDetailsModel.Text= dataGridViewCars.CurrentRow.Cells[2].Value.ToString();
            showDetails.textBoxDetailsPret.Text = dataGridViewCars.CurrentRow.Cells[4].Value.ToString();
            showDetails.textBoxDetailsDescription.Text = dataGridViewCars.CurrentRow.Cells[3].Value.ToString();
            showDetails.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bReview click
            ShowReview review = new ShowReview();
            review.textBoxCarReview.Text = dataGridViewCars.CurrentRow.Cells[0].Value.ToString();
            review.textBoxReviewModel.Text = dataGridViewCars.CurrentRow.Cells[2].Value.ToString();
            review.ShowDialog();
        }

    }
}
