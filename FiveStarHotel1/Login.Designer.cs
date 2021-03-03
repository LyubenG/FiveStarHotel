namespace FiveStarHotel1
{
    partial class Login
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.lblWrongInfo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::FiveStarHotel1.Properties.Resources.LoginLogo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Location = new System.Drawing.Point(32, 31);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(228, 222);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BackgroundImage = global::FiveStarHotel1.Properties.Resources.LoginBG1;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.pbPass);
            this.pnlLogin.Controls.Add(this.pbUser);
            this.pnlLogin.Controls.Add(this.pbEye);
            this.pnlLogin.Controls.Add(this.lblWrongInfo);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.tbPass);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.tbUsername);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.Location = new System.Drawing.Point(107, 121);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(635, 295);
            this.pnlLogin.TabIndex = 1;
            // 
            // pbPass
            // 
            this.pbPass.BackgroundImage = global::FiveStarHotel1.Properties.Resources.loginPass;
            this.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPass.Location = new System.Drawing.Point(301, 166);
            this.pbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(33, 25);
            this.pbPass.TabIndex = 17;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::FiveStarHotel1.Properties.Resources.loginUser;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUser.Location = new System.Drawing.Point(301, 101);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(33, 25);
            this.pbUser.TabIndex = 16;
            this.pbUser.TabStop = false;
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.Transparent;
            this.pbEye.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Eye;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEye.Location = new System.Drawing.Point(573, 166);
            this.pbEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(40, 25);
            this.pbEye.TabIndex = 15;
            this.pbEye.TabStop = false;
            this.pbEye.MouseLeave += new System.EventHandler(this.pbEye_MouseLeave);
            this.pbEye.MouseHover += new System.EventHandler(this.pbEye_MouseHover);
            // 
            // lblWrongInfo
            // 
            this.lblWrongInfo.AutoSize = true;
            this.lblWrongInfo.ForeColor = System.Drawing.Color.Red;
            this.lblWrongInfo.Location = new System.Drawing.Point(360, 256);
            this.lblWrongInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWrongInfo.Name = "lblWrongInfo";
            this.lblWrongInfo.Size = new System.Drawing.Size(187, 17);
            this.lblWrongInfo.TabIndex = 7;
            this.lblWrongInfo.Text = "Wrong Username/Password!";
            this.lblWrongInfo.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(376, 215);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(360, 138);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 25);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Enter Password: ";
            this.tbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(343, 166);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(221, 22);
            this.tbPass.TabIndex = 2;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(360, 73);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(192, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Enter Username: ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(343, 101);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(221, 22);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(425, 31);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::FiveStarHotel1.Properties.Resources.LoginExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(791, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FiveStarHotel1.Properties.Resources.BlurredBG;
            this.ClientSize = new System.Drawing.Size(851, 535);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblWrongInfo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label tbPassword;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        public System.Windows.Forms.TextBox tbUsername;
    }
}

