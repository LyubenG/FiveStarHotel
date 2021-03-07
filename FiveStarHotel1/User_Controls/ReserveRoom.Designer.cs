namespace FiveStarHotel1.User_Controls
{
    partial class ReserveRoom
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
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.dpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.cbRoomAvailable = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblEnterPhone = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbTable = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBedType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.btnReserveRoom = new System.Windows.Forms.Button();
            this.cbBedType = new System.Windows.Forms.ComboBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblReserveRoom = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ContentHolder2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.tbNationality);
            this.pnlBackground.Controls.Add(this.tbPhoneNo);
            this.pnlBackground.Controls.Add(this.dpCheckIn);
            this.pnlBackground.Controls.Add(this.lblCheckInDate);
            this.pnlBackground.Controls.Add(this.dpDOB);
            this.pnlBackground.Controls.Add(this.lblDOB);
            this.pnlBackground.Controls.Add(this.cbRoomAvailable);
            this.pnlBackground.Controls.Add(this.lblGender);
            this.pnlBackground.Controls.Add(this.cbGender);
            this.pnlBackground.Controls.Add(this.lblNationality);
            this.pnlBackground.Controls.Add(this.lblEnterPhone);
            this.pnlBackground.Controls.Add(this.lblEnterName);
            this.pnlBackground.Controls.Add(this.tbName);
            this.pnlBackground.Controls.Add(this.pbTable);
            this.pnlBackground.Controls.Add(this.lblPrice);
            this.pnlBackground.Controls.Add(this.lblBedType);
            this.pnlBackground.Controls.Add(this.lblRoomType);
            this.pnlBackground.Controls.Add(this.lblRoomNo);
            this.pnlBackground.Controls.Add(this.btnReserveRoom);
            this.pnlBackground.Controls.Add(this.cbBedType);
            this.pnlBackground.Controls.Add(this.cbRoomType);
            this.pnlBackground.Controls.Add(this.tbPrice);
            this.pnlBackground.Controls.Add(this.lblReserveRoom);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(837, 534);
            this.pnlBackground.TabIndex = 2;
            // 
            // tbNationality
            // 
            this.tbNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNationality.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNationality.Location = new System.Drawing.Point(172, 277);
            this.tbNationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNationality.MaxLength = 24;
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(170, 22);
            this.tbNationality.TabIndex = 3;
            this.tbNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhoneNo.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPhoneNo.Location = new System.Drawing.Point(172, 207);
            this.tbPhoneNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhoneNo.MaxLength = 10;
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(170, 22);
            this.tbPhoneNo.TabIndex = 2;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.Checked = false;
            this.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCheckIn.Location = new System.Drawing.Point(516, 134);
            this.dpCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpCheckIn.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dpCheckIn.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(169, 22);
            this.dpCheckIn.TabIndex = 6;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckInDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCheckInDate.Location = new System.Drawing.Point(516, 103);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(171, 27);
            this.lblCheckInDate.TabIndex = 23;
            this.lblCheckInDate.Text = "Check-in Date:";
            this.lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpDOB
            // 
            this.dpDOB.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dpDOB.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dpDOB.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDOB.Location = new System.Drawing.Point(172, 405);
            this.dpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpDOB.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(169, 22);
            this.dpDOB.TabIndex = 5;
            this.dpDOB.Value = new System.DateTime(2021, 2, 17, 20, 55, 58, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDOB.Location = new System.Drawing.Point(172, 374);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(171, 27);
            this.lblDOB.TabIndex = 21;
            this.lblDOB.Text = "Date Of Birth:";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRoomAvailable
            // 
            this.cbRoomAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbRoomAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomAvailable.ForeColor = System.Drawing.SystemColors.Window;
            this.cbRoomAvailable.FormattingEnabled = true;
            this.cbRoomAvailable.Location = new System.Drawing.Point(520, 345);
            this.cbRoomAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoomAvailable.Name = "cbRoomAvailable";
            this.cbRoomAvailable.Size = new System.Drawing.Size(169, 24);
            this.cbRoomAvailable.TabIndex = 9;
            this.cbRoomAvailable.SelectedIndexChanged += new System.EventHandler(this.cbRoomAvailable_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.ForeColor = System.Drawing.SystemColors.Window;
            this.lblGender.Location = new System.Drawing.Point(172, 314);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(171, 27);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGender.ForeColor = System.Drawing.SystemColors.Window;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(172, 345);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(169, 24);
            this.cbGender.TabIndex = 4;
            // 
            // lblNationality
            // 
            this.lblNationality.BackColor = System.Drawing.Color.Transparent;
            this.lblNationality.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNationality.Location = new System.Drawing.Point(172, 246);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(171, 27);
            this.lblNationality.TabIndex = 17;
            this.lblNationality.Text = "Nationality: ";
            this.lblNationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterPhone
            // 
            this.lblEnterPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterPhone.Location = new System.Drawing.Point(172, 175);
            this.lblEnterPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterPhone.Name = "lblEnterPhone";
            this.lblEnterPhone.Size = new System.Drawing.Size(171, 27);
            this.lblEnterPhone.TabIndex = 15;
            this.lblEnterPhone.Text = "Phone Number: ";
            this.lblEnterPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterName
            // 
            this.lblEnterName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterName.Location = new System.Drawing.Point(172, 103);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(171, 27);
            this.lblEnterName.TabIndex = 13;
            this.lblEnterName.Text = "Name: ";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(172, 134);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.MaxLength = 40;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.Transparent;
            this.pbTable.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ReserveRoom;
            this.pbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTable.Location = new System.Drawing.Point(67, 55);
            this.pbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(35, 25);
            this.pbTable.TabIndex = 11;
            this.pbTable.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Location = new System.Drawing.Point(520, 374);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(171, 27);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedType
            // 
            this.lblBedType.BackColor = System.Drawing.Color.Transparent;
            this.lblBedType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBedType.Location = new System.Drawing.Point(520, 245);
            this.lblBedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(171, 27);
            this.lblBedType.TabIndex = 9;
            this.lblBedType.Text = "Enter Bed Type:";
            this.lblBedType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomType
            // 
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRoomType.Location = new System.Drawing.Point(520, 175);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(171, 27);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Enter Room Type:";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRoomNo.Location = new System.Drawing.Point(520, 314);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(171, 27);
            this.lblRoomNo.TabIndex = 7;
            this.lblRoomNo.Text = "Room Number Available";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserveRoom
            // 
            this.btnReserveRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnReserveRoom.FlatAppearance.BorderSize = 2;
            this.btnReserveRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnReserveRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnReserveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserveRoom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReserveRoom.Location = new System.Drawing.Point(328, 464);
            this.btnReserveRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserveRoom.Name = "btnReserveRoom";
            this.btnReserveRoom.Size = new System.Drawing.Size(193, 38);
            this.btnReserveRoom.TabIndex = 11;
            this.btnReserveRoom.Text = "Reserve Room!";
            this.btnReserveRoom.UseVisualStyleBackColor = false;
            this.btnReserveRoom.Click += new System.EventHandler(this.btnReserveRoom_Click);
            // 
            // cbBedType
            // 
            this.cbBedType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBedType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBedType.ForeColor = System.Drawing.SystemColors.Window;
            this.cbBedType.FormattingEnabled = true;
            this.cbBedType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin Beds"});
            this.cbBedType.Location = new System.Drawing.Point(520, 276);
            this.cbBedType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBedType.Name = "cbBedType";
            this.cbBedType.Size = new System.Drawing.Size(169, 24);
            this.cbBedType.TabIndex = 8;
            this.cbBedType.SelectedIndexChanged += new System.EventHandler(this.cbBedType_SelectedIndexChanged);
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.ForeColor = System.Drawing.SystemColors.Window;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Apartament"});
            this.cbRoomType.Location = new System.Drawing.Point(520, 206);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(169, 24);
            this.cbRoomType.TabIndex = 7;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPrice.Enabled = false;
            this.tbPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPrice.Location = new System.Drawing.Point(520, 405);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(169, 22);
            this.tbPrice.TabIndex = 10;
            this.tbPrice.Text = "7";
            // 
            // lblReserveRoom
            // 
            this.lblReserveRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblReserveRoom.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReserveRoom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReserveRoom.Location = new System.Drawing.Point(109, 55);
            this.lblReserveRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserveRoom.Name = "lblReserveRoom";
            this.lblReserveRoom.Size = new System.Drawing.Size(173, 25);
            this.lblReserveRoom.TabIndex = 0;
            this.lblReserveRoom.Text = "Reserve Room";
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReserveRoom";
            this.Size = new System.Drawing.Size(839, 534);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pbTable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Button btnReserveRoom;
        private System.Windows.Forms.ComboBox cbBedType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblReserveRoom;
        private System.Windows.Forms.ComboBox cbRoomAvailable;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblEnterPhone;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dpCheckIn;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.TextBox tbPhoneNo;
    }
}
