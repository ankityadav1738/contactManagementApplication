
namespace contactManagementApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personalContactForm = new System.Windows.Forms.Button();
            this.businessContactForm = new System.Windows.Forms.Button();
            this.businessForm = new System.Windows.Forms.Button();
            this.personalContactTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalContactForm
            // 
            this.personalContactForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.personalContactForm.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.personalContactForm, "personalContactForm");
            this.personalContactForm.Name = "personalContactForm";
            this.personalContactForm.UseVisualStyleBackColor = false;
            this.personalContactForm.Click += new System.EventHandler(this.personalContactForm_Click);
            // 
            // businessContactForm
            // 
            this.businessContactForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.businessContactForm.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.businessContactForm, "businessContactForm");
            this.businessContactForm.Name = "businessContactForm";
            this.businessContactForm.UseVisualStyleBackColor = false;
            this.businessContactForm.Click += new System.EventHandler(this.businessContactForm_Click);
            // 
            // businessForm
            // 
            this.businessForm.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.businessForm, "businessForm");
            this.businessForm.Name = "businessForm";
            this.businessForm.UseVisualStyleBackColor = true;
            this.businessForm.Click += new System.EventHandler(this.businessForm_Click);
            // 
            // personalContactTable
            // 
            this.personalContactTable.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.personalContactTable, "personalContactTable");
            this.personalContactTable.Name = "personalContactTable";
            this.personalContactTable.UseVisualStyleBackColor = true;
            this.personalContactTable.Click += new System.EventHandler(this.personalContactTable_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.personalContactTable);
            this.Controls.Add(this.businessForm);
            this.Controls.Add(this.businessContactForm);
            this.Controls.Add(this.personalContactForm);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button personalContactForm;
        private System.Windows.Forms.Button businessContactForm;
        private System.Windows.Forms.Button businessForm;
        private System.Windows.Forms.Button personalContactTable;
    }
}

