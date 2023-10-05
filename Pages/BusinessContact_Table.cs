using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactManagementApplication.Pages
{
    public partial class BusinessContact_Table : Form  
    {         // object to call dbconnn
        Database.dbconn_BusinessContact dbconn = new Database.dbconn_BusinessContact(); 
        public BusinessContact_Table()
        {
            InitializeComponent();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            this.Hide();
            homePage.Show();
        }

        private void personalForm_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Form personalForm = new PersonalContact_Form();
            this.Hide();
            personalForm.Show();
        }

        private void personalContactTable_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Table personalContactTable = new PersonalContact_Table();
            this.Hide();
            personalContactTable.Show();
        }

        private void businessContactForm_Click(object sender, EventArgs e)
        {
            this.Text = "Business Contact Form";
            Pages.BusinessContact_Form businessContactForm = new BusinessContact_Form();
            this.Hide();
            businessContactForm.Show();
        }

        private void businessTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void businessTable_Load(object sender, EventArgs e)
        {
            businessTable.DataSource = dbconn.getAllBusinessContact().Tables[0];
            
           
        }
    }
}
