using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactManagementApplication
{
    public partial class Form1 : Form
    {
        Pages.PersonalContact_Form personalForm = new Pages.PersonalContact_Form();

        public Form1()
        {    // adjust windows form to screen size
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Contact Management System (Home Page)";  // display page title 
        }

        private void personalContactTable_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Table personalTable = new Pages.PersonalContact_Table();
            personalTable.Show();
            this.Hide();
        }

        private void personalContactForm_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Form personalForm = new Pages.PersonalContact_Form();
            this.Hide();
            personalForm.Show();
        }

        private void businessForm_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Table businessForm = new Pages.BusinessContact_Table(); 
            this.Hide();
            businessForm.Show();
        }

        private void businessContactForm_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Form businessForm = new Pages.BusinessContact_Form();
            this.Hide();
            businessForm.Show();
        }
    }
}
