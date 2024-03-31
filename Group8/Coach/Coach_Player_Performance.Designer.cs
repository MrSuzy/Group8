namespace Group8
{
    partial class frmPlayerPerformance
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
            this.lblPlayerPerformance = new System.Windows.Forms.Label();
            this.gbPerfomance = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAce = new System.Windows.Forms.TextBox();
            this.txtClutch = new System.Windows.Forms.TextBox();
            this.lblAces = new System.Windows.Forms.Label();
            this.lblClutches = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtKD = new System.Windows.Forms.TextBox();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblKD = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbPerfomance.SuspendLayout();
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
            this.btnMenu.Size = new System.Drawing.Size(152, 39);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblPlayerPerformance
            // 
            this.lblPlayerPerformance.AutoSize = true;
            this.lblPlayerPerformance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPerformance.Location = new System.Drawing.Point(57, 77);
            this.lblPlayerPerformance.Name = "lblPlayerPerformance";
            this.lblPlayerPerformance.Size = new System.Drawing.Size(555, 22);
            this.lblPlayerPerformance.TabIndex = 5;
            this.lblPlayerPerformance.Text = "To record player\'s game performance, kindly enter the details below:";
            // 
            // gbPerfomance
            // 
            this.gbPerfomance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbPerfomance.Controls.Add(this.txtID);
            this.gbPerfomance.Controls.Add(this.lblID);
            this.gbPerfomance.Controls.Add(this.txtAce);
            this.gbPerfomance.Controls.Add(this.txtClutch);
            this.gbPerfomance.Controls.Add(this.lblAces);
            this.gbPerfomance.Controls.Add(this.lblClutches);
            this.gbPerfomance.Controls.Add(this.txtFirst);
            this.gbPerfomance.Controls.Add(this.lblFirst);
            this.gbPerfomance.Controls.Add(this.txtWin);
            this.gbPerfomance.Controls.Add(this.lblWin);
            this.gbPerfomance.Controls.Add(this.btnClear);
            this.gbPerfomance.Controls.Add(this.btnConfirm);
            this.gbPerfomance.Controls.Add(this.txtScore);
            this.gbPerfomance.Controls.Add(this.txtKD);
            this.gbPerfomance.Controls.Add(this.cbGame);
            this.gbPerfomance.Controls.Add(this.txtName);
            this.gbPerfomance.Controls.Add(this.lblScore);
            this.gbPerfomance.Controls.Add(this.lblKD);
            this.gbPerfomance.Controls.Add(this.lblGame);
            this.gbPerfomance.Controls.Add(this.lblName);
            this.gbPerfomance.Location = new System.Drawing.Point(61, 102);
            this.gbPerfomance.Name = "gbPerfomance";
            this.gbPerfomance.Size = new System.Drawing.Size(725, 421);
            this.gbPerfomance.TabIndex = 6;
            this.gbPerfomance.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(179, 126);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 25);
            this.txtID.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(57, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 17);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "User ID:";
            // 
            // txtAce
            // 
            this.txtAce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAce.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAce.Location = new System.Drawing.Point(492, 282);
            this.txtAce.Name = "txtAce";
            this.txtAce.Size = new System.Drawing.Size(118, 25);
            this.txtAce.TabIndex = 20;
            // 
            // txtClutch
            // 
            this.txtClutch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClutch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClutch.Location = new System.Drawing.Point(179, 282);
            this.txtClutch.Name = "txtClutch";
            this.txtClutch.Size = new System.Drawing.Size(118, 25);
            this.txtClutch.TabIndex = 19;
            // 
            // lblAces
            // 
            this.lblAces.AutoSize = true;
            this.lblAces.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAces.Location = new System.Drawing.Point(339, 283);
            this.lblAces.Name = "lblAces";
            this.lblAces.Size = new System.Drawing.Size(82, 17);
            this.lblAces.TabIndex = 18;
            this.lblAces.Text = "Total Aces:";
            // 
            // lblClutches
            // 
            this.lblClutches.AutoSize = true;
            this.lblClutches.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClutches.Location = new System.Drawing.Point(56, 283);
            this.lblClutches.Name = "lblClutches";
            this.lblClutches.Size = new System.Drawing.Size(108, 17);
            this.lblClutches.TabIndex = 17;
            this.lblClutches.Text = "Total Clutches:";
            // 
            // txtFirst
            // 
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(492, 231);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(118, 25);
            this.txtFirst.TabIndex = 16;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(339, 232);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(94, 17);
            this.lblFirst.TabIndex = 15;
            this.lblFirst.Text = "First Bloods:";
            // 
            // txtWin
            // 
            this.txtWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(179, 231);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(118, 25);
            this.txtWin.TabIndex = 14;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(56, 232);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(74, 17);
            this.lblWin.TabIndex = 13;
            this.lblWin.Text = "Win Rate:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(374, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(250, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 32);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(492, 180);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(118, 25);
            this.txtScore.TabIndex = 10;
            // 
            // txtKD
            // 
            this.txtKD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKD.Location = new System.Drawing.Point(179, 180);
            this.txtKD.Name = "txtKD";
            this.txtKD.Size = new System.Drawing.Size(118, 25);
            this.txtKD.TabIndex = 9;
            // 
            // cbGame
            // 
            this.cbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "League of Legends",
            "Valorant",
            "CS:GO"});
            this.cbGame.Location = new System.Drawing.Point(492, 125);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(118, 25);
            this.cbGame.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(179, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 25);
            this.txtName.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(339, 181);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(137, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Performance Score:";
            // 
            // lblKD
            // 
            this.lblKD.AutoSize = true;
            this.lblKD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKD.Location = new System.Drawing.Point(56, 181);
            this.lblKD.Name = "lblKD";
            this.lblKD.Size = new System.Drawing.Size(40, 17);
            this.lblKD.TabIndex = 3;
            this.lblKD.Text = "K/D:";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(339, 127);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(51, 17);
            this.lblGame.TabIndex = 1;
            this.lblGame.Text = "Game:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player\'s Name:";
            // 
            // frmPlayerPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.gbPerfomance);
            this.Controls.Add(this.lblPlayerPerformance);
            this.Controls.Add(this.btnMenu);
            this.Name = "frmPlayerPerformance";
            this.Text = "Player Performance";
            this.gbPerfomance.ResumeLayout(false);
            this.gbPerfomance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPlayerPerformance;
        private System.Windows.Forms.GroupBox gbPerfomance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtKD;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblKD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtAce;
        private System.Windows.Forms.TextBox txtClutch;
        private System.Windows.Forms.Label lblAces;
        private System.Windows.Forms.Label lblClutches;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}