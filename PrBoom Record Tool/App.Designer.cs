
namespace PrBoomRecordTool
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.openPrBoomDialog = new System.Windows.Forms.OpenFileDialog();
            this.recordDemoButton = new System.Windows.Forms.Button();
            this.locatePrBoomButton = new System.Windows.Forms.Button();
            this.prBoomPathLabel = new System.Windows.Forms.Label();
            this.iwadPathLabel = new System.Windows.Forms.Label();
            this.locateIwadButton = new System.Windows.Forms.Button();
            this.openIwadDialog = new System.Windows.Forms.OpenFileDialog();
            this.episodeInput = new System.Windows.Forms.NumericUpDown();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.NumericUpDown();
            this.demoNameLabel = new System.Windows.Forms.Label();
            this.complevelLabel = new System.Windows.Forms.Label();
            this.complevelInput = new System.Windows.Forms.NumericUpDown();
            this.demoNameInput = new System.Windows.Forms.TextBox();
            this.skillSelect = new System.Windows.Forms.ComboBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.isEpisodeActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.playDemoButton = new System.Windows.Forms.Button();
            this.noMonstersCheckbox = new System.Windows.Forms.CheckBox();
            this.fastMonstersCheckbox = new System.Windows.Forms.CheckBox();
            this.saveDemoDialog = new System.Windows.Forms.SaveFileDialog();
            this.setDemoPathButton = new System.Windows.Forms.Button();
            this.respawnCheckbox = new System.Windows.Forms.CheckBox();
            this.locatePwadsButton = new System.Windows.Forms.Button();
            this.unloadPwadsButton = new System.Windows.Forms.Button();
            this.pwadListView = new System.Windows.Forms.ListView();
            this.openPwadDialog = new System.Windows.Forms.OpenFileDialog();
            this.aboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.episodeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complevelInput)).BeginInit();
            this.SuspendLayout();
            // 
            // openPrBoomDialog
            // 
            this.openPrBoomDialog.Filter = "PrBoom+|prboom-plus.exe|PrBoom|prboom.exe|Executable|*.exe";
            this.openPrBoomDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenPrBoomDialogFileLoaded);
            // 
            // recordDemoButton
            // 
            this.recordDemoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordDemoButton.Location = new System.Drawing.Point(11, 386);
            this.recordDemoButton.Name = "recordDemoButton";
            this.recordDemoButton.Size = new System.Drawing.Size(144, 53);
            this.recordDemoButton.TabIndex = 0;
            this.recordDemoButton.Text = "Record demo";
            this.recordDemoButton.UseVisualStyleBackColor = true;
            this.recordDemoButton.Click += new System.EventHandler(this.RecordDemoButtonOnClick);
            // 
            // locatePrBoomButton
            // 
            this.locatePrBoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatePrBoomButton.Location = new System.Drawing.Point(12, 12);
            this.locatePrBoomButton.Name = "locatePrBoomButton";
            this.locatePrBoomButton.Size = new System.Drawing.Size(236, 31);
            this.locatePrBoomButton.TabIndex = 1;
            this.locatePrBoomButton.Text = "Locate sourceport";
            this.locatePrBoomButton.UseVisualStyleBackColor = true;
            this.locatePrBoomButton.Click += new System.EventHandler(this.LocatePrBoomButtonOnClick);
            // 
            // prBoomPathLabel
            // 
            this.prBoomPathLabel.AutoSize = true;
            this.prBoomPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prBoomPathLabel.Location = new System.Drawing.Point(13, 46);
            this.prBoomPathLabel.Name = "prBoomPathLabel";
            this.prBoomPathLabel.Size = new System.Drawing.Size(193, 18);
            this.prBoomPathLabel.TabIndex = 2;
            this.prBoomPathLabel.Text = "Sourceport is not yet loaded";
            // 
            // iwadPathLabel
            // 
            this.iwadPathLabel.AutoSize = true;
            this.iwadPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iwadPathLabel.Location = new System.Drawing.Point(287, 46);
            this.iwadPathLabel.Name = "iwadPathLabel";
            this.iwadPathLabel.Size = new System.Drawing.Size(157, 18);
            this.iwadPathLabel.TabIndex = 4;
            this.iwadPathLabel.Text = "IWAD is not yet loaded";
            // 
            // locateIwadButton
            // 
            this.locateIwadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locateIwadButton.Location = new System.Drawing.Point(290, 12);
            this.locateIwadButton.Name = "locateIwadButton";
            this.locateIwadButton.Size = new System.Drawing.Size(236, 31);
            this.locateIwadButton.TabIndex = 3;
            this.locateIwadButton.Text = "Locate IWAD";
            this.locateIwadButton.UseVisualStyleBackColor = true;
            this.locateIwadButton.Click += new System.EventHandler(this.LocateIwadButtonOnClick);
            // 
            // openIwadDialog
            // 
            this.openIwadDialog.Filter = "IWAD|*.wad";
            this.openIwadDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenIwadDialogFileLoaded);
            // 
            // episodeInput
            // 
            this.episodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeInput.Location = new System.Drawing.Point(12, 104);
            this.episodeInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.episodeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.episodeInput.Name = "episodeInput";
            this.episodeInput.Size = new System.Drawing.Size(73, 27);
            this.episodeInput.TabIndex = 5;
            this.episodeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.episodeInput.ValueChanged += new System.EventHandler(this.EpisodeInputChanged);
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(11, 81);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(62, 18);
            this.episodeLabel.TabIndex = 6;
            this.episodeLabel.Text = "Episode";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(103, 81);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(42, 18);
            this.levelLabel.TabIndex = 8;
            this.levelLabel.Text = "Level";
            // 
            // levelInput
            // 
            this.levelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelInput.Location = new System.Drawing.Point(104, 104);
            this.levelInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.levelInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(73, 27);
            this.levelInput.TabIndex = 7;
            this.levelInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelInput.ValueChanged += new System.EventHandler(this.LevelInputChanged);
            // 
            // demoNameLabel
            // 
            this.demoNameLabel.AutoSize = true;
            this.demoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoNameLabel.Location = new System.Drawing.Point(12, 205);
            this.demoNameLabel.Name = "demoNameLabel";
            this.demoNameLabel.Size = new System.Drawing.Size(327, 18);
            this.demoNameLabel.TabIndex = 9;
            this.demoNameLabel.Text = "Demo path (this is also used for demo playback)";
            // 
            // complevelLabel
            // 
            this.complevelLabel.AutoSize = true;
            this.complevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complevelLabel.Location = new System.Drawing.Point(216, 81);
            this.complevelLabel.Name = "complevelLabel";
            this.complevelLabel.Size = new System.Drawing.Size(78, 18);
            this.complevelLabel.TabIndex = 11;
            this.complevelLabel.Text = "Complevel";
            // 
            // complevelInput
            // 
            this.complevelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complevelInput.Location = new System.Drawing.Point(217, 104);
            this.complevelInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.complevelInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.complevelInput.Name = "complevelInput";
            this.complevelInput.Size = new System.Drawing.Size(73, 27);
            this.complevelInput.TabIndex = 10;
            this.complevelInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.complevelInput.ValueChanged += new System.EventHandler(this.ComplevelInputChanged);
            // 
            // demoNameInput
            // 
            this.demoNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoNameInput.Location = new System.Drawing.Point(149, 227);
            this.demoNameInput.Margin = new System.Windows.Forms.Padding(0);
            this.demoNameInput.Name = "demoNameInput";
            this.demoNameInput.ReadOnly = true;
            this.demoNameInput.Size = new System.Drawing.Size(376, 28);
            this.demoNameInput.TabIndex = 12;
            // 
            // skillSelect
            // 
            this.skillSelect.DisplayMember = "4";
            this.skillSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillSelect.FormattingEnabled = true;
            this.skillSelect.Items.AddRange(new object[] {
            "I\'m too young to die",
            "Hey, not too rough",
            "Hurt me plenty",
            "Ultra-Violence",
            "Nightmare!"});
            this.skillSelect.Location = new System.Drawing.Point(326, 104);
            this.skillSelect.Name = "skillSelect";
            this.skillSelect.Size = new System.Drawing.Size(199, 26);
            this.skillSelect.TabIndex = 13;
            this.skillSelect.ValueMember = "4";
            this.skillSelect.SelectedIndexChanged += new System.EventHandler(this.SkillSelectChanged);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(323, 81);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(63, 18);
            this.difficultyLabel.TabIndex = 14;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // isEpisodeActiveCheckbox
            // 
            this.isEpisodeActiveCheckbox.AutoSize = true;
            this.isEpisodeActiveCheckbox.Checked = true;
            this.isEpisodeActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isEpisodeActiveCheckbox.Location = new System.Drawing.Point(11, 138);
            this.isEpisodeActiveCheckbox.Name = "isEpisodeActiveCheckbox";
            this.isEpisodeActiveCheckbox.Size = new System.Drawing.Size(221, 21);
            this.isEpisodeActiveCheckbox.TabIndex = 15;
            this.isEpisodeActiveCheckbox.Text = "Does IWAD contain episodes?";
            this.isEpisodeActiveCheckbox.UseVisualStyleBackColor = true;
            this.isEpisodeActiveCheckbox.CheckedChanged += new System.EventHandler(this.IsEpisodeActiveOnChange);
            // 
            // playDemoButton
            // 
            this.playDemoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playDemoButton.Location = new System.Drawing.Point(161, 386);
            this.playDemoButton.Name = "playDemoButton";
            this.playDemoButton.Size = new System.Drawing.Size(144, 53);
            this.playDemoButton.TabIndex = 16;
            this.playDemoButton.Text = "Play demo";
            this.playDemoButton.UseVisualStyleBackColor = true;
            this.playDemoButton.Click += new System.EventHandler(this.PlayDemoButtonOnClick);
            // 
            // noMonstersCheckbox
            // 
            this.noMonstersCheckbox.AutoSize = true;
            this.noMonstersCheckbox.Location = new System.Drawing.Point(265, 138);
            this.noMonstersCheckbox.Name = "noMonstersCheckbox";
            this.noMonstersCheckbox.Size = new System.Drawing.Size(110, 21);
            this.noMonstersCheckbox.TabIndex = 17;
            this.noMonstersCheckbox.Text = "No monsters";
            this.noMonstersCheckbox.UseVisualStyleBackColor = true;
            this.noMonstersCheckbox.CheckedChanged += new System.EventHandler(this.NoMonstersCheckboxChanged);
            // 
            // fastMonstersCheckbox
            // 
            this.fastMonstersCheckbox.AutoSize = true;
            this.fastMonstersCheckbox.Location = new System.Drawing.Point(406, 138);
            this.fastMonstersCheckbox.Name = "fastMonstersCheckbox";
            this.fastMonstersCheckbox.Size = new System.Drawing.Size(119, 21);
            this.fastMonstersCheckbox.TabIndex = 18;
            this.fastMonstersCheckbox.Text = "Fast monsters";
            this.fastMonstersCheckbox.UseVisualStyleBackColor = true;
            this.fastMonstersCheckbox.CheckedChanged += new System.EventHandler(this.FastMonstersCheckboxChanged);
            // 
            // saveDemoDialog
            // 
            this.saveDemoDialog.Filter = "Doom demo file|*.lmp";
            // 
            // setDemoPathButton
            // 
            this.setDemoPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDemoPathButton.Location = new System.Drawing.Point(12, 226);
            this.setDemoPathButton.Name = "setDemoPathButton";
            this.setDemoPathButton.Size = new System.Drawing.Size(131, 34);
            this.setDemoPathButton.TabIndex = 19;
            this.setDemoPathButton.Text = "Set demo path";
            this.setDemoPathButton.UseVisualStyleBackColor = true;
            this.setDemoPathButton.Click += new System.EventHandler(this.SetDemoPathButtonClick);
            // 
            // respawnCheckbox
            // 
            this.respawnCheckbox.AutoSize = true;
            this.respawnCheckbox.Location = new System.Drawing.Point(406, 165);
            this.respawnCheckbox.Name = "respawnCheckbox";
            this.respawnCheckbox.Size = new System.Drawing.Size(88, 21);
            this.respawnCheckbox.TabIndex = 20;
            this.respawnCheckbox.Text = "Respawn";
            this.respawnCheckbox.UseVisualStyleBackColor = true;
            this.respawnCheckbox.CheckedChanged += new System.EventHandler(this.RespawnCheckboxChanged);
            // 
            // locatePwadsButton
            // 
            this.locatePwadsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatePwadsButton.Location = new System.Drawing.Point(11, 278);
            this.locatePwadsButton.Name = "locatePwadsButton";
            this.locatePwadsButton.Size = new System.Drawing.Size(140, 44);
            this.locatePwadsButton.TabIndex = 21;
            this.locatePwadsButton.Text = "Locate PWADs";
            this.locatePwadsButton.UseVisualStyleBackColor = true;
            this.locatePwadsButton.Click += new System.EventHandler(this.LocatePwadButtonOnClick);
            // 
            // unloadPwadsButton
            // 
            this.unloadPwadsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloadPwadsButton.Location = new System.Drawing.Point(11, 328);
            this.unloadPwadsButton.Name = "unloadPwadsButton";
            this.unloadPwadsButton.Size = new System.Drawing.Size(140, 42);
            this.unloadPwadsButton.TabIndex = 22;
            this.unloadPwadsButton.Text = "Unload PWAD";
            this.unloadPwadsButton.UseVisualStyleBackColor = true;
            this.unloadPwadsButton.Click += new System.EventHandler(this.UnloadPwadButtonOnClick);
            // 
            // pwadListView
            // 
            this.pwadListView.AutoArrange = false;
            this.pwadListView.FullRowSelect = true;
            this.pwadListView.GridLines = true;
            this.pwadListView.HideSelection = false;
            this.pwadListView.Location = new System.Drawing.Point(158, 278);
            this.pwadListView.MultiSelect = false;
            this.pwadListView.Name = "pwadListView";
            this.pwadListView.Size = new System.Drawing.Size(367, 92);
            this.pwadListView.TabIndex = 23;
            this.pwadListView.UseCompatibleStateImageBehavior = false;
            this.pwadListView.View = System.Windows.Forms.View.List;
            // 
            // openPwadDialog
            // 
            this.openPwadDialog.Filter = "PWAD|*.wad";
            this.openPwadDialog.Multiselect = true;
            this.openPwadDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenPwadDialogFileLoaded);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(455, 412);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(70, 23);
            this.aboutButton.TabIndex = 24;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButtonOnClick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 447);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pwadListView);
            this.Controls.Add(this.unloadPwadsButton);
            this.Controls.Add(this.locatePwadsButton);
            this.Controls.Add(this.respawnCheckbox);
            this.Controls.Add(this.setDemoPathButton);
            this.Controls.Add(this.fastMonstersCheckbox);
            this.Controls.Add(this.noMonstersCheckbox);
            this.Controls.Add(this.playDemoButton);
            this.Controls.Add(this.isEpisodeActiveCheckbox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.skillSelect);
            this.Controls.Add(this.demoNameInput);
            this.Controls.Add(this.complevelLabel);
            this.Controls.Add(this.complevelInput);
            this.Controls.Add(this.demoNameLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelInput);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.episodeInput);
            this.Controls.Add(this.iwadPathLabel);
            this.Controls.Add(this.locateIwadButton);
            this.Controls.Add(this.prBoomPathLabel);
            this.Controls.Add(this.locatePrBoomButton);
            this.Controls.Add(this.recordDemoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Doom Demo Record Tool";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.episodeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complevelInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label demoNameLabel;
        private System.Windows.Forms.Label complevelLabel;
        private System.Windows.Forms.Button recordDemoButton;
        private System.Windows.Forms.Button locatePrBoomButton;
        private System.Windows.Forms.Button locateIwadButton;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button playDemoButton;
        private System.Windows.Forms.Button setDemoPathButton;
        private System.Windows.Forms.Button locatePwadsButton;
        private System.Windows.Forms.Button unloadPwadsButton;

        public System.Windows.Forms.OpenFileDialog openPrBoomDialog;
        public System.Windows.Forms.Label prBoomPathLabel;
        public System.Windows.Forms.Label iwadPathLabel;
        public System.Windows.Forms.OpenFileDialog openIwadDialog;
        public System.Windows.Forms.NumericUpDown episodeInput;
        public System.Windows.Forms.NumericUpDown levelInput;
        public System.Windows.Forms.NumericUpDown complevelInput;
        public System.Windows.Forms.TextBox demoNameInput;
        public System.Windows.Forms.ComboBox skillSelect;
        public System.Windows.Forms.CheckBox isEpisodeActiveCheckbox;
        public System.Windows.Forms.CheckBox noMonstersCheckbox;
        public System.Windows.Forms.CheckBox fastMonstersCheckbox;
        public System.Windows.Forms.CheckBox respawnCheckbox;
        public System.Windows.Forms.ListView pwadListView;
        public System.Windows.Forms.OpenFileDialog openPwadDialog;
        public System.Windows.Forms.SaveFileDialog saveDemoDialog;
        private System.Windows.Forms.Button aboutButton;
    }
}

