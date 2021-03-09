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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Home homeform = new Home();
            homeform.TopLevel = false;
            
            panel2.Controls.Add(homeform);
            homeform.FormBorderStyle = FormBorderStyle.None;
            homeform.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Home homeform = new Home();
            homeform.TopLevel = false;
            
            panel2.Controls.Add(homeform);
            homeform.FormBorderStyle = FormBorderStyle.None;
            homeform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Contact contactform = new Contact();
            contactform.TopLevel = false;
         
            panel2.Controls.Add(contactform);
            contactform.FormBorderStyle = FormBorderStyle.None;
            contactform.Show();
        }

        private void bCars_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Cars cf = new Cars();
            cf.TopLevel = false;
            
            panel2.Controls.Add(cf);
            cf.FormBorderStyle = FormBorderStyle.None;
            cf.Show();
        }

        private void bReview_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Review rw = new Review();
            rw.TopLevel = false;
            
            panel2.Controls.Add(rw);
            rw.FormBorderStyle = FormBorderStyle.None;
            rw.Show();

        }

        private void bAddCar_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NewCar ac = new NewCar();
            ac.TopLevel = false;

            panel2.Controls.Add(ac);
            ac.FormBorderStyle = FormBorderStyle.None;
            ac.Show();
        }
    }
}
