namespace Group8
{
    partial class Performance_Record
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label gameLabel;
            System.Windows.Forms.Label k_dLabel;
            System.Windows.Forms.Label performance_scoreLabel;
            System.Windows.Forms.Label win_rateLabel;
            System.Windows.Forms.Label first_bloodsLabel;
            System.Windows.Forms.Label total_clutchesLabel;
            System.Windows.Forms.Label total_acesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Performance_Record));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.players_performanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.players_performanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.players_performanceDataGridView = new System.Windows.Forms.DataGridView();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.k_dTextBox = new System.Windows.Forms.TextBox();
            this.performance_scoreTextBox = new System.Windows.Forms.TextBox();
            this.win_rateTextBox = new System.Windows.Forms.TextBox();
            this.first_bloodsTextBox = new System.Windows.Forms.TextBox();
            this.total_clutchesTextBox = new System.Windows.Forms.TextBox();
            this.total_acesTextBox = new System.Windows.Forms.TextBox();
            this.players_performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSports_ClubDataSet = new Group8.eSports_ClubDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.players_performanceTableAdapter = new Group8.eSports_ClubDataSetTableAdapters.players_performanceTableAdapter();
            this.tableAdapterManager = new Group8.eSports_ClubDataSetTableAdapters.TableAdapterManager();
            user_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            gameLabel = new System.Windows.Forms.Label();
            k_dLabel = new System.Windows.Forms.Label();
            performance_scoreLabel = new System.Windows.Forms.Label();
            win_rateLabel = new System.Windows.Forms.Label();
            first_bloodsLabel = new System.Windows.Forms.Label();
            total_clutchesLabel = new System.Windows.Forms.Label();
            total_acesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceBindingNavigator)).BeginInit();
            this.players_performanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSports_ClubDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(231, 40);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(50, 16);
            user_idLabel.TabIndex = 29;
            user_idLabel.Text = "user id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(231, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "name:";
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Location = new System.Drawing.Point(231, 96);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new System.Drawing.Size(45, 16);
            gameLabel.TabIndex = 33;
            gameLabel.Text = "game:";
            // 
            // k_dLabel
            // 
            k_dLabel.AutoSize = true;
            k_dLabel.Location = new System.Drawing.Point(849, 33);
            k_dLabel.Name = "k_dLabel";
            k_dLabel.Size = new System.Drawing.Size(29, 16);
            k_dLabel.TabIndex = 35;
            k_dLabel.Text = "k/d:";
            // 
            // performance_scoreLabel
            // 
            performance_scoreLabel.AutoSize = true;
            performance_scoreLabel.Location = new System.Drawing.Point(849, 61);
            performance_scoreLabel.Name = "performance_scoreLabel";
            performance_scoreLabel.Size = new System.Drawing.Size(123, 16);
            performance_scoreLabel.TabIndex = 37;
            performance_scoreLabel.Text = "performance score:";
            // 
            // win_rateLabel
            // 
            win_rateLabel.AutoSize = true;
            win_rateLabel.Location = new System.Drawing.Point(849, 89);
            win_rateLabel.Name = "win_rateLabel";
            win_rateLabel.Size = new System.Drawing.Size(55, 16);
            win_rateLabel.TabIndex = 39;
            win_rateLabel.Text = "win rate:";
            // 
            // first_bloodsLabel
            // 
            first_bloodsLabel.AutoSize = true;
            first_bloodsLabel.Location = new System.Drawing.Point(849, 117);
            first_bloodsLabel.Name = "first_bloodsLabel";
            first_bloodsLabel.Size = new System.Drawing.Size(75, 16);
            first_bloodsLabel.TabIndex = 41;
            first_bloodsLabel.Text = "first bloods:";
            // 
            // total_clutchesLabel
            // 
            total_clutchesLabel.AutoSize = true;
            total_clutchesLabel.Location = new System.Drawing.Point(849, 145);
            total_clutchesLabel.Name = "total_clutchesLabel";
            total_clutchesLabel.Size = new System.Drawing.Size(87, 16);
            total_clutchesLabel.TabIndex = 43;
            total_clutchesLabel.Text = "total clutches:";
            // 
            // total_acesLabel
            // 
            total_acesLabel.AutoSize = true;
            total_acesLabel.Location = new System.Drawing.Point(849, 173);
            total_acesLabel.Name = "total_acesLabel";
            total_acesLabel.Size = new System.Drawing.Size(68, 16);
            total_acesLabel.TabIndex = 45;
            total_acesLabel.Text = "total aces:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Club Members Performance Record:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 113);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // players_performanceBindingNavigator
            // 
            this.players_performanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.players_performanceBindingNavigator.BindingSource = this.players_performanceBindingSource;
            this.players_performanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.players_performanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.players_performanceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.players_performanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.players_performanceBindingNavigatorSaveItem});
            this.players_performanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.players_performanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.players_performanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.players_performanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.players_performanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.players_performanceBindingNavigator.Name = "players_performanceBindingNavigator";
            this.players_performanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.players_performanceBindingNavigator.Size = new System.Drawing.Size(1137, 31);
            this.players_performanceBindingNavigator.TabIndex = 29;
            this.players_performanceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // players_performanceBindingNavigatorSaveItem
            // 
            this.players_performanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.players_performanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("players_performanceBindingNavigatorSaveItem.Image")));
            this.players_performanceBindingNavigatorSaveItem.Name = "players_performanceBindingNavigatorSaveItem";
            this.players_performanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.players_performanceBindingNavigatorSaveItem.Text = "Save Data";
            this.players_performanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.players_performanceBindingNavigatorSaveItem_Click);
            // 
            // players_performanceDataGridView
            // 
            this.players_performanceDataGridView.AutoGenerateColumns = false;
            this.players_performanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.players_performanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.players_performanceDataGridView.DataSource = this.players_performanceBindingSource;
            this.players_performanceDataGridView.Location = new System.Drawing.Point(94, 208);
            this.players_performanceDataGridView.Name = "players_performanceDataGridView";
            this.players_performanceDataGridView.RowHeadersWidth = 51;
            this.players_performanceDataGridView.RowTemplate.Height = 24;
            this.players_performanceDataGridView.Size = new System.Drawing.Size(984, 274);
            this.players_performanceDataGridView.TabIndex = 29;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "user_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(360, 37);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.user_idTextBox.TabIndex = 30;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(360, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 32;
            // 
            // gameTextBox
            // 
            this.gameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "game", true));
            this.gameTextBox.Location = new System.Drawing.Point(360, 93);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(100, 22);
            this.gameTextBox.TabIndex = 34;
            // 
            // k_dTextBox
            // 
            this.k_dTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "k/d", true));
            this.k_dTextBox.Location = new System.Drawing.Point(978, 30);
            this.k_dTextBox.Name = "k_dTextBox";
            this.k_dTextBox.Size = new System.Drawing.Size(100, 22);
            this.k_dTextBox.TabIndex = 36;
            // 
            // performance_scoreTextBox
            // 
            this.performance_scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "performance_score", true));
            this.performance_scoreTextBox.Location = new System.Drawing.Point(978, 58);
            this.performance_scoreTextBox.Name = "performance_scoreTextBox";
            this.performance_scoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.performance_scoreTextBox.TabIndex = 38;
            // 
            // win_rateTextBox
            // 
            this.win_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "win_rate", true));
            this.win_rateTextBox.Location = new System.Drawing.Point(978, 86);
            this.win_rateTextBox.Name = "win_rateTextBox";
            this.win_rateTextBox.Size = new System.Drawing.Size(100, 22);
            this.win_rateTextBox.TabIndex = 40;
            // 
            // first_bloodsTextBox
            // 
            this.first_bloodsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "first_bloods", true));
            this.first_bloodsTextBox.Location = new System.Drawing.Point(978, 114);
            this.first_bloodsTextBox.Name = "first_bloodsTextBox";
            this.first_bloodsTextBox.Size = new System.Drawing.Size(100, 22);
            this.first_bloodsTextBox.TabIndex = 42;
            // 
            // total_clutchesTextBox
            // 
            this.total_clutchesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "total_clutches", true));
            this.total_clutchesTextBox.Location = new System.Drawing.Point(978, 142);
            this.total_clutchesTextBox.Name = "total_clutchesTextBox";
            this.total_clutchesTextBox.Size = new System.Drawing.Size(100, 22);
            this.total_clutchesTextBox.TabIndex = 44;
            // 
            // total_acesTextBox
            // 
            this.total_acesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.players_performanceBindingSource, "total_aces", true));
            this.total_acesTextBox.Location = new System.Drawing.Point(978, 170);
            this.total_acesTextBox.Name = "total_acesTextBox";
            this.total_acesTextBox.Size = new System.Drawing.Size(100, 22);
            this.total_acesTextBox.TabIndex = 46;
            // 
            // players_performanceBindingSource
            // 
            this.players_performanceBindingSource.DataMember = "players_performance";
            this.players_performanceBindingSource.DataSource = this.eSports_ClubDataSet;
            // 
            // eSports_ClubDataSet
            // 
            this.eSports_ClubDataSet.DataSetName = "eSports_ClubDataSet";
            this.eSports_ClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "game";
            this.dataGridViewTextBoxColumn3.HeaderText = "game";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "k/d";
            this.dataGridViewTextBoxColumn4.HeaderText = "k/d";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "performance_score";
            this.dataGridViewTextBoxColumn5.HeaderText = "performance_score";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "win_rate";
            this.dataGridViewTextBoxColumn6.HeaderText = "win_rate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "first_bloods";
            this.dataGridViewTextBoxColumn7.HeaderText = "first_bloods";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "total_clutches";
            this.dataGridViewTextBoxColumn8.HeaderText = "total_clutches";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "total_aces";
            this.dataGridViewTextBoxColumn9.HeaderText = "total_aces";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // players_performanceTableAdapter
            // 
            this.players_performanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.competitionsTableAdapter = null;
            this.tableAdapterManager.feedbacksTableAdapter = null;
            this.tableAdapterManager.members_paymentTableAdapter = null;
            this.tableAdapterManager.monthly_salaryTableAdapter = null;
            this.tableAdapterManager.players_performanceTableAdapter = this.players_performanceTableAdapter;
            this.tableAdapterManager.training_scheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Group8.eSports_ClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_infoTableAdapter = null;
            // 
            // Performance_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1137, 554);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(gameLabel);
            this.Controls.Add(this.gameTextBox);
            this.Controls.Add(k_dLabel);
            this.Controls.Add(this.k_dTextBox);
            this.Controls.Add(performance_scoreLabel);
            this.Controls.Add(this.performance_scoreTextBox);
            this.Controls.Add(win_rateLabel);
            this.Controls.Add(this.win_rateTextBox);
            this.Controls.Add(first_bloodsLabel);
            this.Controls.Add(this.first_bloodsTextBox);
            this.Controls.Add(total_clutchesLabel);
            this.Controls.Add(this.total_clutchesTextBox);
            this.Controls.Add(total_acesLabel);
            this.Controls.Add(this.total_acesTextBox);
            this.Controls.Add(this.players_performanceDataGridView);
            this.Controls.Add(this.players_performanceBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Performance_Record";
            this.Text = "Performance_Record";
            this.Load += new System.EventHandler(this.Performance_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceBindingNavigator)).EndInit();
            this.players_performanceBindingNavigator.ResumeLayout(false);
            this.players_performanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.players_performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSports_ClubDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private eSports_ClubDataSet eSports_ClubDataSet;
        private System.Windows.Forms.BindingSource players_performanceBindingSource;
        private eSports_ClubDataSetTableAdapters.players_performanceTableAdapter players_performanceTableAdapter;
        private eSports_ClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator players_performanceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton players_performanceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView players_performanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.TextBox k_dTextBox;
        private System.Windows.Forms.TextBox performance_scoreTextBox;
        private System.Windows.Forms.TextBox win_rateTextBox;
        private System.Windows.Forms.TextBox first_bloodsTextBox;
        private System.Windows.Forms.TextBox total_clutchesTextBox;
        private System.Windows.Forms.TextBox total_acesTextBox;
    }
}