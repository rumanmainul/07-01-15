namespace EmployeeInfirmationApp
{
    partial class MainUI
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addDesignationButton = new System.Windows.Forms.Button();
            this.findAndEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(56, 103);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(133, 57);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addDesignationButton
            // 
            this.addDesignationButton.Location = new System.Drawing.Point(224, 103);
            this.addDesignationButton.Name = "addDesignationButton";
            this.addDesignationButton.Size = new System.Drawing.Size(133, 57);
            this.addDesignationButton.TabIndex = 0;
            this.addDesignationButton.Text = "Add Designation";
            this.addDesignationButton.UseVisualStyleBackColor = true;
            this.addDesignationButton.Click += new System.EventHandler(this.addDesignationButton_Click);
            // 
            // findAndEditButton
            // 
            this.findAndEditButton.Location = new System.Drawing.Point(385, 103);
            this.findAndEditButton.Name = "findAndEditButton";
            this.findAndEditButton.Size = new System.Drawing.Size(133, 57);
            this.findAndEditButton.TabIndex = 0;
            this.findAndEditButton.Text = "Find  and Edit";
            this.findAndEditButton.UseVisualStyleBackColor = true;
            this.findAndEditButton.Click += new System.EventHandler(this.findAndEditButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 311);
            this.Controls.Add(this.findAndEditButton);
            this.Controls.Add(this.addDesignationButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button addDesignationButton;
        private System.Windows.Forms.Button findAndEditButton;
    }
}

