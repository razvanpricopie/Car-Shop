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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private DataTable getReivewList()
        {
            DataTable reviews = new DataTable();

            DB db = new DB();
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `Data`, `Car`, `Model`,`Description` FROM `reviews`",
                db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(reviews);
            db.closeConnection();
            return reviews;
        }

        private void Review_Load(object sender, EventArgs e)
        {
            dataGridViewReview.DataSource = getReivewList();
            dataGridViewReview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
