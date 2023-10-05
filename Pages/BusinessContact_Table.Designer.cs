
namespace contactManagementApplication.Pages
{
    partial class BusinessContact_Table
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
            this.personalForm = new System.Windows.Forms.Button();
            this.personalContactTable = new System.Windows.Forms.Button();
            this.businessContactTable = new System.Windows.Forms.Button();
            this.businessTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.businessTable)).BeginInit();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(-1, 1);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(184, 62);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home Page ";
            this.homePage.UseVisualStyleBackColor = true;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // personalForm
            // 
            this.personalForm.Location = new System.Drawing.Point(181, 1);
            this.personalForm.Name = "personalForm";
            this.personalForm.Size = new System.Drawing.Size(189, 62);
            this.personalForm.TabIndex = 1;
            this.personalForm.Text = "Personal Contact Form ";
            this.personalForm.UseVisualStyleBackColor = true;
            this.personalForm.Click += new System.EventHandler(this.personalForm_Click);
            // 
            // personalContactTable
            // 
            this.personalContactTable.Location = new System.Drawing.Point(365, 1);
            this.personalContactTable.Name = "personalContactTable";
            this.personalContactTable.Size = new System.Drawing.Size(207, 62);
            this.personalContactTable.TabIndex = 2;
            this.personalContactTable.Text = "Personal Contact Table";
            this.personalContactTable.UseVisualStyleBackColor = true;
            this.personalContactTable.Click += new System.EventHandler(this.personalContactTable_Click);
            // 
            // businessContactTable
            // 
            this.businessContactTable.Location = new System.Drawing.Point(566, 1);
            this.businessContactTable.Name = "businessContactTable";
            this.businessContactTable.Size = new System.Drawing.Size(232, 62);
            this.businessContactTable.TabIndex = 3;
            this.businessContactTable.Text = "BusinessContactTable";
            this.businessContactTable.UseVisualStyleBackColor = true;
            this.businessContactTable.Click += new System.EventHandler(this.businessContactForm_Click);
            // 
            // businessTable
            // 
            this.businessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bName,
            this.EmployeeName,
            this.BusinessEmail,
            this.businessPhoneNum,
            this.companyAddress,
            this.postCode});
            this.businessTable.Location = new System.Drawing.Point(78, 62);
            this.businessTable.Name = "businessTable";
            this.businessTable.RowHeadersWidth = 62;
            this.businessTable.RowTemplate.Height = 28;
            this.businessTable.Size = new System.Drawing.Size(720, 391);
            this.businessTable.TabIndex = 4;
            this.businessTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessTable_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // bName
            // 
            this.bName.HeaderText = "Business Name";
            this.bName.MinimumWidth = 8;
            this.bName.Name = "bName";
            this.bName.Width = 150;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 8;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 150;
            // 
            // BusinessEmail
            // 
            this.BusinessEmail.HeaderText = "Business Email";
            this.BusinessEmail.MinimumWidth = 8;
            this.BusinessEmail.Name = "BusinessEmail";
            this.BusinessEmail.Width = 150;
            // 
            // businessPhoneNum
            // 
            this.businessPhoneNum.HeaderText = "Business Phone Number ";
            this.businessPhoneNum.MinimumWidth = 8;
            this.businessPhoneNum.Name = "businessPhoneNum";
            this.businessPhoneNum.Width = 150;
            // 
            // companyAddress
            // 
            this.companyAddress.HeaderText = "Company Address";
            this.companyAddress.MinimumWidth = 8;
            this.companyAddress.Name = "companyAddress";
            this.companyAddress.Width = 150;
            // 
            // postCode
            // 
            this.postCode.HeaderText = "Post Code";
            this.postCode.MinimumWidth = 8;
            this.postCode.Name = "postCode";
            this.postCode.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Contact";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Contact";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete Contact";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BusinessContact_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.businessTable);
            this.Controls.Add(this.businessContactTable);
            this.Controls.Add(this.personalContactTable);
            this.Controls.Add(this.personalForm);
            this.Controls.Add(this.homePage);
            this.Name = "BusinessContact_Table";
            this.Text = "Personal Contact Management System (Business Contact Form)";
            ((System.ComponentModel.ISupportInitialize)(this.businessTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button personalForm;
        private System.Windows.Forms.Button personalContactTable;
        private System.Windows.Forms.Button businessContactTable;
        private System.Windows.Forms.DataGridView businessTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}