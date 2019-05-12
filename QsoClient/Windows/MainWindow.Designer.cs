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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.autoAcceptQueueCheckbox = new System.Windows.Forms.CheckBox();
            this.downloadAllReplaysCheckbox = new System.Windows.Forms.CheckBox();
            this.alertWhenManyReplaysCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.autoqueueQueuesCombo = new System.Windows.Forms.ComboBox();
            this.autoqueueQueueBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.craftBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateLootBtn = new System.Windows.Forms.Button();
            this.allLootCombo = new System.Windows.Forms.ComboBox();
            this.craftManyBtn = new System.Windows.Forms.Button();
            this.disenchantAllBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disenChampionsCheckbox = new System.Windows.Forms.CheckBox();
            this.disenSkinsCheckbox = new System.Windows.Forms.CheckBox();
            this.disenWardsCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Qso Client";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 311);
            this.tabControl1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.autoqueueQueuesCombo);
            this.tabPage2.Controls.Add(this.autoqueueQueueBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto-queuer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // autoqueueQueuesCombo
            // 
            this.autoqueueQueuesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoqueueQueuesCombo.FormattingEnabled = true;
            this.autoqueueQueuesCombo.Location = new System.Drawing.Point(6, 6);
            this.autoqueueQueuesCombo.Name = "autoqueueQueuesCombo";
            this.autoqueueQueuesCombo.Size = new System.Drawing.Size(169, 21);
            this.autoqueueQueuesCombo.TabIndex = 1;
            // 
            // autoqueueQueueBtn
            // 
            this.autoqueueQueueBtn.Location = new System.Drawing.Point(68, 229);
            this.autoqueueQueueBtn.Name = "autoqueueQueueBtn";
            this.autoqueueQueueBtn.Size = new System.Drawing.Size(120, 50);
            this.autoqueueQueueBtn.TabIndex = 0;
            this.autoqueueQueueBtn.Text = "Queue";
            this.autoqueueQueueBtn.UseVisualStyleBackColor = true;
            this.autoqueueQueueBtn.Click += new System.EventHandler(this.autoqueueQueueBtn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disenWardsCheckbox);
            this.groupBox1.Controls.Add(this.disenSkinsCheckbox);
            this.groupBox1.Controls.Add(this.disenChampionsCheckbox);
            this.groupBox1.Controls.Add(this.disenchantAllBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mass Disenchant";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Qso Client";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox downloadAllReplaysCheckbox;
        private System.Windows.Forms.CheckBox alertWhenManyReplaysCheckbox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button autoqueueQueueBtn;
        private System.Windows.Forms.ComboBox autoqueueQueuesCombo;
        private System.Windows.Forms.CheckBox autoAcceptQueueCheckbox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button updateLootBtn;
        private System.Windows.Forms.ComboBox allLootCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recipesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button craftBtn;
        private System.Windows.Forms.Button craftManyBtn;
        private System.Windows.Forms.Button disenchantAllBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox disenWardsCheckbox;
        private System.Windows.Forms.CheckBox disenSkinsCheckbox;
        private System.Windows.Forms.CheckBox disenChampionsCheckbox;
    }
}

