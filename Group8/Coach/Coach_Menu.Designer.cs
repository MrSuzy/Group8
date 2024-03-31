namespace Group8
{
    partial class frmCoachMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoachMenu));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLgOut = new System.Windows.Forms.Button();
            this.picboxProfile = new System.Windows.Forms.PictureBox();
            this.lblCalender = new System.Windows.Forms.Label();
            this.monthCalendarMenu = new System.Windows.Forms.MonthCalendar();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRecommend = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblNavigate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(210, 33);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Coach!";
            // 
            // btnLgOut
            // 
            this.btnLgOut.BackColor = System.Drawing.Color.White;
            this.btnLgOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLgOut.Location = new System.Drawing.Point(243, 19);
            this.btnLgOut.Name = "btnLgOut";
            this.btnLgOut.Size = new System.Drawing.Size(101, 33);
            this.btnLgOut.TabIndex = 1;
            this.btnLgOut.Text = "Log Out";
            this.btnLgOut.UseVisualStyleBackColor = false;
            this.btnLgOut.Click += new System.EventHandler(this.btnLgOut_Click);
            // 
            // picboxProfile
            // 
            this.picboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxProfile.Image = ((System.Drawing.Image)(resources.GetObject("picboxProfile.Image")));
            this.picboxProfile.Location = new System.Drawing.Point(59, 75);
            this.picboxProfile.Name = "picboxProfile";
            this.picboxProfile.Size = new System.Drawing.Size(271, 199);
            this.picboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxProfile.TabIndex = 2;
            this.picboxProfile.TabStop = false;
            // 
            // lblCalender
            // 
            this.lblCalender.AutoSize = true;
            this.lblCalender.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalender.Location = new System.Drawing.Point(12, 286);
            this.lblCalender.Name = "lblCalender";
            this.lblCalender.Size = new System.Drawing.Size(112, 25);
            this.lblCalender.TabIndex = 3;
            this.lblCalender.Text = "Calender:";
            // 
            // monthCalendarMenu
            // 
            this.monthCalendarMenu.Location = new System.Drawing.Point(59, 320);
            this.monthCalendarMenu.Name = "monthCalendarMenu";
            this.monthCalendarMenu.TabIndex = 4;
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbMenu.Controls.Add(this.btnUpdate);
            this.gbMenu.Controls.Add(this.btnRecommend);
            this.gbMenu.Controls.Add(this.btnPerformance);
            this.gbMenu.Controls.Add(this.btnPayment);
            this.gbMenu.Controls.Add(this.btnSchedule);
            this.gbMenu.Controls.Add(this.lblNavigate);
            this.gbMenu.Location = new System.Drawing.Point(437, -14);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(465, 550);
            this.gbMenu.TabIndex = 5;
            this.gbMenu.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(106, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRecommend
            // 
            this.btnRecommend.BackColor = System.Drawing.Color.White;
            this.btnRecommend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecommend.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecommend.Location = new System.Drawing.Point(106, 334);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(260, 43);
            this.btnRecommend.TabIndex = 10;
            this.btnRecommend.Text = "Player\'s Recommendation";
            this.btnRecommend.UseVisualStyleBackColor = false;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.BackColor = System.Drawing.Color.White;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerformance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPerformance.Location = new System.Drawing.Point(106, 245);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(260, 43);
            this.btnPerformance.TabIndex = 9;
            this.btnPerformance.Text = "Player\'s Performance";
            this.btnPerformance.UseVisualStyleBackColor = false;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayment.Location = new System.Drawing.Point(106, 158);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(260, 43);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Member\'s Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchedule.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSchedule.Location = new System.Drawing.Point(106, 73);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(260, 43);
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Text = "Training Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblNavigate
            // 
            this.lblNavigate.AutoSize = true;
            this.lblNavigate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigate.Location = new System.Drawing.Point(6, 23);
            this.lblNavigate.Name = "lblNavigate";
            this.lblNavigate.Size = new System.Drawing.Size(205, 19);
            this.lblNavigate.TabIndex = 6;
            this.lblNavigate.Text = "Where would you like to go?";
            // 
            // frmCoachMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.monthCalendarMenu);
            this.Controls.Add(this.lblCalender);
            this.Controls.Add(this.picboxProfile);
            this.Controls.Add(this.btnLgOut);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmCoachMenu";
            this.Text = "Coach Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).EndInit();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLgOut;
        private System.Windows.Forms.PictureBox picboxProfile;
        private System.Windows.Forms.Label lblCalender;
        private System.Windows.Forms.MonthCalendar monthCalendarMenu;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Label lblNavigate;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRecommend;
    }
}

