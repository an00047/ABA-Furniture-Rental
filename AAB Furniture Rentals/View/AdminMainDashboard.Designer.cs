﻿
namespace AAB_Furniture_Rentals.View
{
    partial class AdminMainDashboard
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.adminSearchUpdateAddEmployee1 = new AAB_Furniture_Rentals.View.UserControls.AdminSearchUpdateAddEmployee();
            this.AdminTabControl.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(805, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutLabel.Location = new System.Drawing.Point(729, 31);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLabel.TabIndex = 2;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // reportTab
            // 
            this.reportTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(788, 329);
            this.reportTab.TabIndex = 1;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.employeesTab);
            this.AdminTabControl.Controls.Add(this.reportTab);
            this.AdminTabControl.Location = new System.Drawing.Point(2, 83);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(796, 355);
            this.AdminTabControl.TabIndex = 0;
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.adminSearchUpdateAddEmployee1);
            this.employeesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesTab.Location = new System.Drawing.Point(4, 22);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTab.Size = new System.Drawing.Size(788, 329);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // adminSearchUpdateAddEmployee1
            // 
            this.adminSearchUpdateAddEmployee1.Location = new System.Drawing.Point(-109, -31);
            this.adminSearchUpdateAddEmployee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminSearchUpdateAddEmployee1.Name = "adminSearchUpdateAddEmployee1";
            this.adminSearchUpdateAddEmployee1.Size = new System.Drawing.Size(901, 355);
            this.adminSearchUpdateAddEmployee1.TabIndex = 0;
            // 
            // AdminMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.AdminTabControl);
            this.Name = "AdminMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainDashboard_FormClose);
            this.AdminTabControl.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage employeesTab;
        private UserControls.AdminSearchUpdateAddEmployee adminSearchUpdateAddEmployee1;
    }
}