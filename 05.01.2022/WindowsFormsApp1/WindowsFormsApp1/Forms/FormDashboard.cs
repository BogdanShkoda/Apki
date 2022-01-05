using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            donersUC1.BringToFront();
            labelTitle.Text = "Add or Update Done's Record";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
