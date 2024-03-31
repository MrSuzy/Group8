namespace Group8
{
    partial class frmScheduleDelete
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.cbSearchGame = new System.Windows.Forms.ComboBox();
            this.lblSearchGame = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.datetimeSession = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.lblVenueInfo = new System.Windows.Forms.Label();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.lblTimeInfo = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.gbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(22, 26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(157, 39);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(73, 100);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(326, 26);
            this.lblDelete.TabIndex = 4;
            this.lblDelete.Text = "Delete Exisiting Training Sessions";
            // 
            // cbSearchGame
            // 
            this.cbSearchGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSearchGame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchGame.FormattingEnabled = true;
            this.cbSearchGame.Items.AddRange(new object[] {
            "CS:GO",
            "League of Legends",
            "Valorant"});
            this.cbSearchGame.Location = new System.Drawing.Point(264, 184);
            this.cbSearchGame.Name = "cbSearchGame";
            this.cbSearchGame.Size = new System.Drawing.Size(179, 25);
            this.cbSearchGame.TabIndex = 14;
            // 
            // lblSearchGame
            // 
            this.lblSearchGame.AutoSize = true;
            this.lblSearchGame.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGame.Location = new System.Drawing.Point(120, 184);
            this.lblSearchGame.Name = "lblSearchGame";
            this.lblSearchGame.Size = new System.Drawing.Size(124, 19);
            this.lblSearchGame.TabIndex = 15;
            this.lblSearchGame.Text = "Search by Game:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(587, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 22);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(481, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 22);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // datetimeSession
            // 
            this.datetimeSession.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSession.Location = new System.Drawing.Point(264, 147);
            this.datetimeSession.Name = "datetimeSession";
            this.datetimeSession.Size = new System.Drawing.Size(179, 25);
            this.datetimeSession.TabIndex = 11;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDate.Location = new System.Drawing.Point(120, 150);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(116, 19);
            this.lblSearchDate.TabIndex = 10;
            this.lblSearchDate.Text = "Search by Date:";
            // 
            // gbDelete
            // 
            this.gbDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbDelete.Controls.Add(this.lblVenueInfo);
            this.gbDelete.Controls.Add(this.lblGameInfo);
            this.gbDelete.Controls.Add(this.lblTimeInfo);
            this.gbDelete.Controls.Add(this.lblVenue);
            this.gbDelete.Controls.Add(this.btnDelete);
            this.gbDelete.Controls.Add(this.lblGame);
            this.gbDelete.Controls.Add(this.lblTime);
            this.gbDelete.Controls.Add(this.lblDetails);
            this.gbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDelete.Location = new System.Drawing.Point(124, 232);
            this.gbDelete.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(583, 291);
            this.gbDelete.TabIndex = 16;
            this.gbDelete.TabStop = false;
            // 
            // lblVenueInfo
            // 
            this.lblVenueInfo.AutoSize = true;
            this.lblVenueInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueInfo.Location = new System.Drawing.Point(207, 176);
            this.lblVenueInfo.Name = "lblVenueInfo";
            this.lblVenueInfo.Size = new System.Drawing.Size(0, 19);
            this.lblVenueInfo.TabIndex = 9;
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInfo.Location = new System.Drawing.Point(207, 127);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(0, 19);
            this.lblGameInfo.TabIndex = 8;
            // 
            // lblTimeInfo
            // 
            this.lblTimeInfo.AutoSize = true;
            this.lblTimeInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInfo.Location = new System.Drawing.Point(207, 79);
            this.lblTimeInfo.Name = "lblTimeInfo";
            this.lblTimeInfo.Size = new System.Drawing.Size(0, 19);
            this.lblTimeInfo.TabIndex = 7;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVenue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(79, 176);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(62, 19);
            this.lblVenue.TabIndex = 6;
            this.lblVenue.Text = " Venue:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(221, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(79, 125);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(59, 19);
            this.lblGame.TabIndex = 3;
            this.lblGame.Text = "Game:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(79, 77);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(22, 18);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(156, 23);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Training Details: ";
            // 
            // frmScheduleDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.cbSearchGame);
            this.Controls.Add(this.lblSearchGame);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.datetimeSession);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmScheduleDelete";
            this.Text = "Coach_Delete_Schedule";
            this.Load += new System.EventHandler(this.frmScheduleDelete_Load);
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.ComboBox cbSearchGame;
        private System.Windows.Forms.Label lblSearchGame;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker datetimeSession;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblVenueInfo;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label lblTimeInfo;
    }
}