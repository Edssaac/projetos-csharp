
namespace PlayerUI
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnEffectsFilters = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.panelPlaylistsSubMenu = new System.Windows.Forms.Panel();
            this.btnExportPlaylist = new System.Windows.Forms.Button();
            this.btnImportPlaylist = new System.Windows.Forms.Button();
            this.btnManagePlaylists = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.btnRecentMedia = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.picCenterLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.picSideLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistsSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 35);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.DoubleClick += new System.EventHandler(this.panelTitleBar_DoubleClick);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnLeave);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelPlaylistsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 35);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnLeave
            // 
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLeave.Location = new System.Drawing.Point(0, 691);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnLeave.Size = new System.Drawing.Size(229, 45);
            this.btnLeave.TabIndex = 9;
            this.btnLeave.Text = "Sair";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 646);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(229, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.btnPreferences);
            this.panelToolsSubMenu.Controls.Add(this.btnEffectsFilters);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 560);
            this.panelToolsSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(229, 86);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // btnPreferences
            // 
            this.btnPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreferences.FlatAppearance.BorderSize = 0;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreferences.Location = new System.Drawing.Point(0, 40);
            this.btnPreferences.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnPreferences.Size = new System.Drawing.Size(229, 40);
            this.btnPreferences.TabIndex = 3;
            this.btnPreferences.Text = "Preferências";
            this.btnPreferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnEffectsFilters
            // 
            this.btnEffectsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEffectsFilters.FlatAppearance.BorderSize = 0;
            this.btnEffectsFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffectsFilters.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEffectsFilters.Location = new System.Drawing.Point(0, 0);
            this.btnEffectsFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffectsFilters.Name = "btnEffectsFilters";
            this.btnEffectsFilters.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnEffectsFilters.Size = new System.Drawing.Size(229, 40);
            this.btnEffectsFilters.TabIndex = 2;
            this.btnEffectsFilters.Text = "Efeitos e Filtros";
            this.btnEffectsFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEffectsFilters.UseVisualStyleBackColor = true;
            this.btnEffectsFilters.Click += new System.EventHandler(this.btnEffectsFilters_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTools.Location = new System.Drawing.Point(0, 515);
            this.btnTools.Margin = new System.Windows.Forms.Padding(4);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(229, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "Ferramentas";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 470);
            this.btnEqualizer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(229, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "Equalizador";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.UseVisualStyleBackColor = true;
            this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // panelPlaylistsSubMenu
            // 
            this.panelPlaylistsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistsSubMenu.Controls.Add(this.btnExportPlaylist);
            this.panelPlaylistsSubMenu.Controls.Add(this.btnImportPlaylist);
            this.panelPlaylistsSubMenu.Controls.Add(this.btnManagePlaylists);
            this.panelPlaylistsSubMenu.Controls.Add(this.btnNewPlaylist);
            this.panelPlaylistsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistsSubMenu.Location = new System.Drawing.Point(0, 305);
            this.panelPlaylistsSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlaylistsSubMenu.Name = "panelPlaylistsSubMenu";
            this.panelPlaylistsSubMenu.Size = new System.Drawing.Size(229, 165);
            this.panelPlaylistsSubMenu.TabIndex = 4;
            // 
            // btnExportPlaylist
            // 
            this.btnExportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnExportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportPlaylist.Location = new System.Drawing.Point(0, 120);
            this.btnExportPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPlaylist.Name = "btnExportPlaylist";
            this.btnExportPlaylist.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnExportPlaylist.Size = new System.Drawing.Size(229, 40);
            this.btnExportPlaylist.TabIndex = 3;
            this.btnExportPlaylist.Text = "Exportar Playlist";
            this.btnExportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPlaylist.UseVisualStyleBackColor = true;
            this.btnExportPlaylist.Click += new System.EventHandler(this.btnExportPlaylist_Click);
            // 
            // btnImportPlaylist
            // 
            this.btnImportPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportPlaylist.FlatAppearance.BorderSize = 0;
            this.btnImportPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImportPlaylist.Location = new System.Drawing.Point(0, 80);
            this.btnImportPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportPlaylist.Name = "btnImportPlaylist";
            this.btnImportPlaylist.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnImportPlaylist.Size = new System.Drawing.Size(229, 40);
            this.btnImportPlaylist.TabIndex = 2;
            this.btnImportPlaylist.Text = "Importar Playlist";
            this.btnImportPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportPlaylist.UseVisualStyleBackColor = true;
            this.btnImportPlaylist.Click += new System.EventHandler(this.btnImportPlaylist_Click);
            // 
            // btnManagePlaylists
            // 
            this.btnManagePlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePlaylists.FlatAppearance.BorderSize = 0;
            this.btnManagePlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePlaylists.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagePlaylists.Location = new System.Drawing.Point(0, 40);
            this.btnManagePlaylists.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagePlaylists.Name = "btnManagePlaylists";
            this.btnManagePlaylists.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnManagePlaylists.Size = new System.Drawing.Size(229, 40);
            this.btnManagePlaylists.TabIndex = 1;
            this.btnManagePlaylists.Text = "Gerenciar Playlists";
            this.btnManagePlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePlaylists.UseVisualStyleBackColor = true;
            this.btnManagePlaylists.Click += new System.EventHandler(this.btnManagePlaylists_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewPlaylist.FlatAppearance.BorderSize = 0;
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewPlaylist.Location = new System.Drawing.Point(0, 0);
            this.btnNewPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnNewPlaylist.Size = new System.Drawing.Size(229, 40);
            this.btnNewPlaylist.TabIndex = 0;
            this.btnNewPlaylist.Text = "Nova Playlist";
            this.btnNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 260);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(229, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Gerenciador de Playlists";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.btnRecentMedia);
            this.panelMediaSubMenu.Controls.Add(this.btnOpenFolder);
            this.panelMediaSubMenu.Controls.Add(this.btnOpenFiles);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 133);
            this.panelMediaSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(229, 127);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // btnRecentMedia
            // 
            this.btnRecentMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecentMedia.FlatAppearance.BorderSize = 0;
            this.btnRecentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecentMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecentMedia.Location = new System.Drawing.Point(0, 80);
            this.btnRecentMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecentMedia.Name = "btnRecentMedia";
            this.btnRecentMedia.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnRecentMedia.Size = new System.Drawing.Size(229, 40);
            this.btnRecentMedia.TabIndex = 3;
            this.btnRecentMedia.Text = "Abrir Mídia Recente";
            this.btnRecentMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecentMedia.UseVisualStyleBackColor = true;
            this.btnRecentMedia.Click += new System.EventHandler(this.btnRecentMedia_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFolder.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnOpenFolder.Size = new System.Drawing.Size(229, 40);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Abrir Pasta";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFiles.FlatAppearance.BorderSize = 0;
            this.btnOpenFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFiles.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnOpenFiles.Size = new System.Drawing.Size(229, 40);
            this.btnOpenFiles.TabIndex = 0;
            this.btnOpenFiles.Text = "Abrir Arquivos";
            this.btnOpenFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedia.Location = new System.Drawing.Point(0, 88);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(229, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Mídia";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picSideLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 88);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.label3);
            this.panelPlayer.Controls.Add(this.panel4);
            this.panelPlayer.Controls.Add(this.label2);
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.panel2);
            this.panelPlayer.Controls.Add(this.pictureBox8);
            this.panelPlayer.Controls.Add(this.picMenu);
            this.panelPlayer.Controls.Add(this.pictureBox6);
            this.panelPlayer.Controls.Add(this.pictureBox5);
            this.panelPlayer.Controls.Add(this.pictureBox4);
            this.panelPlayer.Controls.Add(this.pictureBox3);
            this.panelPlayer.Controls.Add(this.pictureBox9);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 510);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(700, 125);
            this.panelPlayer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(591, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "0%";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(385, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 5);
            this.panel4.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "00:00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(624, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "00:00";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(54, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 5);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(0, -13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 5);
            this.panel3.TabIndex = 9;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.picCenterLogo);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 35);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(700, 475);
            this.panelChildForm.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::PlayerUI.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(917, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = global::PlayerUI.Properties.Resources.Maximize;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(880, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // picCenterLogo
            // 
            this.picCenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCenterLogo.Image = global::PlayerUI.Properties.Resources.logoCenterPanel;
            this.picCenterLogo.Location = new System.Drawing.Point(250, 137);
            this.picCenterLogo.Name = "picCenterLogo";
            this.picCenterLogo.Size = new System.Drawing.Size(200, 200);
            this.picCenterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCenterLogo.TabIndex = 0;
            this.picCenterLogo.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(355, 29);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(79, 29);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(24, 24);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMenu.TabIndex = 17;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(124, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(316, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(166, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(275, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(217, 25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // picSideLogo
            // 
            this.picSideLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSideLogo.Image = global::PlayerUI.Properties.Resources.logoSidePanel;
            this.picSideLogo.Location = new System.Drawing.Point(0, 0);
            this.picSideLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picSideLogo.Name = "picSideLogo";
            this.picSideLogo.Size = new System.Drawing.Size(229, 88);
            this.picSideLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSideLogo.TabIndex = 0;
            this.picSideLogo.TabStop = false;
            this.picSideLogo.Click += new System.EventHandler(this.picSideLogo_Click);
            this.picSideLogo.MouseEnter += new System.EventHandler(this.picSideLogo_MouseEnter);
            this.picSideLogo.MouseLeave += new System.EventHandler(this.picSideLogo_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::PlayerUI.Properties.Resources.Minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(843, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Player";
            this.Text = "Teste";
            this.panelTitleBar.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistsSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCenterLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnEffectsFilters;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistsSubMenu;
        private System.Windows.Forms.Button btnExportPlaylist;
        private System.Windows.Forms.Button btnImportPlaylist;
        private System.Windows.Forms.Button btnManagePlaylists;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button btnRecentMedia;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picSideLogo;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox picCenterLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}