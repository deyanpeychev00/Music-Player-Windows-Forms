namespace Task4_MusicPlayer
{
    partial class MusicPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerForm));
            this.playlistListbox = new System.Windows.Forms.ListBox();
            this.songsCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadPlaylistButton = new System.Windows.Forms.Button();
            this.savePlaylistButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addSongsToPlaylistButton = new System.Windows.Forms.Button();
            this.removeSongFromPlaylistButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadPlaylistDialog = new System.Windows.Forms.OpenFileDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.shuffleCheckbox = new System.Windows.Forms.CheckBox();
            this.repeatCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // playlistListbox
            // 
            this.playlistListbox.AllowDrop = true;
            this.playlistListbox.BackColor = System.Drawing.SystemColors.Control;
            this.playlistListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistListbox.Font = new System.Drawing.Font("ABeeZee", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistListbox.FormattingEnabled = true;
            this.playlistListbox.ItemHeight = 15;
            this.playlistListbox.Location = new System.Drawing.Point(3, 3);
            this.playlistListbox.Name = "playlistListbox";
            this.playlistListbox.Size = new System.Drawing.Size(501, 409);
            this.playlistListbox.TabIndex = 1;
            this.playlistListbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropSongInPlaylist);
            this.playlistListbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.playlistListbox_DragEnter);
            this.playlistListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedSong);
            // 
            // songsCountLabel
            // 
            this.songsCountLabel.AutoSize = true;
            this.songsCountLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsCountLabel.ForeColor = System.Drawing.Color.White;
            this.songsCountLabel.Location = new System.Drawing.Point(116, 7);
            this.songsCountLabel.Name = "songsCountLabel";
            this.songsCountLabel.Size = new System.Drawing.Size(239, 23);
            this.songsCountLabel.TabIndex = 4;
            this.songsCountLabel.Text = "(<songsCount> songs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLAYLIST";
            // 
            // loadPlaylistButton
            // 
            this.loadPlaylistButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loadPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPlaylistButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.loadPlaylistButton.Location = new System.Drawing.Point(199, 3);
            this.loadPlaylistButton.Name = "loadPlaylistButton";
            this.loadPlaylistButton.Size = new System.Drawing.Size(144, 33);
            this.loadPlaylistButton.TabIndex = 2;
            this.loadPlaylistButton.Text = "Load Playlist";
            this.loadPlaylistButton.UseVisualStyleBackColor = false;
            this.loadPlaylistButton.Click += new System.EventHandler(this.LoadPlaylist);
            // 
            // savePlaylistButton
            // 
            this.savePlaylistButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.savePlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlaylistButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePlaylistButton.ForeColor = System.Drawing.Color.White;
            this.savePlaylistButton.Location = new System.Drawing.Point(352, 3);
            this.savePlaylistButton.Name = "savePlaylistButton";
            this.savePlaylistButton.Size = new System.Drawing.Size(144, 33);
            this.savePlaylistButton.TabIndex = 1;
            this.savePlaylistButton.Text = "Save Playlist";
            this.savePlaylistButton.UseVisualStyleBackColor = false;
            this.savePlaylistButton.Click += new System.EventHandler(this.SavePlaylist);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUSIC PLAYER";
            // 
            // addSongsToPlaylistButton
            // 
            this.addSongsToPlaylistButton.BackColor = System.Drawing.Color.Green;
            this.addSongsToPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSongsToPlaylistButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSongsToPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSongsToPlaylistButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongsToPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.addSongsToPlaylistButton.Location = new System.Drawing.Point(3, 3);
            this.addSongsToPlaylistButton.Name = "addSongsToPlaylistButton";
            this.addSongsToPlaylistButton.Size = new System.Drawing.Size(140, 44);
            this.addSongsToPlaylistButton.TabIndex = 3;
            this.addSongsToPlaylistButton.Text = "Add Songs";
            this.addSongsToPlaylistButton.UseVisualStyleBackColor = false;
            this.addSongsToPlaylistButton.Click += new System.EventHandler(this.AddSongsToPlaylist);
            // 
            // removeSongFromPlaylistButton
            // 
            this.removeSongFromPlaylistButton.BackColor = System.Drawing.Color.Maroon;
            this.removeSongFromPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSongFromPlaylistButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeSongFromPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSongFromPlaylistButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSongFromPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.removeSongFromPlaylistButton.Location = new System.Drawing.Point(149, 3);
            this.removeSongFromPlaylistButton.Name = "removeSongFromPlaylistButton";
            this.removeSongFromPlaylistButton.Size = new System.Drawing.Size(140, 44);
            this.removeSongFromPlaylistButton.TabIndex = 4;
            this.removeSongFromPlaylistButton.Text = "Remove Song";
            this.removeSongFromPlaylistButton.UseVisualStyleBackColor = false;
            this.removeSongFromPlaylistButton.Click += new System.EventHandler(this.RemoveSongFromPlaylist);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(435, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(63, 24);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.DisplayAboutForm);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MP3 Files|*.mp3|WAV Files|*.wav";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Add Songs to Playlist";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.songsToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.load;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadPlaylist);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SavePlaylist);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeCurrentToolStripMenuItem});
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddSongsToPlaylist);
            // 
            // removeCurrentToolStripMenuItem
            // 
            this.removeCurrentToolStripMenuItem.Name = "removeCurrentToolStripMenuItem";
            this.removeCurrentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeCurrentToolStripMenuItem.Text = "Remove Selected";
            this.removeCurrentToolStripMenuItem.Click += new System.EventHandler(this.RemoveSongFromPlaylist);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.previousSongToolStripMenuItem,
            this.nextSongToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.play;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playToolStripMenuItem.Tag = "play";
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.ManipulatePlayer);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pauseToolStripMenuItem.Tag = "pause";
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.ManipulatePlayer);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.stop;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stopToolStripMenuItem.Tag = "stop";
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.ManipulatePlayer);
            // 
            // previousSongToolStripMenuItem
            // 
            this.previousSongToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.previous;
            this.previousSongToolStripMenuItem.Name = "previousSongToolStripMenuItem";
            this.previousSongToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.previousSongToolStripMenuItem.Tag = "previous";
            this.previousSongToolStripMenuItem.Text = "Previous Song";
            this.previousSongToolStripMenuItem.Click += new System.EventHandler(this.ManipulatePlayer);
            // 
            // nextSongToolStripMenuItem
            // 
            this.nextSongToolStripMenuItem.Image = global::Task4_MusicPlayer.Properties.Resources.next;
            this.nextSongToolStripMenuItem.Name = "nextSongToolStripMenuItem";
            this.nextSongToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nextSongToolStripMenuItem.Tag = "next";
            this.nextSongToolStripMenuItem.Text = "Next Song";
            this.nextSongToolStripMenuItem.Click += new System.EventHandler(this.ManipulatePlayer);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.DisplayAboutForm);
            // 
            // savePlaylistDialog
            // 
            this.savePlaylistDialog.Filter = "Playlist File|*.playlist";
            // 
            // loadPlaylistDialog
            // 
            this.loadPlaylistDialog.Filter = "Playlist File|*.playlist";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(3, 3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(507, 464);
            this.player.TabIndex = 8;
            this.player.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.UpdateCurrentItem);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.player, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.92629F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 470);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.playlistListbox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(516, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.43965F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56034F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(507, 464);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10799F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.89201F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Controls.Add(this.removeSongFromPlaylistButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addSongsToPlaylistButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.aboutButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 418);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 43);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1032, 576);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.09242F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.90758F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1026, 44);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.songsCountLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(516, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.shuffleCheckbox);
            this.panel4.Controls.Add(this.repeatCheckbox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 38);
            this.panel4.TabIndex = 1;
            // 
            // shuffleCheckbox
            // 
            this.shuffleCheckbox.AutoSize = true;
            this.shuffleCheckbox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleCheckbox.ForeColor = System.Drawing.Color.White;
            this.shuffleCheckbox.Location = new System.Drawing.Point(94, 10);
            this.shuffleCheckbox.Name = "shuffleCheckbox";
            this.shuffleCheckbox.Size = new System.Drawing.Size(80, 20);
            this.shuffleCheckbox.TabIndex = 2;
            this.shuffleCheckbox.Tag = "shuffle";
            this.shuffleCheckbox.Text = "Shuffle";
            this.shuffleCheckbox.UseVisualStyleBackColor = true;
            this.shuffleCheckbox.CheckedChanged += new System.EventHandler(this.SetPlaylistMode);
            // 
            // repeatCheckbox
            // 
            this.repeatCheckbox.AutoSize = true;
            this.repeatCheckbox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatCheckbox.ForeColor = System.Drawing.Color.White;
            this.repeatCheckbox.Location = new System.Drawing.Point(8, 10);
            this.repeatCheckbox.Name = "repeatCheckbox";
            this.repeatCheckbox.Size = new System.Drawing.Size(80, 20);
            this.repeatCheckbox.TabIndex = 1;
            this.repeatCheckbox.Tag = "loop";
            this.repeatCheckbox.Text = "Repeat";
            this.repeatCheckbox.UseVisualStyleBackColor = true;
            this.repeatCheckbox.CheckedChanged += new System.EventHandler(this.SetPlaylistMode);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20576F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79424F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1026, 44);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 38);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.savePlaylistButton);
            this.panel3.Controls.Add(this.loadPlaylistButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(523, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 38);
            this.panel3.TabIndex = 1;
            // 
            // MusicPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 600);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MusicPlayerForm";
            this.Text = "Music Player";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadPlaylistButton;
        private System.Windows.Forms.Button savePlaylistButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSongsToPlaylistButton;
        private System.Windows.Forms.Button removeSongFromPlaylistButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
   //     private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog savePlaylistDialog;
        private System.Windows.Forms.OpenFileDialog loadPlaylistDialog;
        internal System.Windows.Forms.Label songsCountLabel;
        internal System.Windows.Forms.ListBox playlistListbox;
        internal AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox repeatCheckbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox shuffleCheckbox;
    }
}

