namespace FiveStarHotel1.User_Controls
{
    partial class CheckOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pbTable = new System.Windows.Forms.PictureBox();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCustomerCheckOut = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ContentHolder2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.pbTable);
            this.pnlBackground.Controls.Add(this.dataCustomers);
            this.pnlBackground.Controls.Add(this.lblCheckOutDate);
            this.pnlBackground.Controls.Add(this.lblRoom);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.Controls.Add(this.btnCheckOut);
            this.pnlBackground.Controls.Add(this.dpCheckOutDate);
            this.pnlBackground.Controls.Add(this.tbRoomNo);
            this.pnlBackground.Controls.Add(this.tbName);
            this.pnlBackground.Controls.Add(this.tbSearch);
            this.pnlBackground.Controls.Add(this.lblSearch);
            this.pnlBackground.Controls.Add(this.lblCustomerCheckOut);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(628, 434);
            this.pnlBackground.TabIndex = 3;
            this.pnlBackground.VisibleChanged += new System.EventHandler(this.pnlBackground_VisibleChanged);
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.Transparent;
            this.pbTable.BackgroundImage = global::FiveStarHotel1.Properties.Resources.checkoutIconBig;
            this.pbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTable.Location = new System.Drawing.Point(50, 45);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(26, 20);
            this.pbTable.TabIndex = 13;
            this.pbTable.TabStop = false;
            // 
            // dataCustomers
            // 
            this.dataCustomers.AllowUserToAddRows = false;
            this.dataCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.dataCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCustomers.Location = new System.Drawing.Point(43, 127);
            this.dataCustomers.MultiSelect = false;
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCustomers.RowHeadersWidth = 5;
            this.dataCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustomers.Size = new System.Drawing.Size(551, 250);
            this.dataCustomers.TabIndex = 2;
            this.dataCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomers_CellClick);
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckOutDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCheckOutDate.Location = new System.Drawing.Point(332, 383);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(100, 14);
            this.lblCheckOutDate.TabIndex = 11;
            this.lblCheckOutDate.Text = "Check Out Date: ";
            // 
            // lblRoom
            // 
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoom.Location = new System.Drawing.Point(187, 383);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(100, 14);
            this.lblRoom.TabIndex = 10;
            this.lblRoom.Text = "Room Of Customer:";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(40, 383);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 14);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name Of Customer:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckOut.FlatAppearance.BorderSize = 2;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckOut.Location = new System.Drawing.Point(484, 383);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(110, 48);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out!";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dpCheckOutDate
            // 
            this.dpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCheckOutDate.Location = new System.Drawing.Point(335, 400);
            this.dpCheckOutDate.Name = "dpCheckOutDate";
            this.dpCheckOutDate.Size = new System.Drawing.Size(125, 20);
            this.dpCheckOutDate.TabIndex = 7;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Enabled = false;
            this.tbRoomNo.Location = new System.Drawing.Point(190, 400);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(121, 20);
            this.tbRoomNo.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(43, 400);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(190, 101);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(235, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(263, 84);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 14);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search By Name: ";
            // 
            // lblCustomerCheckOut
            // 
            this.lblCustomerCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCustomerCheckOut.Location = new System.Drawing.Point(82, 45);
            this.lblCustomerCheckOut.Name = "lblCustomerCheckOut";
            this.lblCustomerCheckOut.Size = new System.Drawing.Size(175, 20);
            this.lblCustomerCheckOut.TabIndex = 1;
            this.lblCustomerCheckOut.Text = "Customer Check Out";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pnlBackground);
            this.DoubleBuffered = true;
            this.Name = "CheckOut";
            this.Size = new System.Drawing.Size(629, 434);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblCustomerCheckOut;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DateTimePicker dpCheckOutDate;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.PictureBox pbTable;
    }
}
