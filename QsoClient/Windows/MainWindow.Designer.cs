namespace QsoClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disenWardsCheckbox = new System.Windows.Forms.CheckBox();
            this.disenSkinsCheckbox = new System.Windows.Forms.CheckBox();
            this.disenChampionsCheckbox = new System.Windows.Forms.CheckBox();
            this.disenchantAllBtn = new System.Windows.Forms.Button();
            this.craftManyBtn = new System.Windows.Forms.Button();
            this.craftBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateLootBtn = new System.Windows.Forms.Button();
            this.allLootCombo = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.autoAcceptQueueCheckbox = new System.Windows.Forms.CheckBox();
            this.downloadAllReplaysCheckbox = new System.Windows.Forms.CheckBox();
            this.alertWhenManyReplaysCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contentFilterTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.createLobbyBtn = new System.Windows.Forms.Button();
            this.lobbyNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gameModeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameTypeCombo = new System.Windows.Forms.ComboBox();
            this.teamSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.mapCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botChampionCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.botTeamCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botDifficultyCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addBotBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queueTypesCombo = new System.Windows.Forms.ComboBox();
            this.queueBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inviteSummonerTextbox = new System.Windows.Forms.TextBox();
            this.inviteSummonerBtn = new System.Windows.Forms.Button();
            this.forceStartLobbyBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.forceLeaveLobbyBtn = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamSizeUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Qso Client";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.craftManyBtn);
            this.tabPage3.Controls.Add(this.craftBtn);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.recipesCombo);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.updateLootBtn);
            this.tabPage3.Controls.Add(this.allLootCombo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loot Manager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disenWardsCheckbox);
            this.groupBox1.Controls.Add(this.disenSkinsCheckbox);
            this.groupBox1.Controls.Add(this.disenChampionsCheckbox);
            this.groupBox1.Controls.Add(this.disenchantAllBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mass Disenchant";
            // 
            // disenWardsCheckbox
            // 
            this.disenWardsCheckbox.AutoSize = true;
            this.disenWardsCheckbox.Enabled = false;
            this.disenWardsCheckbox.Location = new System.Drawing.Point(6, 65);
            this.disenWardsCheckbox.Name = "disenWardsCheckbox";
            this.disenWardsCheckbox.Size = new System.Drawing.Size(57, 17);
            this.disenWardsCheckbox.TabIndex = 10;
            this.disenWardsCheckbox.Text = "Wards";
            this.disenWardsCheckbox.UseVisualStyleBackColor = true;
            // 
            // disenSkinsCheckbox
            // 
            this.disenSkinsCheckbox.AutoSize = true;
            this.disenSkinsCheckbox.Location = new System.Drawing.Point(6, 42);
            this.disenSkinsCheckbox.Name = "disenSkinsCheckbox";
            this.disenSkinsCheckbox.Size = new System.Drawing.Size(52, 17);
            this.disenSkinsCheckbox.TabIndex = 9;
            this.disenSkinsCheckbox.Text = "Skins";
            this.disenSkinsCheckbox.UseVisualStyleBackColor = true;
            // 
            // disenChampionsCheckbox
            // 
            this.disenChampionsCheckbox.AutoSize = true;
            this.disenChampionsCheckbox.Location = new System.Drawing.Point(6, 19);
            this.disenChampionsCheckbox.Name = "disenChampionsCheckbox";
            this.disenChampionsCheckbox.Size = new System.Drawing.Size(78, 17);
            this.disenChampionsCheckbox.TabIndex = 8;
            this.disenChampionsCheckbox.Text = "Champions";
            this.disenChampionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // disenchantAllBtn
            // 
            this.disenchantAllBtn.Location = new System.Drawing.Point(217, 69);
            this.disenchantAllBtn.Name = "disenchantAllBtn";
            this.disenchantAllBtn.Size = new System.Drawing.Size(75, 23);
            this.disenchantAllBtn.TabIndex = 7;
            this.disenchantAllBtn.Text = "Disenchant";
            this.disenchantAllBtn.UseVisualStyleBackColor = true;
            this.disenchantAllBtn.Click += new System.EventHandler(this.disenchantAllBtn_Click);
            // 
            // craftManyBtn
            // 
            this.craftManyBtn.Location = new System.Drawing.Point(495, 61);
            this.craftManyBtn.Name = "craftManyBtn";
            this.craftManyBtn.Size = new System.Drawing.Size(75, 23);
            this.craftManyBtn.TabIndex = 6;
            this.craftManyBtn.Text = "Craft 10";
            this.craftManyBtn.UseVisualStyleBackColor = true;
            this.craftManyBtn.Click += new System.EventHandler(this.craftManyBtn_Click);
            // 
            // craftBtn
            // 
            this.craftBtn.Location = new System.Drawing.Point(414, 61);
            this.craftBtn.Name = "craftBtn";
            this.craftBtn.Size = new System.Drawing.Size(75, 23);
            this.craftBtn.TabIndex = 5;
            this.craftBtn.Text = "Craft";
            this.craftBtn.UseVisualStyleBackColor = true;
            this.craftBtn.Click += new System.EventHandler(this.craftBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recipes";
            // 
            // recipesCombo
            // 
            this.recipesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipesCombo.FormattingEnabled = true;
            this.recipesCombo.Location = new System.Drawing.Point(60, 34);
            this.recipesCombo.Name = "recipesCombo";
            this.recipesCombo.Size = new System.Drawing.Size(510, 21);
            this.recipesCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loot Item";
            // 
            // updateLootBtn
            // 
            this.updateLootBtn.Location = new System.Drawing.Point(60, 61);
            this.updateLootBtn.Name = "updateLootBtn";
            this.updateLootBtn.Size = new System.Drawing.Size(75, 23);
            this.updateLootBtn.TabIndex = 1;
            this.updateLootBtn.Text = "Update Loot";
            this.updateLootBtn.UseVisualStyleBackColor = true;
            this.updateLootBtn.Click += new System.EventHandler(this.updateLootBtn_Click);
            // 
            // allLootCombo
            // 
            this.allLootCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allLootCombo.FormattingEnabled = true;
            this.allLootCombo.Location = new System.Drawing.Point(60, 7);
            this.allLootCombo.Name = "allLootCombo";
            this.allLootCombo.Size = new System.Drawing.Size(510, 21);
            this.allLootCombo.TabIndex = 0;
            this.allLootCombo.SelectedIndexChanged += new System.EventHandler(this.allLootCombo_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.autoAcceptQueueCheckbox);
            this.tabPage1.Controls.Add(this.downloadAllReplaysCheckbox);
            this.tabPage1.Controls.Add(this.alertWhenManyReplaysCheckbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // autoAcceptQueueCheckbox
            // 
            this.autoAcceptQueueCheckbox.AutoSize = true;
            this.autoAcceptQueueCheckbox.Location = new System.Drawing.Point(8, 52);
            this.autoAcceptQueueCheckbox.Name = "autoAcceptQueueCheckbox";
            this.autoAcceptQueueCheckbox.Size = new System.Drawing.Size(222, 17);
            this.autoAcceptQueueCheckbox.TabIndex = 12;
            this.autoAcceptQueueCheckbox.Text = "Automatically accept queue ready check.";
            this.autoAcceptQueueCheckbox.UseVisualStyleBackColor = true;
            // 
            // downloadAllReplaysCheckbox
            // 
            this.downloadAllReplaysCheckbox.AutoSize = true;
            this.downloadAllReplaysCheckbox.Location = new System.Drawing.Point(8, 6);
            this.downloadAllReplaysCheckbox.Name = "downloadAllReplaysCheckbox";
            this.downloadAllReplaysCheckbox.Size = new System.Drawing.Size(189, 17);
            this.downloadAllReplaysCheckbox.TabIndex = 10;
            this.downloadAllReplaysCheckbox.Text = "Download replays for every game?";
            this.downloadAllReplaysCheckbox.UseVisualStyleBackColor = true;
            // 
            // alertWhenManyReplaysCheckbox
            // 
            this.alertWhenManyReplaysCheckbox.AutoSize = true;
            this.alertWhenManyReplaysCheckbox.Location = new System.Drawing.Point(26, 29);
            this.alertWhenManyReplaysCheckbox.Name = "alertWhenManyReplaysCheckbox";
            this.alertWhenManyReplaysCheckbox.Size = new System.Drawing.Size(236, 17);
            this.alertWhenManyReplaysCheckbox.TabIndex = 11;
            this.alertWhenManyReplaysCheckbox.Text = "Alert me when the replay folder gets very full.";
            this.alertWhenManyReplaysCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contentFilterTextbox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 285);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Content Targeting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contentFilterTextbox
            // 
            this.contentFilterTextbox.Location = new System.Drawing.Point(6, 26);
            this.contentFilterTextbox.Multiline = true;
            this.contentFilterTextbox.Name = "contentFilterTextbox";
            this.contentFilterTextbox.ReadOnly = true;
            this.contentFilterTextbox.Size = new System.Drawing.Size(347, 253);
            this.contentFilterTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Riot filters content for you based on these filters:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.mapCombo);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.teamSizeUpDown);
            this.tabPage4.Controls.Add(this.gameTypeCombo);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.gameModeCombo);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.lobbyNameTextbox);
            this.tabPage4.Controls.Add(this.createLobbyBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(576, 285);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Lobby Creator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // createLobbyBtn
            // 
            this.createLobbyBtn.Location = new System.Drawing.Point(495, 87);
            this.createLobbyBtn.Name = "createLobbyBtn";
            this.createLobbyBtn.Size = new System.Drawing.Size(75, 23);
            this.createLobbyBtn.TabIndex = 0;
            this.createLobbyBtn.Text = "Create";
            this.createLobbyBtn.UseVisualStyleBackColor = true;
            this.createLobbyBtn.Click += new System.EventHandler(this.createLobbyBtn_Click);
            // 
            // lobbyNameTextbox
            // 
            this.lobbyNameTextbox.Location = new System.Drawing.Point(79, 7);
            this.lobbyNameTextbox.Name = "lobbyNameTextbox";
            this.lobbyNameTextbox.Size = new System.Drawing.Size(491, 20);
            this.lobbyNameTextbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lobby Name";
            // 
            // gameModeCombo
            // 
            this.gameModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeCombo.FormattingEnabled = true;
            this.gameModeCombo.Items.AddRange(new object[] {
            "ARAM",
            "CLASSIC",
            "TUTORIAL",
            "URF",
            "PRACTICETOOL"});
            this.gameModeCombo.Location = new System.Drawing.Point(79, 33);
            this.gameModeCombo.Name = "gameModeCombo";
            this.gameModeCombo.Size = new System.Drawing.Size(206, 21);
            this.gameModeCombo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Game Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Type";
            // 
            // gameTypeCombo
            // 
            this.gameTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameTypeCombo.FormattingEnabled = true;
            this.gameTypeCombo.Location = new System.Drawing.Point(359, 33);
            this.gameTypeCombo.Name = "gameTypeCombo";
            this.gameTypeCombo.Size = new System.Drawing.Size(211, 21);
            this.gameTypeCombo.TabIndex = 6;
            // 
            // teamSizeUpDown
            // 
            this.teamSizeUpDown.Location = new System.Drawing.Point(359, 61);
            this.teamSizeUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.teamSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.teamSizeUpDown.Name = "teamSizeUpDown";
            this.teamSizeUpDown.Size = new System.Drawing.Size(211, 20);
            this.teamSizeUpDown.TabIndex = 7;
            this.teamSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Team Size";
            // 
            // mapCombo
            // 
            this.mapCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapCombo.FormattingEnabled = true;
            this.mapCombo.Location = new System.Drawing.Point(79, 60);
            this.mapCombo.Name = "mapCombo";
            this.mapCombo.Size = new System.Drawing.Size(206, 21);
            this.mapCombo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Map";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addBotBtn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.botDifficultyCombo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.botTeamCombo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.botChampionCombo);
            this.groupBox2.Location = new System.Drawing.Point(6, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bots";
            // 
            // botChampionCombo
            // 
            this.botChampionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botChampionCombo.FormattingEnabled = true;
            this.botChampionCombo.Location = new System.Drawing.Point(66, 13);
            this.botChampionCombo.Name = "botChampionCombo";
            this.botChampionCombo.Size = new System.Drawing.Size(178, 21);
            this.botChampionCombo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Champion";
            // 
            // botTeamCombo
            // 
            this.botTeamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botTeamCombo.FormattingEnabled = true;
            this.botTeamCombo.Location = new System.Drawing.Point(66, 40);
            this.botTeamCombo.Name = "botTeamCombo";
            this.botTeamCombo.Size = new System.Drawing.Size(178, 21);
            this.botTeamCombo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Team";
            // 
            // botDifficultyCombo
            // 
            this.botDifficultyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botDifficultyCombo.FormattingEnabled = true;
            this.botDifficultyCombo.Items.AddRange(new object[] {
            "EASY",
            "MEDIUM",
            "HARD",
            "UBER",
            "TUTORIAL",
            "INTRO"});
            this.botDifficultyCombo.Location = new System.Drawing.Point(66, 67);
            this.botDifficultyCombo.Name = "botDifficultyCombo";
            this.botDifficultyCombo.Size = new System.Drawing.Size(178, 21);
            this.botDifficultyCombo.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Difficulty";
            // 
            // addBotBtn
            // 
            this.addBotBtn.Location = new System.Drawing.Point(250, 13);
            this.addBotBtn.Name = "addBotBtn";
            this.addBotBtn.Size = new System.Drawing.Size(75, 75);
            this.addBotBtn.TabIndex = 17;
            this.addBotBtn.Text = "Add";
            this.addBotBtn.UseVisualStyleBackColor = true;
            this.addBotBtn.Click += new System.EventHandler(this.addBotBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queueBtn);
            this.groupBox3.Controls.Add(this.queueTypesCombo);
            this.groupBox3.Location = new System.Drawing.Point(343, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 96);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Queues";
            // 
            // queueTypesCombo
            // 
            this.queueTypesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queueTypesCombo.FormattingEnabled = true;
            this.queueTypesCombo.Location = new System.Drawing.Point(6, 13);
            this.queueTypesCombo.Name = "queueTypesCombo";
            this.queueTypesCombo.Size = new System.Drawing.Size(215, 21);
            this.queueTypesCombo.TabIndex = 0;
            // 
            // queueBtn
            // 
            this.queueBtn.Location = new System.Drawing.Point(146, 40);
            this.queueBtn.Name = "queueBtn";
            this.queueBtn.Size = new System.Drawing.Size(75, 23);
            this.queueBtn.TabIndex = 1;
            this.queueBtn.Text = "Queue";
            this.queueBtn.UseVisualStyleBackColor = true;
            this.queueBtn.Click += new System.EventHandler(this.queueBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inviteSummonerBtn);
            this.groupBox4.Controls.Add(this.inviteSummonerTextbox);
            this.groupBox4.Location = new System.Drawing.Point(6, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 78);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invite";
            // 
            // inviteSummonerTextbox
            // 
            this.inviteSummonerTextbox.Location = new System.Drawing.Point(6, 19);
            this.inviteSummonerTextbox.Name = "inviteSummonerTextbox";
            this.inviteSummonerTextbox.Size = new System.Drawing.Size(209, 20);
            this.inviteSummonerTextbox.TabIndex = 0;
            // 
            // inviteSummonerBtn
            // 
            this.inviteSummonerBtn.Location = new System.Drawing.Point(140, 45);
            this.inviteSummonerBtn.Name = "inviteSummonerBtn";
            this.inviteSummonerBtn.Size = new System.Drawing.Size(75, 23);
            this.inviteSummonerBtn.TabIndex = 1;
            this.inviteSummonerBtn.Text = "Invite";
            this.inviteSummonerBtn.UseVisualStyleBackColor = true;
            this.inviteSummonerBtn.Click += new System.EventHandler(this.inviteSummonerBtn_Click);
            // 
            // forceStartLobbyBtn
            // 
            this.forceStartLobbyBtn.Location = new System.Drawing.Point(6, 16);
            this.forceStartLobbyBtn.Name = "forceStartLobbyBtn";
            this.forceStartLobbyBtn.Size = new System.Drawing.Size(91, 23);
            this.forceStartLobbyBtn.TabIndex = 20;
            this.forceStartLobbyBtn.Text = "Start Lobby";
            this.forceStartLobbyBtn.UseVisualStyleBackColor = true;
            this.forceStartLobbyBtn.Click += new System.EventHandler(this.forceStartLobbyBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.forceLeaveLobbyBtn);
            this.groupBox5.Controls.Add(this.forceStartLobbyBtn);
            this.groupBox5.Location = new System.Drawing.Point(234, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 78);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Force";
            // 
            // forceLeaveLobbyBtn
            // 
            this.forceLeaveLobbyBtn.Location = new System.Drawing.Point(7, 49);
            this.forceLeaveLobbyBtn.Name = "forceLeaveLobbyBtn";
            this.forceLeaveLobbyBtn.Size = new System.Drawing.Size(90, 23);
            this.forceLeaveLobbyBtn.TabIndex = 21;
            this.forceLeaveLobbyBtn.Text = "Leave Lobby";
            this.forceLeaveLobbyBtn.UseVisualStyleBackColor = true;
            this.forceLeaveLobbyBtn.Click += new System.EventHandler(this.forceLeaveLobbyBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Qso Client";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamSizeUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox disenWardsCheckbox;
        private System.Windows.Forms.CheckBox disenSkinsCheckbox;
        private System.Windows.Forms.CheckBox disenChampionsCheckbox;
        private System.Windows.Forms.Button disenchantAllBtn;
        private System.Windows.Forms.Button craftManyBtn;
        private System.Windows.Forms.Button craftBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recipesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateLootBtn;
        private System.Windows.Forms.ComboBox allLootCombo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox autoAcceptQueueCheckbox;
        private System.Windows.Forms.CheckBox downloadAllReplaysCheckbox;
        private System.Windows.Forms.CheckBox alertWhenManyReplaysCheckbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox contentFilterTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button createLobbyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lobbyNameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gameModeCombo;
        private System.Windows.Forms.ComboBox gameTypeCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown teamSizeUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox mapCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox botDifficultyCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox botTeamCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox botChampionCombo;
        private System.Windows.Forms.Button addBotBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button queueBtn;
        private System.Windows.Forms.ComboBox queueTypesCombo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button inviteSummonerBtn;
        private System.Windows.Forms.TextBox inviteSummonerTextbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button forceLeaveLobbyBtn;
        private System.Windows.Forms.Button forceStartLobbyBtn;
    }
}

