namespace FiveStarHotel1.User_Controls
{
    partial class HomePage
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pbSeparator = new System.Windows.Forms.PictureBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.pbGuests = new System.Windows.Forms.PictureBox();
            this.pbBed = new System.Windows.Forms.PictureBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblFreeRooms = new System.Windows.Forms.Label();
            this.pbSeprator2 = new System.Windows.Forms.PictureBox();
            this.lblCountGuests = new System.Windows.Forms.Label();
            this.lblCountRooms = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeprator2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ContentHolder21;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.lblWelcome);
            this.pnlBackground.Controls.Add(this.pnlDate);
            this.pnlBackground.Controls.Add(this.pnlStatistics);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(837, 534);
            this.pnlBackground.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(109, 55);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(233, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome!";
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlDate.BackgroundImage = global::FiveStarHotel1.Properties.Resources.DateHolder;
            this.pnlDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDate.Controls.Add(this.lblCurrentDate);
            this.pnlDate.Controls.Add(this.lblDate);
            this.pnlDate.Location = new System.Drawing.Point(35, 289);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(773, 98);
            this.pnlDate.TabIndex = 7;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrentDate.Location = new System.Drawing.Point(0, 48);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(773, 32);
            this.lblCurrentDate.TabIndex = 8;
            this.lblCurrentDate.Text = "1/4/2021";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.Location = new System.Drawing.Point(0, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(773, 26);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Current Date: ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatistics.BackgroundImage = global::FiveStarHotel1.Properties.Resources.AdvertBackground;
            this.pnlStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStatistics.Controls.Add(this.pbSeparator);
            this.pnlStatistics.Controls.Add(this.btnReserve);
            this.pnlStatistics.Controls.Add(this.pbGuests);
            this.pnlStatistics.Controls.Add(this.pbBed);
            this.pnlStatistics.Controls.Add(this.lblGuests);
            this.pnlStatistics.Controls.Add(this.lblFreeRooms);
            this.pnlStatistics.Controls.Add(this.pbSeprator2);
            this.pnlStatistics.Controls.Add(this.lblCountGuests);
            this.pnlStatistics.Controls.Add(this.lblCountRooms);
            this.pnlStatistics.Location = new System.Drawing.Point(35, 132);
            this.pnlStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(773, 98);
            this.pnlStatistics.TabIndex = 1;
            // 
            // pbSeparator
            // 
            this.pbSeparator.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Separator;
            this.pbSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSeparator.Location = new System.Drawing.Point(236, 0);
            this.pbSeparator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSeparator.Name = "pbSeparator";
            this.pbSeparator.Size = new System.Drawing.Size(36, 98);
            this.pbSeparator.TabIndex = 2;
            this.pbSeparator.TabStop = false;
            // 
            // btnReserve
            // 
            this.btnReserve.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ReserveButton;
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReserve.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReserve.Location = new System.Drawing.Point(575, 0);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(159, 98);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "RESERVE ROOM";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            this.btnReserve.MouseLeave += new System.EventHandler(this.btnReserve_MouseLeave);
            this.btnReserve.MouseHover += new System.EventHandler(this.btnReserve_MouseHover);
            // 
            // pbGuests
            // 
            this.pbGuests.BackgroundImage = global::FiveStarHotel1.Properties.Resources.CurrentGuestsIcon2;
            this.pbGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGuests.Location = new System.Drawing.Point(260, 65);
            this.pbGuests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGuests.Name = "pbGuests";
            this.pbGuests.Size = new System.Drawing.Size(272, 30);
            this.pbGuests.TabIndex = 6;
            this.pbGuests.TabStop = false;
            // 
            // pbBed
            // 
            this.pbBed.BackgroundImage = global::FiveStarHotel1.Properties.Resources.CurrentGuestsIcon;
            this.pbBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBed.Location = new System.Drawing.Point(0, 65);
            this.pbBed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBed.Name = "pbBed";
            this.pbBed.Size = new System.Drawing.Size(252, 30);
            this.pbBed.TabIndex = 2;
            this.pbBed.TabStop = false;
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblGuests.Location = new System.Drawing.Point(260, 41);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(272, 21);
            this.lblGuests.TabIndex = 5;
            this.lblGuests.Text = "Current Guests";
            this.lblGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeRooms
            // 
            this.lblFreeRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFreeRooms.Location = new System.Drawing.Point(0, 41);
            this.lblFreeRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFreeRooms.Name = "lblFreeRooms";
            this.lblFreeRooms.Size = new System.Drawing.Size(252, 21);
            this.lblFreeRooms.TabIndex = 4;
            this.lblFreeRooms.Text = "Free rooms";
            this.lblFreeRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSeprator2
            // 
            this.pbSeprator2.BackgroundImage = global::FiveStarHotel1.Properties.Resources.Separator;
            this.pbSeprator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSeprator2.Location = new System.Drawing.Point(525, 0);
            this.pbSeprator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSeprator2.Name = "pbSeprator2";
            this.pbSeprator2.Size = new System.Drawing.Size(20, 98);
            this.pbSeprator2.TabIndex = 3;
            this.pbSeprator2.TabStop = false;
            // 
            // lblCountGuests
            // 
            this.lblCountGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountGuests.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCountGuests.Location = new System.Drawing.Point(260, 11);
            this.lblCountGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountGuests.Name = "lblCountGuests";
            this.lblCountGuests.Size = new System.Drawing.Size(272, 30);
            this.lblCountGuests.TabIndex = 1;
            this.lblCountGuests.Text = "0";
            this.lblCountGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountRooms
            // 
            this.lblCountRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountRooms.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCountRooms.Location = new System.Drawing.Point(0, 11);
            this.lblCountRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountRooms.Name = "lblCountRooms";
            this.lblCountRooms.Size = new System.Drawing.Size(252, 30);
            this.lblCountRooms.TabIndex = 0;
            this.lblCountRooms.Text = "0";
            this.lblCountRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(839, 534);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.VisibleChanged += new System.EventHandler(this.HomePage_VisibleChanged);
            this.pnlBackground.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeprator2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.PictureBox pbSeparator;
        private System.Windows.Forms.Label lblCountGuests;
        private System.Windows.Forms.Label lblCountRooms;
        private System.Windows.Forms.PictureBox pbSeprator2;
        private System.Windows.Forms.PictureBox pbBed;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblFreeRooms;
        private System.Windows.Forms.PictureBox pbGuests;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblWelcome;
    }
}
