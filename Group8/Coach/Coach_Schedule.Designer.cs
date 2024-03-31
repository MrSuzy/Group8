namespace Group8
{
    partial class frmCoachSchedule
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
            this.lblSchedule = new System.Windows.Forms.Label();
            this.monthCalendarTraining = new System.Windows.Forms.MonthCalendar();
            this.gbSession = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(22, 26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 39);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSchedule.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(77, 95);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(233, 32);
            this.lblSchedule.TabIndex = 1;
            this.lblSchedule.Text = "Training Schedule";
            // 
            // monthCalendarTraining
            // 
            this.monthCalendarTraining.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendarTraining.Location = new System.Drawing.Point(82, 165);
            this.monthCalendarTraining.Name = "monthCalendarTraining";
            this.monthCalendarTraining.TabIndex = 2;
            this.monthCalendarTraining.TitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthCalendarTraining.TitleForeColor = System.Drawing.SystemColors.Control;
            // 
            // gbSession
            // 
            this.gbSession.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbSession.Controls.Add(this.btnDelete);
            this.gbSession.Controls.Add(this.btnView);
            this.gbSession.Controls.Add(this.btnEdit);
            this.gbSession.Controls.Add(this.btnNew);
            this.gbSession.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSession.Location = new System.Drawing.Point(413, 165);
            this.gbSession.Name = "gbSession";
            this.gbSession.Size = new System.Drawing.Size(412, 207);
            this.gbSession.TabIndex = 3;
            this.gbSession.TabStop = false;
            this.gbSession.Text = "Training Sessions";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(223, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Session";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Location = new System.Drawing.Point(47, 123);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(124, 37);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View Session";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(223, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Session";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(47, 44);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Session";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmCoachSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.gbSession);
            this.Controls.Add(this.monthCalendarTraining);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmCoachSchedule";
            this.Text = "Coach Schedule";
            this.gbSession.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.MonthCalendar monthCalendarTraining;
        private System.Windows.Forms.GroupBox gbSession;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
    }
}