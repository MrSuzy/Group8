namespace Group8
{
    partial class frmEditSchedule
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.datetimeSession = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.lblOldVenue = new System.Windows.Forms.Label();
            this.lblOldGame = new System.Windows.Forms.Label();
            this.lblOldTime = new System.Windows.Forms.Label();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSearchGame = new System.Windows.Forms.Label();
            this.cbSearchGame = new System.Windows.Forms.ComboBox();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(22, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(157, 42);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(83, 109);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(324, 26);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Edit an Exisiting Training Session";
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDate.Location = new System.Drawing.Point(144, 147);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(116, 19);
            this.lblSearchDate.TabIndex = 4;
            this.lblSearchDate.Text = "Search by Date:";
            // 
            // datetimeSession
            // 
            this.datetimeSession.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSession.Location = new System.Drawing.Point(288, 145);
            this.datetimeSession.Name = "datetimeSession";
            this.datetimeSession.Size = new System.Drawing.Size(179, 25);
            this.datetimeSession.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(505, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(611, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 24);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbEdit.Controls.Add(this.lblOldVenue);
            this.gbEdit.Controls.Add(this.lblOldGame);
            this.gbEdit.Controls.Add(this.lblOldTime);
            this.gbEdit.Controls.Add(this.cbVenue);
            this.gbEdit.Controls.Add(this.lblVenue);
            this.gbEdit.Controls.Add(this.btnUpdate);
            this.gbEdit.Controls.Add(this.cbGame);
            this.gbEdit.Controls.Add(this.lblGame);
            this.gbEdit.Controls.Add(this.cbTime);
            this.gbEdit.Controls.Add(this.lblTime);
            this.gbEdit.Controls.Add(this.lblDetails);
            this.gbEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbEdit.Location = new System.Drawing.Point(88, 224);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(677, 309);
            this.gbEdit.TabIndex = 8;
            this.gbEdit.TabStop = false;
            // 
            // lblOldVenue
            // 
            this.lblOldVenue.AutoSize = true;
            this.lblOldVenue.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldVenue.Location = new System.Drawing.Point(23, 199);
            this.lblOldVenue.Name = "lblOldVenue";
            this.lblOldVenue.Size = new System.Drawing.Size(0, 20);
            this.lblOldVenue.TabIndex = 10;
            // 
            // lblOldGame
            // 
            this.lblOldGame.AutoSize = true;
            this.lblOldGame.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldGame.Location = new System.Drawing.Point(23, 139);
            this.lblOldGame.Name = "lblOldGame";
            this.lblOldGame.Size = new System.Drawing.Size(0, 20);
            this.lblOldGame.TabIndex = 9;
            // 
            // lblOldTime
            // 
            this.lblOldTime.AutoSize = true;
            this.lblOldTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldTime.Location = new System.Drawing.Point(22, 76);
            this.lblOldTime.Name = "lblOldTime";
            this.lblOldTime.Size = new System.Drawing.Size(0, 20);
            this.lblOldTime.TabIndex = 8;
            // 
            // cbVenue
            // 
            this.cbVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVenue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Items.AddRange(new object[] {
            "Gaming Lab 6",
            "Gaming Lab 5"});
            this.cbVenue.Location = new System.Drawing.Point(419, 199);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(143, 25);
            this.cbVenue.TabIndex = 7;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(249, 201);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(137, 19);
            this.lblVenue.TabIndex = 6;
            this.lblVenue.Text = "Select New Venue:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(331, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbGame
            // 
            this.cbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "CS:GO",
            "League of Legends",
            "Valorant"});
            this.cbGame.Location = new System.Drawing.Point(421, 139);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(143, 25);
            this.cbGame.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(250, 141);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(136, 19);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "Select New Game:";
            // 
            // cbTime
            // 
            this.cbTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "12:30 - 14:00",
            "15:00 - 16:00",
            "17:30 - 19:30"});
            this.cbTime.Location = new System.Drawing.Point(419, 76);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(143, 25);
            this.cbTime.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(249, 77);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Select New Time:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(22, 19);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(156, 23);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Training Details: ";
            // 
            // lblSearchGame
            // 
            this.lblSearchGame.AutoSize = true;
            this.lblSearchGame.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGame.Location = new System.Drawing.Point(144, 184);
            this.lblSearchGame.Name = "lblSearchGame";
            this.lblSearchGame.Size = new System.Drawing.Size(124, 19);
            this.lblSearchGame.TabIndex = 9;
            this.lblSearchGame.Text = "Search by Game:";
            // 
            // cbSearchGame
            // 
            this.cbSearchGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSearchGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchGame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchGame.FormattingEnabled = true;
            this.cbSearchGame.Items.AddRange(new object[] {
            "CS:GO",
            "League of Legends",
            "Valorant"});
            this.cbSearchGame.Location = new System.Drawing.Point(288, 184);
            this.cbSearchGame.Name = "cbSearchGame";
            this.cbSearchGame.Size = new System.Drawing.Size(179, 25);
            this.cbSearchGame.TabIndex = 8;
            // 
            // frmEditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(902, 569);
            this.Controls.Add(this.cbSearchGame);
            this.Controls.Add(this.lblSearchGame);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.datetimeSession);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmEditSchedule";
            this.Text = "Edit Schedule";
            this.Load += new System.EventHandler(this.frmEditSchedule_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.DateTimePicker datetimeSession;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblSearchGame;
        private System.Windows.Forms.ComboBox cbSearchGame;
        private System.Windows.Forms.Label lblOldVenue;
        private System.Windows.Forms.Label lblOldGame;
        private System.Windows.Forms.Label lblOldTime;
    }
}