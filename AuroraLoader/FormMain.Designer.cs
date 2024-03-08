using System.Windows.Forms;

namespace AuroraLoader
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonSinglePlayer = new Button();
            LabelAuroraVersion = new Label();
            TrackMusicVolume = new TrackBar();
            CheckEnableMusic = new CheckBox();
            ButtonReadme = new Button();
            ButtonChangelog = new Button();
            LabelAuroraLoaderVersion = new Label();
            CheckEnableMods = new CheckBox();
            CheckEnablePoweruserMods = new CheckBox();
            ComboSelectExecutableMod = new ComboBox();
            LinkForums = new LinkLabel();
            LinkReportBug = new LinkLabel();
            LinkSubreddit = new LinkLabel();
            LinkDiscord = new LinkLabel();
            LinkModSubreddit = new LinkLabel();
            ButtonMultiplayer = new Button();
            ButtonManageMods = new Button();
            SelectedSavelabel = new Label();
            ButtonMangeSaves = new Button();
            PictureBoxUpdateAurora = new PictureBox();
            PictureBoxUpdateLoader = new PictureBox();
            tableLayoutPanel_MainWindow = new TableLayoutPanel();
            tableLayoutPanel_Versions = new TableLayoutPanel();
            tableLayout_LinkDock = new TableLayoutPanel();
            groupBox_UtilsMods = new GroupBox();
            ListUtilities = new CheckedListBox();
            groupBox_DBmods = new GroupBox();
            ListDatabaseMods = new CheckedListBox();
            tableLayoutPanel_ManageMods_MP = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)TrackMusicVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateAurora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateLoader).BeginInit();
            tableLayoutPanel_MainWindow.SuspendLayout();
            tableLayoutPanel_Versions.SuspendLayout();
            tableLayout_LinkDock.SuspendLayout();
            groupBox_UtilsMods.SuspendLayout();
            groupBox_DBmods.SuspendLayout();
            tableLayoutPanel_ManageMods_MP.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonSinglePlayer
            // 
            ButtonSinglePlayer.Dock = DockStyle.Fill;
            ButtonSinglePlayer.Enabled = false;
            ButtonSinglePlayer.Location = new System.Drawing.Point(10, 49);
            ButtonSinglePlayer.Margin = new Padding(5);
            ButtonSinglePlayer.Name = "ButtonSinglePlayer";
            ButtonSinglePlayer.Size = new System.Drawing.Size(122, 29);
            ButtonSinglePlayer.TabIndex = 2;
            ButtonSinglePlayer.Text = "Play";
            ButtonSinglePlayer.UseVisualStyleBackColor = true;
            ButtonSinglePlayer.Click += ButtonSinglePlayer_Click;
            // 
            // LabelAuroraVersion
            // 
            LabelAuroraVersion.Anchor = AnchorStyles.Left;
            LabelAuroraVersion.Location = new System.Drawing.Point(166, 14);
            LabelAuroraVersion.Margin = new Padding(5, 0, 5, 0);
            LabelAuroraVersion.Name = "LabelAuroraVersion";
            LabelAuroraVersion.Size = new System.Drawing.Size(138, 20);
            LabelAuroraVersion.TabIndex = 7;
            LabelAuroraVersion.Text = "Aurora v#.##.#";
            LabelAuroraVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrackMusicVolume
            // 
            TrackMusicVolume.Dock = DockStyle.Top;
            TrackMusicVolume.Enabled = false;
            TrackMusicVolume.LargeChange = 1;
            TrackMusicVolume.Location = new System.Drawing.Point(346, 49);
            TrackMusicVolume.Margin = new Padding(5);
            TrackMusicVolume.Name = "TrackMusicVolume";
            TrackMusicVolume.Size = new System.Drawing.Size(198, 29);
            TrackMusicVolume.TabIndex = 20;
            TrackMusicVolume.Value = 4;
            // 
            // CheckEnableMusic
            // 
            CheckEnableMusic.Anchor = AnchorStyles.Left;
            CheckEnableMusic.AutoSize = true;
            CheckEnableMusic.Location = new System.Drawing.Point(142, 51);
            CheckEnableMusic.Margin = new Padding(5);
            CheckEnableMusic.Name = "CheckEnableMusic";
            CheckEnableMusic.Size = new System.Drawing.Size(130, 24);
            CheckEnableMusic.TabIndex = 2;
            CheckEnableMusic.Text = "In-Game Music";
            CheckEnableMusic.UseVisualStyleBackColor = true;
            CheckEnableMusic.CheckedChanged += CheckMusic_CheckedChanged;
            // 
            // ButtonReadme
            // 
            ButtonReadme.Dock = DockStyle.Right;
            ButtonReadme.Location = new System.Drawing.Point(415, 10);
            ButtonReadme.Margin = new Padding(5);
            ButtonReadme.MinimumSize = new System.Drawing.Size(129, 30);
            ButtonReadme.Name = "ButtonReadme";
            ButtonReadme.Size = new System.Drawing.Size(129, 30);
            ButtonReadme.TabIndex = 13;
            ButtonReadme.Text = "Readme";
            ButtonReadme.UseVisualStyleBackColor = true;
            ButtonReadme.Click += ButtonReadme_Click;
            // 
            // ButtonChangelog
            // 
            ButtonChangelog.Dock = DockStyle.Fill;
            ButtonChangelog.Location = new System.Drawing.Point(554, 10);
            ButtonChangelog.Margin = new Padding(5);
            ButtonChangelog.Name = "ButtonChangelog";
            ButtonChangelog.Size = new System.Drawing.Size(127, 29);
            ButtonChangelog.TabIndex = 14;
            ButtonChangelog.Text = "Changelog";
            ButtonChangelog.UseVisualStyleBackColor = true;
            ButtonChangelog.Click += ButtonChangelog_Click;
            // 
            // LabelAuroraLoaderVersion
            // 
            LabelAuroraLoaderVersion.Anchor = AnchorStyles.Left;
            LabelAuroraLoaderVersion.Location = new System.Drawing.Point(5, 14);
            LabelAuroraLoaderVersion.Margin = new Padding(5, 0, 5, 0);
            LabelAuroraLoaderVersion.Name = "LabelAuroraLoaderVersion";
            LabelAuroraLoaderVersion.Size = new System.Drawing.Size(111, 20);
            LabelAuroraLoaderVersion.TabIndex = 7;
            LabelAuroraLoaderVersion.Text = "Loader v#.##.#";
            LabelAuroraLoaderVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckEnableMods
            // 
            CheckEnableMods.AutoSize = true;
            CheckEnableMods.Location = new System.Drawing.Point(8, 87);
            CheckEnableMods.Margin = new Padding(3, 4, 3, 4);
            CheckEnableMods.Name = "CheckEnableMods";
            CheckEnableMods.Size = new System.Drawing.Size(117, 24);
            CheckEnableMods.TabIndex = 21;
            CheckEnableMods.Text = "Enable Mods";
            CheckEnableMods.UseVisualStyleBackColor = true;
            CheckEnableMods.CheckedChanged += CheckEnableMods_CheckChanged;
            // 
            // CheckEnablePoweruserMods
            // 
            CheckEnablePoweruserMods.AutoSize = true;
            CheckEnablePoweruserMods.Location = new System.Drawing.Point(140, 87);
            CheckEnablePoweruserMods.Margin = new Padding(3, 4, 3, 4);
            CheckEnablePoweruserMods.Name = "CheckEnablePoweruserMods";
            CheckEnablePoweruserMods.Size = new System.Drawing.Size(188, 24);
            CheckEnablePoweruserMods.TabIndex = 23;
            CheckEnablePoweruserMods.Text = "Enable Poweruser Mods";
            CheckEnablePoweruserMods.UseVisualStyleBackColor = true;
            CheckEnablePoweruserMods.CheckedChanged += CheckEnablePoweruserMod_CheckChanged;
            // 
            // ComboSelectExecutableMod
            // 
            ComboSelectExecutableMod.Dock = DockStyle.Top;
            ComboSelectExecutableMod.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSelectExecutableMod.FormattingEnabled = true;
            ComboSelectExecutableMod.Location = new System.Drawing.Point(344, 87);
            ComboSelectExecutableMod.Margin = new Padding(3, 4, 3, 4);
            ComboSelectExecutableMod.Name = "ComboSelectExecutableMod";
            ComboSelectExecutableMod.Size = new System.Drawing.Size(202, 28);
            ComboSelectExecutableMod.TabIndex = 27;
            // 
            // LinkForums
            // 
            LinkForums.Anchor = AnchorStyles.Right;
            LinkForums.AutoSize = true;
            LinkForums.Location = new System.Drawing.Point(19, 0);
            LinkForums.Name = "LinkForums";
            LinkForums.Size = new System.Drawing.Size(109, 20);
            LinkForums.TabIndex = 33;
            LinkForums.TabStop = true;
            LinkForums.Text = "Official Forums";
            LinkForums.LinkClicked += LinkForums_LinkClicked;
            // 
            // LinkReportBug
            // 
            LinkReportBug.Anchor = AnchorStyles.Right;
            LinkReportBug.AutoSize = true;
            LinkReportBug.Location = new System.Drawing.Point(32, 84);
            LinkReportBug.Name = "LinkReportBug";
            LinkReportBug.Size = new System.Drawing.Size(96, 20);
            LinkReportBug.TabIndex = 34;
            LinkReportBug.TabStop = true;
            LinkReportBug.Text = "Report a Bug";
            LinkReportBug.LinkClicked += LinkVanillaBug_LinkClicked;
            // 
            // LinkSubreddit
            // 
            LinkSubreddit.Anchor = AnchorStyles.Right;
            LinkSubreddit.AutoSize = true;
            LinkSubreddit.Location = new System.Drawing.Point(5, 63);
            LinkSubreddit.Name = "LinkSubreddit";
            LinkSubreddit.Size = new System.Drawing.Size(123, 20);
            LinkSubreddit.TabIndex = 35;
            LinkSubreddit.TabStop = true;
            LinkSubreddit.Text = "Aurora Subreddit";
            LinkSubreddit.LinkClicked += LinkVanillaSubreddit_LinkClicked;
            // 
            // LinkDiscord
            // 
            LinkDiscord.Anchor = AnchorStyles.Right;
            LinkDiscord.AutoSize = true;
            LinkDiscord.Location = new System.Drawing.Point(68, 21);
            LinkDiscord.Name = "LinkDiscord";
            LinkDiscord.Size = new System.Drawing.Size(60, 20);
            LinkDiscord.TabIndex = 36;
            LinkDiscord.TabStop = true;
            LinkDiscord.Text = "Discord";
            LinkDiscord.LinkClicked += LinkDiscord_LinkClicked;
            // 
            // LinkModSubreddit
            // 
            LinkModSubreddit.Anchor = AnchorStyles.Right;
            LinkModSubreddit.AutoSize = true;
            LinkModSubreddit.Location = new System.Drawing.Point(19, 42);
            LinkModSubreddit.Name = "LinkModSubreddit";
            LinkModSubreddit.Size = new System.Drawing.Size(109, 20);
            LinkModSubreddit.TabIndex = 35;
            LinkModSubreddit.TabStop = true;
            LinkModSubreddit.Text = "Mod Subreddit";
            LinkModSubreddit.LinkClicked += LinkVanillaSubreddit_LinkClicked;
            // 
            // ButtonMultiplayer
            // 
            ButtonMultiplayer.Dock = DockStyle.Fill;
            ButtonMultiplayer.Location = new System.Drawing.Point(170, 5);
            ButtonMultiplayer.Margin = new Padding(5);
            ButtonMultiplayer.Name = "ButtonMultiplayer";
            ButtonMultiplayer.Size = new System.Drawing.Size(155, 38);
            ButtonMultiplayer.TabIndex = 2;
            ButtonMultiplayer.Text = "Play";
            ButtonMultiplayer.UseVisualStyleBackColor = true;
            ButtonMultiplayer.Click += ButtonSinglePlayer_Click;
            // 
            // ButtonManageMods
            // 
            ButtonManageMods.Dock = DockStyle.Fill;
            ButtonManageMods.Location = new System.Drawing.Point(3, 4);
            ButtonManageMods.Margin = new Padding(3, 4, 3, 4);
            ButtonManageMods.Name = "ButtonManageMods";
            ButtonManageMods.Size = new System.Drawing.Size(159, 40);
            ButtonManageMods.TabIndex = 41;
            ButtonManageMods.Text = "Manage Mods";
            ButtonManageMods.UseVisualStyleBackColor = true;
            ButtonManageMods.Click += ButtonManageMods_Click;
            // 
            // SelectedSavelabel
            // 
            SelectedSavelabel.Anchor = AnchorStyles.Left;
            SelectedSavelabel.AutoSize = true;
            SelectedSavelabel.Location = new System.Drawing.Point(140, 14);
            SelectedSavelabel.Name = "SelectedSavelabel";
            SelectedSavelabel.Size = new System.Drawing.Size(130, 20);
            SelectedSavelabel.TabIndex = 42;
            SelectedSavelabel.Text = "No game selected";
            // 
            // ButtonMangeSaves
            // 
            ButtonMangeSaves.Dock = DockStyle.Fill;
            ButtonMangeSaves.Location = new System.Drawing.Point(10, 10);
            ButtonMangeSaves.Margin = new Padding(5);
            ButtonMangeSaves.Name = "ButtonMangeSaves";
            ButtonMangeSaves.Size = new System.Drawing.Size(122, 29);
            ButtonMangeSaves.TabIndex = 41;
            ButtonMangeSaves.Text = "Select Game";
            ButtonMangeSaves.UseVisualStyleBackColor = true;
            ButtonMangeSaves.Click += ButtonManageSaves_Click;
            // 
            // PictureBoxUpdateAurora
            // 
            PictureBoxUpdateAurora.Anchor = AnchorStyles.Left;
            PictureBoxUpdateAurora.Image = (System.Drawing.Image)resources.GetObject("PictureBoxUpdateAurora.Image");
            PictureBoxUpdateAurora.Location = new System.Drawing.Point(124, 5);
            PictureBoxUpdateAurora.Margin = new Padding(3, 4, 3, 4);
            PictureBoxUpdateAurora.MinimumSize = new System.Drawing.Size(38, 38);
            PictureBoxUpdateAurora.Name = "PictureBoxUpdateAurora";
            PictureBoxUpdateAurora.Size = new System.Drawing.Size(38, 38);
            PictureBoxUpdateAurora.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxUpdateAurora.TabIndex = 43;
            PictureBoxUpdateAurora.TabStop = false;
            PictureBoxUpdateAurora.Click += ButtonUpdateAurora_Click;
            // 
            // PictureBoxUpdateLoader
            // 
            PictureBoxUpdateLoader.Anchor = AnchorStyles.Right;
            PictureBoxUpdateLoader.Image = (System.Drawing.Image)resources.GetObject("PictureBoxUpdateLoader.Image");
            PictureBoxUpdateLoader.Location = new System.Drawing.Point(312, 5);
            PictureBoxUpdateLoader.Margin = new Padding(3, 4, 3, 4);
            PictureBoxUpdateLoader.MinimumSize = new System.Drawing.Size(38, 38);
            PictureBoxUpdateLoader.Name = "PictureBoxUpdateLoader";
            PictureBoxUpdateLoader.Size = new System.Drawing.Size(38, 38);
            PictureBoxUpdateLoader.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxUpdateLoader.TabIndex = 43;
            PictureBoxUpdateLoader.TabStop = false;
            PictureBoxUpdateLoader.Click += ButtonUpdateAuroraLoader_Click;
            // 
            // tableLayoutPanel_MainWindow
            // 
            tableLayoutPanel_MainWindow.ColumnCount = 4;
            tableLayoutPanel_MainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5369034F));
            tableLayoutPanel_MainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1013031F));
            tableLayoutPanel_MainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.69016F));
            tableLayoutPanel_MainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.97063F));
            tableLayoutPanel_MainWindow.Controls.Add(ButtonMangeSaves, 0, 0);
            tableLayoutPanel_MainWindow.Controls.Add(SelectedSavelabel, 1, 0);
            tableLayoutPanel_MainWindow.Controls.Add(ButtonChangelog, 3, 0);
            tableLayoutPanel_MainWindow.Controls.Add(ButtonReadme, 2, 0);
            tableLayoutPanel_MainWindow.Controls.Add(ButtonSinglePlayer, 0, 1);
            tableLayoutPanel_MainWindow.Controls.Add(CheckEnableMods, 0, 2);
            tableLayoutPanel_MainWindow.Controls.Add(CheckEnablePoweruserMods, 1, 2);
            tableLayoutPanel_MainWindow.Controls.Add(ComboSelectExecutableMod, 2, 2);
            tableLayoutPanel_MainWindow.Controls.Add(TrackMusicVolume, 2, 1);
            tableLayoutPanel_MainWindow.Controls.Add(CheckEnableMusic, 1, 1);
            tableLayoutPanel_MainWindow.Controls.Add(tableLayoutPanel_Versions, 2, 4);
            tableLayoutPanel_MainWindow.Controls.Add(tableLayout_LinkDock, 3, 1);
            tableLayoutPanel_MainWindow.Controls.Add(groupBox_UtilsMods, 0, 3);
            tableLayoutPanel_MainWindow.Controls.Add(groupBox_DBmods, 2, 3);
            tableLayoutPanel_MainWindow.Controls.Add(tableLayoutPanel_ManageMods_MP, 0, 4);
            tableLayoutPanel_MainWindow.Dock = DockStyle.Fill;
            tableLayoutPanel_MainWindow.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel_MainWindow.Margin = new Padding(5);
            tableLayoutPanel_MainWindow.MinimumSize = new System.Drawing.Size(690, 390);
            tableLayoutPanel_MainWindow.Name = "tableLayoutPanel_MainWindow";
            tableLayoutPanel_MainWindow.Padding = new Padding(5);
            tableLayoutPanel_MainWindow.RowCount = 5;
            tableLayoutPanel_MainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9122257F));
            tableLayoutPanel_MainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9122257F));
            tableLayoutPanel_MainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2151737F));
            tableLayoutPanel_MainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 53.78411F));
            tableLayoutPanel_MainWindow.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel_MainWindow.Size = new System.Drawing.Size(691, 390);
            tableLayoutPanel_MainWindow.TabIndex = 44;
            // 
            // tableLayoutPanel_Versions
            // 
            tableLayoutPanel_Versions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel_Versions.ColumnCount = 4;
            tableLayoutPanel_MainWindow.SetColumnSpan(tableLayoutPanel_Versions, 2);
            tableLayoutPanel_Versions.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_Versions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel_Versions.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_Versions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel_Versions.Controls.Add(PictureBoxUpdateAurora, 1, 0);
            tableLayoutPanel_Versions.Controls.Add(PictureBoxUpdateLoader, 3, 0);
            tableLayoutPanel_Versions.Controls.Add(LabelAuroraLoaderVersion, 0, 0);
            tableLayoutPanel_Versions.Controls.Add(LabelAuroraVersion, 2, 0);
            tableLayoutPanel_Versions.Location = new System.Drawing.Point(344, 334);
            tableLayoutPanel_Versions.Name = "tableLayoutPanel_Versions";
            tableLayoutPanel_Versions.RowCount = 1;
            tableLayoutPanel_Versions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Versions.Size = new System.Drawing.Size(339, 48);
            tableLayoutPanel_Versions.TabIndex = 45;
            // 
            // tableLayout_LinkDock
            // 
            tableLayout_LinkDock.ColumnCount = 1;
            tableLayout_LinkDock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout_LinkDock.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayout_LinkDock.Controls.Add(LinkSubreddit, 0, 3);
            tableLayout_LinkDock.Controls.Add(LinkModSubreddit, 0, 2);
            tableLayout_LinkDock.Controls.Add(LinkDiscord, 0, 1);
            tableLayout_LinkDock.Controls.Add(LinkForums, 0, 0);
            tableLayout_LinkDock.Controls.Add(LinkReportBug, 0, 4);
            tableLayout_LinkDock.Dock = DockStyle.Fill;
            tableLayout_LinkDock.Location = new System.Drawing.Point(552, 47);
            tableLayout_LinkDock.Name = "tableLayout_LinkDock";
            tableLayout_LinkDock.RowCount = 5;
            tableLayoutPanel_MainWindow.SetRowSpan(tableLayout_LinkDock, 2);
            tableLayout_LinkDock.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_LinkDock.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_LinkDock.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_LinkDock.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_LinkDock.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayout_LinkDock.Size = new System.Drawing.Size(131, 105);
            tableLayout_LinkDock.TabIndex = 46;
            // 
            // groupBox_UtilsMods
            // 
            tableLayoutPanel_MainWindow.SetColumnSpan(groupBox_UtilsMods, 2);
            groupBox_UtilsMods.Controls.Add(ListUtilities);
            groupBox_UtilsMods.Dock = DockStyle.Fill;
            groupBox_UtilsMods.Location = new System.Drawing.Point(8, 158);
            groupBox_UtilsMods.Name = "groupBox_UtilsMods";
            groupBox_UtilsMods.Size = new System.Drawing.Size(330, 170);
            groupBox_UtilsMods.TabIndex = 47;
            groupBox_UtilsMods.TabStop = false;
            groupBox_UtilsMods.Text = "Launch utilities alongside Aurora:";
            // 
            // ListUtilities
            // 
            ListUtilities.Dock = DockStyle.Fill;
            ListUtilities.FormattingEnabled = true;
            ListUtilities.Location = new System.Drawing.Point(3, 23);
            ListUtilities.Margin = new Padding(3, 4, 3, 4);
            ListUtilities.Name = "ListUtilities";
            ListUtilities.Size = new System.Drawing.Size(324, 144);
            ListUtilities.TabIndex = 27;
            ListUtilities.SelectedIndexChanged += ListUtilityMods_SelectedIndexChanged;
            // 
            // groupBox_DBmods
            // 
            tableLayoutPanel_MainWindow.SetColumnSpan(groupBox_DBmods, 2);
            groupBox_DBmods.Controls.Add(ListDatabaseMods);
            groupBox_DBmods.Dock = DockStyle.Fill;
            groupBox_DBmods.Location = new System.Drawing.Point(344, 158);
            groupBox_DBmods.Name = "groupBox_DBmods";
            groupBox_DBmods.Size = new System.Drawing.Size(339, 170);
            groupBox_DBmods.TabIndex = 48;
            groupBox_DBmods.TabStop = false;
            groupBox_DBmods.Text = "Apply database mods:";
            // 
            // ListDatabaseMods
            // 
            ListDatabaseMods.Dock = DockStyle.Fill;
            ListDatabaseMods.FormattingEnabled = true;
            ListDatabaseMods.Location = new System.Drawing.Point(3, 23);
            ListDatabaseMods.Margin = new Padding(3, 4, 3, 4);
            ListDatabaseMods.Name = "ListDatabaseMods";
            ListDatabaseMods.Size = new System.Drawing.Size(333, 144);
            ListDatabaseMods.TabIndex = 26;
            // 
            // tableLayoutPanel_ManageMods_MP
            // 
            tableLayoutPanel_ManageMods_MP.ColumnCount = 2;
            tableLayoutPanel_MainWindow.SetColumnSpan(tableLayoutPanel_ManageMods_MP, 2);
            tableLayoutPanel_ManageMods_MP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_ManageMods_MP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_ManageMods_MP.Controls.Add(ButtonManageMods, 0, 0);
            tableLayoutPanel_ManageMods_MP.Controls.Add(ButtonMultiplayer, 1, 0);
            tableLayoutPanel_ManageMods_MP.Dock = DockStyle.Fill;
            tableLayoutPanel_ManageMods_MP.Location = new System.Drawing.Point(8, 334);
            tableLayoutPanel_ManageMods_MP.Name = "tableLayoutPanel_ManageMods_MP";
            tableLayoutPanel_ManageMods_MP.RowCount = 1;
            tableLayoutPanel_ManageMods_MP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_ManageMods_MP.Size = new System.Drawing.Size(330, 48);
            tableLayoutPanel_ManageMods_MP.TabIndex = 49;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(691, 383);
            Controls.Add(tableLayoutPanel_MainWindow);
            Margin = new Padding(5);
            MinimumSize = new System.Drawing.Size(709, 430);
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aurora Loader";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)TrackMusicVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateAurora).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateLoader).EndInit();
            tableLayoutPanel_MainWindow.ResumeLayout(false);
            tableLayoutPanel_MainWindow.PerformLayout();
            tableLayoutPanel_Versions.ResumeLayout(false);
            tableLayout_LinkDock.ResumeLayout(false);
            tableLayout_LinkDock.PerformLayout();
            groupBox_UtilsMods.ResumeLayout(false);
            groupBox_DBmods.ResumeLayout(false);
            tableLayoutPanel_ManageMods_MP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button ButtonSinglePlayer;
        private System.Windows.Forms.Label LabelAuroraVersion;
        private System.Windows.Forms.TrackBar TrackMusicVolume;
        private System.Windows.Forms.CheckBox CheckEnableMusic;
        private System.Windows.Forms.Button ButtonReadme;
        private System.Windows.Forms.Button ButtonChangelog;
        private System.Windows.Forms.Label LabelAuroraLoaderVersion;
        private System.Windows.Forms.CheckBox CheckEnableMods;
        private System.Windows.Forms.CheckBox CheckEnablePoweruserMods;
        private System.Windows.Forms.ComboBox ComboSelectExecutableMod;
        private System.Windows.Forms.LinkLabel LinkForums;
        private System.Windows.Forms.LinkLabel LinkReportBug;
        private System.Windows.Forms.LinkLabel LinkSubreddit;
        private System.Windows.Forms.LinkLabel LinkDiscord;
        private LinkLabel LinkModSubreddit;
        private Button ButtonMultiplayer;
        private Button ButtonManageMods;
        private Label SelectedSavelabel;
        private Button ButtonMangeSaves;
        private PictureBox PictureBoxUpdateAurora;
        private PictureBox PictureBoxUpdateLoader;
        private TableLayoutPanel tableLayoutPanel_MainWindow;
        private TableLayoutPanel tableLayoutPanel_Versions;
        private TableLayoutPanel tableLayout_LinkDock;
        private TableLayoutPanel tableLayoutPanel_ManageMods_MP;
        private GroupBox groupBox_UtilsMods;
        private CheckedListBox ListUtilities;
        private GroupBox groupBox_DBmods;
        private CheckedListBox ListDatabaseMods;
    }
}

