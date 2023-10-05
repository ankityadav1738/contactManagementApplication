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
    public partial class PersonalContact_Form : Form
    {
        public PersonalContact_Form()
        {
            InitializeComponent();
        }

        private void businessForm_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Form businessForm = new BusinessContact_Form();
            this.Close();
            businessForm.Show();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            this.Hide();
            homePage.Show();
        }

        private void personalTable_Click(object sender, EventArgs e)
        {
            Pages.PersonalContact_Table personalTable = new PersonalContact_Table();
            this.Hide();
            personalTable.Show();
        }

        private void businessTable_Click(object sender, EventArgs e)
        {
            Pages.BusinessContact_Table businessContact = new BusinessContact_Table();
            this.Hide();
            businessContact.Show();
        }

        private void title_Click(object sender, EventArgs e)
        {
            title.Font = new Font(title.Font.FontFamily, 14, FontStyle.Bold & FontStyle.Underline); // makes title bold and increase font syze
        }

        private void PersonalContact_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
