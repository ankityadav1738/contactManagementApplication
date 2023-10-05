using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;

namespace contactManagementApplication.Pages
{
    public partial class PersonalContact_Table : Form
    {
        Database.dbconn_personalContact dbconn = new Database.dbconn_personalContact();
        public PersonalContact_Table()
        {   
            InitializeComponent();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            this.Hide();
            homePage.Show();
        }

        private void personalContact_Form_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Form personalContactForm = new BusinessContact_Form();
            this.Hide();
            personalContactForm.Show();
        }

        private void personalContactTable_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Table personalContactTable = new PersonalContact_Table();
            this.Hide();
            personalContactTable.Show();
        }
        private void businessContactForm_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Form businessContactForm = new BusinessContact_Form();
            this.Close();
            businessContactForm.Show();
        }

        private void businessContactTable_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Table businessContactTable = new BusinessContact_Table();
            this.Close();
            businessContactTable.Show();
        }
        private void personalTable_Load(object sender, EventArgs e)
        {
            personalTable.DataSource = dbconn.getAllPersonalContact().Tables[0];
        }

        
    }
}
