namespace FiveStarHotel1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panelSideNav = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.lblNameOfProgram = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkOut1 = new FiveStarHotel1.User_Controls.CheckOut();
            this.reserveRoom1 = new FiveStarHotel1.User_Controls.ReserveRoom();
            this.addRoom1 = new FiveStarHotel1.User_Controls.AddRoom();
            this.homePage1 = new FiveStarHotel1.User_Controls.HomePage();
            this.employee1 = new FiveStarHotel1.User_Controls.Employee();
            this.panelSideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTopNav.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideNav
            // 
            this.panelSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSideNav.Controls.Add(this.btnEmployees);
            this.panelSideNav.Controls.Add(this.btnCheckOut);
            this.panelSideNav.Controls.Add(this.btnCustomerInfo);
            this.panelSideNav.Controls.Add(this.btnReserve);
            this.panelSideNav.Controls.Add(this.btnAddRoom);
            this.panelSideNav.Controls.Add(this.btnHome);
            this.panelSideNav.Controls.Add(this.pbLogo);
            this.panelSideNav.Location = new System.Drawing.Point(0, 0);
            this.panelSideNav.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideNav.Name = "panelSideNav";
            this.panelSideNav.Size = new System.Drawing.Size(215, 624);
            this.panelSideNav.TabIndex = 0;
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.Image = global::FiveStarHotel1.Properties.Resources.EmployeesIcon;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.Location = new System.Drawing.Point(0, 459);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEmployees.Size = new System.Drawing.Size(215, 59);
            this.btnEmployees.TabIndex = 7;
            this.btnEmployees.Text = "Employee";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckOut.Image = global::FiveStarHotel1.Properties.Resources.CheckOut;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckOut.Location = new System.Drawing.Point(0, 393);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnCheckOut.Size = new System.Drawing.Size(215, 59);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.FlatAppearance.BorderSize = 0;
            this.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInfo.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCustomerInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomerInfo.Image = global::FiveStarHotel1.Properties.Resources.CustomerInfo;
            this.btnCustomerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerInfo.Location = new System.Drawing.Point(0, 326);
            this.btnCustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCustomerInfo.Size = new System.Drawing.Size(215, 59);
            this.btnCustomerInfo.TabIndex = 5;
            this.btnCustomerInfo.Text = "Customers Info";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // btnReserve
            // 
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnReserve.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReserve.Image = global::FiveStarHotel1.Properties.Resources.RingIcon2;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserve.Location = new System.Drawing.Point(0, 260);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnReserve.Size = new System.Drawing.Size(215, 59);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve Room";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddRoom.Image = global::FiveStarHotel1.Properties.Resources.ReserveIcon;
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoom.Location = new System.Drawing.Point(0, 183);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnAddRoom.Size = new System.Drawing.Size(215, 59);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = global::FiveStarHotel1.Properties.Resources.HomeIcon2;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 117);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnHome.Size = new System.Drawing.Size(215, 59);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnNav_Clicked);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(47, 31);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 79);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlTopNav.Controls.Add(this.lblNameOfProgram);
            this.pnlTopNav.Controls.Add(this.btnMinimize);
            this.pnlTopNav.Controls.Add(this.btnExit);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1163, 31);
            this.pnlTopNav.TabIndex = 1;
            this.pnlTopNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNameOfProgram_MouseDown_1);
            // 
            // lblNameOfProgram
            // 
            this.lblNameOfProgram.AutoSize = true;
            this.lblNameOfProgram.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameOfProgram.Location = new System.Drawing.Point(553, 7);
            this.lblNameOfProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOfProgram.Name = "lblNameOfProgram";
            this.lblNameOfProgram.Size = new System.Drawing.Size(100, 17);
            this.lblNameOfProgram.TabIndex = 2;
            this.lblNameOfProgram.Text = "FiveStarsHotel";
            this.lblNameOfProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNameOfProgram_MouseDown_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FiveStarHotel1.Properties.Resources.MinimizeButton1;
            this.btnMinimize.Location = new System.Drawing.Point(1083, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 31);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::FiveStarHotel1.Properties.Resources.exitButton;
            this.btnExit.Location = new System.Drawing.Point(1123, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.employee1);
            this.pnlContent.Controls.Add(this.checkOut1);
            this.pnlContent.Controls.Add(this.reserveRoom1);
            this.pnlContent.Controls.Add(this.addRoom1);
            this.pnlContent.Controls.Add(this.homePage1);
            this.pnlContent.Location = new System.Drawing.Point(256, 53);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(859, 545);
            this.pnlContent.TabIndex = 3;
            // 
            // pbArrow
            // 
            this.pbArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbArrow.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Arrow;
            this.pbArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbArrow.Location = new System.Drawing.Point(215, 117);
            this.pbArrow.Margin = new System.Windows.Forms.Padding(4);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(33, 59);
            this.pbArrow.TabIndex = 2;
            this.pbArrow.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // checkOut1
            // 
            this.checkOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.checkOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkOut1.Location = new System.Drawing.Point(4, 7);
            this.checkOut1.Margin = new System.Windows.Forms.Padding(5);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(839, 534);
            this.checkOut1.TabIndex = 3;
            this.checkOut1.Load += new System.EventHandler(this.checkOut1_Load);
            // 
            // reserveRoom1
            // 
            this.reserveRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.reserveRoom1.Location = new System.Drawing.Point(4, 7);
            this.reserveRoom1.Margin = new System.Windows.Forms.Padding(5);
            this.reserveRoom1.Name = "reserveRoom1";
            this.reserveRoom1.Size = new System.Drawing.Size(839, 534);
            this.reserveRoom1.TabIndex = 2;
            // 
            // addRoom1
            // 
            this.addRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.addRoom1.Location = new System.Drawing.Point(4, 7);
            this.addRoom1.Margin = new System.Windows.Forms.Padding(5);
            this.addRoom1.Name = "addRoom1";
            this.addRoom1.Size = new System.Drawing.Size(839, 534);
            this.addRoom1.TabIndex = 1;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.homePage1.Location = new System.Drawing.Point(4, 7);
            this.homePage1.Margin = new System.Windows.Forms.Padding(5);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(839, 534);
            this.homePage1.TabIndex = 0;
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Margin = new System.Windows.Forms.Padding(4);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(859, 545);
            this.employee1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1163, 624);
            this.Controls.Add(this.pnlTopNav);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.panelSideNav);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveStarHotel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideNav;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblNameOfProgram;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel pnlContent;
        private User_Controls.HomePage homePage1;
        private User_Controls.AddRoom addRoom1;
        private User_Controls.ReserveRoom reserveRoom1;
        private User_Controls.CheckOut checkOut1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private User_Controls.Employee employee1;
    }
}