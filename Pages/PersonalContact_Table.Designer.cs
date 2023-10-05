
namespace contactManagementApplication.Pages
{
    partial class PersonalContact_Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homePage = new System.Windows.Forms.Button();
            this.personalContact_Form = new System.Windows.Forms.Button();
            this.personalContactTable = new System.Windows.Forms.Button();
            this.businessContactTable = new System.Windows.Forms.Button();
            this.personalTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(0, 1);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(182, 62);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home Page";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // personalContact_Form
            // 
            this.personalContact_Form.Location = new System.Drawing.Point(178, 1);
            this.personalContact_Form.Name = "personalContact_Form";
            this.personalContact_Form.Size = new System.Drawing.Size(207, 62);
            this.personalContact_Form.TabIndex = 1;
            this.personalContact_Form.Text = "Personal Contact Form";
            this.personalContact_Form.UseVisualStyleBackColor = true;
            this.personalContact_Form.Click += new System.EventHandler(this.personalContact_Form_Click);
            // 
            // personalContactTable
            // 
            this.personalContactTable.Location = new System.Drawing.Point(378, 1);
            this.personalContactTable.Name = "personalContactTable";
            this.personalContactTable.Size = new System.Drawing.Size(211, 62);
            this.personalContactTable.TabIndex = 2;
            this.personalContactTable.Text = "Business Contact Form";
            this.personalContactTable.UseVisualStyleBackColor = true;
            this.personalContactTable.Click += new System.EventHandler(this.personalContactTable_Click);
            // 
            // businessContactTable
            // 
            this.businessContactTable.Location = new System.Drawing.Point(585, 1);
            this.businessContactTable.Name = "businessContactTable";
            this.businessContactTable.Size = new System.Drawing.Size(213, 62);
            this.businessContactTable.TabIndex = 3;
            this.businessContactTable.Text = "Business Contact Table";
            this.businessContactTable.UseVisualStyleBackColor = true;
            this.businessContactTable.Click += new System.EventHandler(this.businessContactTable_Click);
            // 
            // personalTable
            // 
            this.personalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.postCode,
            this.birth,
            this.homeAddress,
            this.email,
            this.phoneNum});
            this.personalTable.Location = new System.Drawing.Point(93, 69);
            this.personalTable.Name = "personalTable";
            this.personalTable.RowHeadersWidth = 62;
            this.personalTable.RowTemplate.Height = 28;
            this.personalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personalTable.Size = new System.Drawing.Size(705, 369);
            this.personalTable.TabIndex = 4;
          //  this.personalTable.SelectionChanged += new System.EventHandler(this.personalTable_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // postCode
            // 
            this.postCode.HeaderText = "Post Code";
            this.postCode.MinimumWidth = 8;
            this.postCode.Name = "postCode";
            this.postCode.Width = 150;
            // 
            // birth
            // 
            this.birth.HeaderText = "DOB";
            this.birth.MinimumWidth = 8;
            this.birth.Name = "birth";
            this.birth.Width = 150;
            // 
            // homeAddress
            // 
            this.homeAddress.HeaderText = "Home Address";
            this.homeAddress.MinimumWidth = 8;
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email Address";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // phoneNum
            // 
            this.phoneNum.HeaderText = "Phone Number";
            this.phoneNum.MinimumWidth = 8;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "create Contact";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Contact";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete Contact";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PersonalContact_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personalTable);
            this.Controls.Add(this.businessContactTable);
            this.Controls.Add(this.personalContactTable);
            this.Controls.Add(this.personalContact_Form);
            this.Controls.Add(this.homePage);
            this.Name = "PersonalContact_Table";
            this.Text = "Personal Contact Management System (Personal Contact Table)";
            ((System.ComponentModel.ISupportInitialize)(this.personalTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button personalContact_Form;
        private System.Windows.Forms.Button personalContactTable;
        private System.Windows.Forms.Button businessContactTable;
        private System.Windows.Forms.DataGridView personalTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}