namespace Group8
{
    partial class frmNewSchedule
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
            this.lblNewSession = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.datetimeSession = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.cbCoach = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.gbNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(22, 26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(171, 39);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNewSession
            // 
            this.lblNewSession.AutoSize = true;
            this.lblNewSession.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSession.Location = new System.Drawing.Point(72, 102);
            this.lblNewSession.Name = "lblNewSession";
            this.lblNewSession.Size = new System.Drawing.Size(297, 26);
            this.lblNewSession.TabIndex = 2;
            this.lblNewSession.Text = "Create a New Training Session";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(83, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Select Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(83, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Select Time: ";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(83, 118);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(101, 19);
            this.lblGame.TabIndex = 5;
            this.lblGame.Text = "Select Game:";
            // 
            // datetimeSession
            // 
            this.datetimeSession.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeSession.Location = new System.Drawing.Point(241, 27);
            this.datetimeSession.Name = "datetimeSession";
            this.datetimeSession.Size = new System.Drawing.Size(200, 25);
            this.datetimeSession.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(167, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 46);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(326, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 46);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbNew
            // 
            this.gbNew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbNew.Controls.Add(this.cbCoach);
            this.gbNew.Controls.Add(this.cbLevel);
            this.gbNew.Controls.Add(this.lblCoach);
            this.gbNew.Controls.Add(this.lblLevel);
            this.gbNew.Controls.Add(this.cbVenue);
            this.gbNew.Controls.Add(this.cbGame);
            this.gbNew.Controls.Add(this.cbTime);
            this.gbNew.Controls.Add(this.lblVenue);
            this.gbNew.Controls.Add(this.lblDate);
            this.gbNew.Controls.Add(this.btnClear);
            this.gbNew.Controls.Add(this.lblTime);
            this.gbNew.Controls.Add(this.btnAdd);
            this.gbNew.Controls.Add(this.lblGame);
            this.gbNew.Controls.Add(this.datetimeSession);
            this.gbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNew.Location = new System.Drawing.Point(155, 148);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(613, 391);
            this.gbNew.TabIndex = 11;
            this.gbNew.TabStop = false;
            // 
            // cbCoach
            // 
            this.cbCoach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCoach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoach.FormattingEnabled = true;
            this.cbCoach.Items.AddRange(new object[] {
            "Shroud",
            "Kkoma"});
            this.cbCoach.Location = new System.Drawing.Point(241, 252);
            this.cbCoach.Name = "cbCoach";
            this.cbCoach.Size = new System.Drawing.Size(200, 25);
            this.cbCoach.TabIndex = 18;
            // 
            // cbLevel
            // 
            this.cbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLevel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced "});
            this.cbLevel.Location = new System.Drawing.Point(241, 160);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(200, 25);
            this.cbLevel.TabIndex = 17;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoach.Location = new System.Drawing.Point(83, 253);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(104, 19);
            this.lblCoach.TabIndex = 16;
            this.lblCoach.Text = "Select Coach:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(83, 161);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(99, 19);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "Select Level:";
            // 
            // cbVenue
            // 
            this.cbVenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVenue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Items.AddRange(new object[] {
            "Gaming Lab 6",
            "Gaming Lab 5"});
            this.cbVenue.Location = new System.Drawing.Point(241, 204);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(200, 25);
            this.cbVenue.TabIndex = 14;
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
            this.cbGame.Location = new System.Drawing.Point(241, 117);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(200, 25);
            this.cbGame.TabIndex = 13;
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
            this.cbTime.Location = new System.Drawing.Point(241, 73);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(200, 25);
            this.cbTime.TabIndex = 12;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(83, 205);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(102, 19);
            this.lblVenue.TabIndex = 11;
            this.lblVenue.Text = "Select Venue:";
            // 
            // frmNewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.lblNewSession);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmNewSchedule";
            this.Text = "New Schedule";
            this.gbNew.ResumeLayout(false);
            this.gbNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblNewSession;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.DateTimePicker datetimeSession;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbNew;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbCoach;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.Label lblLevel;
    }
}