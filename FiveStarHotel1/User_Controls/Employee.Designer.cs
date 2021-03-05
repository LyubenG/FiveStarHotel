
namespace FiveStarHotel1.User_Controls
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEnterEType = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbEmployeeType = new System.Windows.Forms.ComboBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.dataEmployees = new System.Windows.Forms.DataGridView();
            this.lblAddEmployees = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ContentHolder2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.btnEditRoom);
            this.pnlBackground.Controls.Add(this.pbEye);
            this.pnlBackground.Controls.Add(this.btnRemove);
            this.pnlBackground.Controls.Add(this.tbPassword);
            this.pnlBackground.Controls.Add(this.pbEmployee);
            this.pnlBackground.Controls.Add(this.lblEnterEType);
            this.pnlBackground.Controls.Add(this.lblEnterPassword);
            this.pnlBackground.Controls.Add(this.lblEnterUsername);
            this.pnlBackground.Controls.Add(this.btnAddEmployee);
            this.pnlBackground.Controls.Add(this.cbEmployeeType);
            this.pnlBackground.Controls.Add(this.tbUsername);
            this.pnlBackground.Controls.Add(this.dataEmployees);
            this.pnlBackground.Controls.Add(this.lblAddEmployees);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(839, 534);
            this.pnlBackground.TabIndex = 2;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnEditRoom.FlatAppearance.BorderSize = 2;
            this.btnEditRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnEditRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnEditRoom.Location = new System.Drawing.Point(622, 427);
            this.btnEditRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(181, 38);
            this.btnEditRoom.TabIndex = 15;
            this.btnEditRoom.Text = "Edit Employee";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.Transparent;
            this.pbEye.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Eye;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEye.Location = new System.Drawing.Point(693, 271);
            this.pbEye.Margin = new System.Windows.Forms.Padding(4);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(37, 22);
            this.pbEye.TabIndex = 14;
            this.pbEye.TabStop = false;
            this.pbEye.MouseLeave += new System.EventHandler(this.pbEye_MouseLeave);
            this.pbEye.MouseHover += new System.EventHandler(this.pbEye_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(622, 473);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(181, 38);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(624, 239);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(179, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pbEmployee.BackgroundImage = global::FiveStarHotel1.Properties.Resources.EmployeesIcon;
            this.pbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmployee.Location = new System.Drawing.Point(67, 55);
            this.pbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(35, 25);
            this.pbEmployee.TabIndex = 11;
            this.pbEmployee.TabStop = false;
            // 
            // lblEnterEType
            // 
            this.lblEnterEType.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterEType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterEType.Location = new System.Drawing.Point(624, 299);
            this.lblEnterEType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterEType.Name = "lblEnterEType";
            this.lblEnterEType.Size = new System.Drawing.Size(180, 27);
            this.lblEnterEType.TabIndex = 9;
            this.lblEnterEType.Text = "Enter Employee Type";
            this.lblEnterEType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEnterPassword.Location = new System.Drawing.Point(624, 208);
            this.lblEnterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(180, 27);
            this.lblEnterPassword.TabIndex = 8;
            this.lblEnterPassword.Text = "Enter New Password";
            this.lblEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterUsername.Location = new System.Drawing.Point(625, 133);
            this.lblEnterUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(179, 27);
            this.lblEnterUsername.TabIndex = 7;
            this.lblEnterUsername.Text = "Enter New Username";
            this.lblEnterUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatAppearance.BorderSize = 2;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddEmployee.Location = new System.Drawing.Point(623, 381);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(181, 38);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbEmployeeType
            // 
            this.cbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeType.FormattingEnabled = true;
            this.cbEmployeeType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbEmployeeType.Location = new System.Drawing.Point(624, 330);
            this.cbEmployeeType.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmployeeType.Name = "cbEmployeeType";
            this.cbEmployeeType.Size = new System.Drawing.Size(179, 24);
            this.cbEmployeeType.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(624, 164);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(179, 22);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataEmployees
            // 
            this.dataEmployees.AllowUserToAddRows = false;
            this.dataEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.dataEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEmployees.Location = new System.Drawing.Point(57, 113);
            this.dataEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dataEmployees.MultiSelect = false;
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataEmployees.RowHeadersWidth = 5;
            this.dataEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployees.Size = new System.Drawing.Size(560, 401);
            this.dataEmployees.TabIndex = 6;
            this.dataEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployees_CellClick);
            // 
            // lblAddEmployees
            // 
            this.lblAddEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEmployees.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddEmployees.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddEmployees.Location = new System.Drawing.Point(109, 55);
            this.lblAddEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddEmployees.Name = "lblAddEmployees";
            this.lblAddEmployees.Size = new System.Drawing.Size(169, 25);
            this.lblAddEmployees.TabIndex = 0;
            this.lblAddEmployees.Text = "Add Employees";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(837, 534);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.VisibleChanged += new System.EventHandler(this.Employee_VisibleChanged);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEnterEType;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cbEmployeeType;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.DataGridView dataEmployees;
        private System.Windows.Forms.Label lblAddEmployees;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.Button btnEditRoom;
    }
}
