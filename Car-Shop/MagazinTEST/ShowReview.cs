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
    public partial class ShowReview : Form
    {
        public ShowReview()
        {
            InitializeComponent();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            DataTable reviews = new DataTable();
            
            DB db = new DB();
            db.openConnection();
            
            String Car = textBoxCarReview.Text;
            String Description = textBoxShowReview.Text;
            String Model = textBoxReviewModel.Text;
            
            try { 
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            
                MySqlCommand command = new MySqlCommand("INSERT INTO `reviews`(`Car`, `Description`,`Model`,`Data`)" +
                                                       " values('" + Car + "','" + Description + "','"+Model+"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')",
                                                        db.getConnection());

                command.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show("Review added succesfully");

                textBoxCarReview.Clear();
                textBoxShowReview.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter your review");
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
