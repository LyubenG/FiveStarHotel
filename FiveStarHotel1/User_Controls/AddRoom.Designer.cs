namespace FiveStarHotel1.User_Controls
{
    partial class AddRoom
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBedType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cbBedType = new System.Windows.Forms.ComboBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.dataRooms = new System.Windows.Forms.DataGridView();
            this.lblAddRooms = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::FiveStarHotel1.Properties.Resources.ContentHolder2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBackground.Controls.Add(this.btnRemove);
            this.pnlBackground.Controls.Add(this.pbTable);
            this.pnlBackground.Controls.Add(this.lblPrice);
            this.pnlBackground.Controls.Add(this.lblBedType);
            this.pnlBackground.Controls.Add(this.lblRoomType);
            this.pnlBackground.Controls.Add(this.lblRoomNo);
            this.pnlBackground.Controls.Add(this.btnAddRoom);
            this.pnlBackground.Controls.Add(this.cbBedType);
            this.pnlBackground.Controls.Add(this.cbRoomType);
            this.pnlBackground.Controls.Add(this.tbPrice);
            this.pnlBackground.Controls.Add(this.tbRoomNo);
            this.pnlBackground.Controls.Add(this.dataRooms);
            this.pnlBackground.Controls.Add(this.lblAddRooms);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(629, 434);
            this.pnlBackground.TabIndex = 1;
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.Transparent;
            this.pbTable.BackgroundImage = global::FiveStarHotel1.Properties.Resources.AddRoomPic;
            this.pbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTable.Location = new System.Drawing.Point(50, 45);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(26, 20);
            this.pbTable.TabIndex = 11;
            this.pbTable.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Location = new System.Drawing.Point(477, 276);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 22);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Enter Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedType
            // 
            this.lblBedType.BackColor = System.Drawing.Color.Transparent;
            this.lblBedType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBedType.Location = new System.Drawing.Point(480, 218);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(111, 22);
            this.lblBedType.TabIndex = 9;
            this.lblBedType.Text = "Enter Bed Type:";
            this.lblBedType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomType
            // 
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRoomType.Location = new System.Drawing.Point(480, 161);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(111, 22);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Enter Room Type:";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRoomNo.Location = new System.Drawing.Point(480, 102);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(111, 22);
            this.lblRoomNo.TabIndex = 7;
            this.lblRoomNo.Text = "Enter Room Number:";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.FlatAppearance.BorderSize = 2;
            this.btnAddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddRoom.Location = new System.Drawing.Point(477, 340);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(116, 31);
            this.btnAddRoom.TabIndex = 6;
            this.btnAddRoom.Text = "Add Room!";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // cbBedType
            // 
            this.cbBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBedType.FormattingEnabled = true;
            this.cbBedType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin Beds"});
            this.cbBedType.Location = new System.Drawing.Point(480, 243);
            this.cbBedType.Name = "cbBedType";
            this.cbBedType.Size = new System.Drawing.Size(111, 21);
            this.cbBedType.TabIndex = 5;
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Apartament"});
            this.cbRoomType.Location = new System.Drawing.Point(480, 186);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(111, 21);
            this.cbRoomType.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(477, 301);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(114, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Location = new System.Drawing.Point(480, 127);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(111, 20);
            this.tbRoomNo.TabIndex = 2;
            this.tbRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataRooms
            // 
            this.dataRooms.AllowUserToAddRows = false;
            this.dataRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.dataRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataRooms.Location = new System.Drawing.Point(43, 92);
            this.dataRooms.MultiSelect = false;
            this.dataRooms.Name = "dataRooms";
            this.dataRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataRooms.RowHeadersWidth = 5;
            this.dataRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRooms.Size = new System.Drawing.Size(420, 326);
            this.dataRooms.TabIndex = 1;
            this.dataRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRooms_CellClick);
            // 
            // lblAddRooms
            // 
            this.lblAddRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblAddRooms.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddRooms.Location = new System.Drawing.Point(82, 45);
            this.lblAddRooms.Name = "lblAddRooms";
            this.lblAddRooms.Size = new System.Drawing.Size(93, 20);
            this.lblAddRooms.TabIndex = 0;
            this.lblAddRooms.Text = "Add Rooms";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(477, 385);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 31);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove Room!";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pnlBackground);
            this.Name = "AddRoom";
            this.Size = new System.Drawing.Size(629, 434);
            this.VisibleChanged += new System.EventHandler(this.AddRoom_VisibleChanged);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dataRooms;
        private System.Windows.Forms.Label lblAddRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ComboBox cbBedType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.PictureBox pbTable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnRemove;
    }
}
