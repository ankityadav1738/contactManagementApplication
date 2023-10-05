using System;
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
    public partial class BusinessContact_Form : Form
    {
        Database.dbconn_BusinessContact dbconnBusinessContact = new Database.dbconn_BusinessContact();
        public BusinessContact_Form()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 homeButton = new Form1();
            this.Hide();
            homeButton.Show();
        }

        private void personalContactForm_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Form personalForm = new PersonalContact_Form();
            this.Hide();
            personalForm.Show();
        }

        private void personalContactTable_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Table personalForm = new PersonalContact_Table();
            this.Hide();
            personalForm.Show();
        }

        private void businessTable_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Table businessTable = new BusinessContact_Table();
            this.Hide();
            businessTable.Show();
        }

        private void BusinessContact_Form_Load(object sender, EventArgs e)
        {  // used to load business contact 
           
        }
    }
}
