using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/// <summary>
///     <author name="Deyan Peychev"/>
///     <faculty name="STD" number="1901681014"/>
///     <course number="1"/>
///     <project name="Music Player"/>
/// </summary>
namespace Task4_MusicPlayer
{
    public partial class MusicPlayerForm : Form
    {
        /// <summary>
        ///     <param name="songsCount">Holds the number of the songs in the current playlist</param>
        ///     
        ///     <params names="songFiles|oldSongFiles">Hold references to the filenames of the playlist.
        ///         <param name="oldSongFiles">is used for storing the old playlist filenames when the 
        ///             <see cref="AddSongsToPlaylist"/> and 
        ///             <seealso cref="DropSongInPlaylist"/> functionality is being processed.
        ///         </param>
        ///     </params>
        ///     
        ///     <params names="songPaths|oldSongPaths">Hold references to the filepaths of the playlist.
        ///         <param name="oldSongPaths">is used for storing the old playlist filepaths when the        
        ///             <see cref="AddSongsToPlaylist"/> and 
        ///             <seealso cref="DropSongInPlaylist"/> functionality is being processed.</param>
        ///     </params>
        ///     
        ///     <param name="UtilityService">Reference to the <see cref="Utility"/> class that implements several utility functions.</param>
        ///     
        ///     <note>
        ///         <see cref="AxWMPLib"/> WMP Component uses <datatype name="string[]"/> for storing the playlist. 
        ///         Due to that, dynamic manipulation of the playlist cannot be implemented and 
        ///         <params names="oldSongFiles|oldSongPaths"/> are used.
        ///     </note>
        /// </summary>
        int songsCount;
        string[] songFiles, songPaths, oldSongFiles, oldSongPaths;
        Utility UtilityService;

        /// <summary>
        ///     <description>
        ///         Initializing components, utility service and initial UI parameters.
        ///     </description>
        /// </summary>
        public MusicPlayerForm()
        {
            InitializeComponent();
            this.UtilityService = new Utility(this);
            player.currentPlaylist = player.newPlaylist("playlist", "");
            this.UpdatePlaylistSongsCount();
        }

        /// <summary>
        ///     <description>
        ///         Enables/Disables playlist repeat and shuffle functionality.
        ///     </description>
        ///     <dependencies>
        ///          Using <see cref="Utility"/> as a remote service for the required operation.
        ///     </dependencies>
        /// </summary>
        /// 
        private void SetPlaylistMode(object sender, EventArgs e)
        {
            UtilityService.SetPlaylistMode(sender as CheckBox);
        }

        /// <summary>
        ///     <description>
        ///          Updating the global songs counter as well as the label that represents it in the UI.
        ///     </description>
        ///     <dependencies>
        ///          Using <see cref="Utility"/> as a remote service for the required operation.
        ///     </dependencies>
        /// </summary>
        private void UpdatePlaylistSongsCount()
        {
            this.songsCount = UtilityService.UpdatePlaylistSongsCount(player.currentPlaylist.count);
        }

        /// <summary>
        ///     <description>
        ///         Resets the WMP Controller playlist and the global arrays that hold the file referencies. 
        ///         Updates the songs counter <see cref="UpdatePlaylistSongsCount"/>
        ///     </description>
        ///     <dependencies>
        ///         Using <see cref="Utility"/> as a remote service for the required operation.
        ///     </dependencies>
        /// </summary>
        private void ResetPlaylistCollections()
        {
            this.oldSongFiles = this.songFiles = this.oldSongPaths = this.songPaths = UtilityService.ResetPlaylistCollections();
            this.UpdatePlaylistSongsCount();
        }

        /// <summary>
        ///     <description>
        ///         Manipulates the WMP Controller based on clicking the buttons on the toolstrip menu.
        ///         Checks the current <param name="sender"></param> Tag property to define which operation to perform.
        ///     </description>
        /// </summary>
        private void ManipulatePlayer(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;
            switch (tsmi.Tag)
            {
                case "play":
                    player.Ctlcontrols.play();
                    break;
                case "pause":
                    player.Ctlcontrols.pause();
                    break;
                case "previous":
                    {
                        player.Ctlcontrols.previous();
                        if (playlistListbox.SelectedIndex == 0)
                        {
                            playlistListbox.SelectedIndex = playlistListbox.Items.Count - 1;
                        }
                        else
                        {
                            playlistListbox.SelectedIndex--;
                        }

                        break;
                    }
                case "next":
                    {
                        player.Ctlcontrols.next();
                        try
                        {
                            playlistListbox.SelectedIndex++;
                        }
                        catch (Exception ex)
                        {
                            if (ex is IndexOutOfRangeException || ex is ArgumentOutOfRangeException)
                            {
                                playlistListbox.SelectedIndex = 0;
                            }
                        }

                        break;
                    }
                case "stop":
                    player.Ctlcontrols.stop();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        ///     <description>
        ///         When double-clicked, the selected song from the playlist is being played in the WMP Controller and marked as selected in the playlist listbox.
        ///     </description> 
        /// </summary>
        private void UpdateCurrentItem(object sender = null, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e = null)
        {
            string[] filenamePath = player.currentMedia.sourceURL.Split(new char[] { '\\' });
            playlistListbox.SelectedItem = filenamePath[filenamePath.Length - 1];
        }

        /// <summary>
        ///     <description>
        ///         Plays the selected song from the playlist listbox in the WMP Controller.
        ///     </description>
        /// </summary>
        private void PlaySelectedSong(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.playItem(player.currentPlaylist.get_Item(playlistListbox.SelectedIndex));
        }

        /// <summary>
        ///     <description>
        ///         Saves the currently loaded files in a custom playlist file.
        ///         The file is saved with <extention name=".playlist"/> extention.
        ///     </description>
        ///     <dependencies>
        ///         Using <see cref="SaveFileDialog"/> for saving the file.
        ///     </dependencies>
        /// </summary>
        private void SavePlaylist(object sender, EventArgs e)
        {
            if (savePlaylistDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(savePlaylistDialog.FileName);

                for (int i = 0; i < player.currentPlaylist.count; i++)
                {
                    writer.WriteLine(player.currentPlaylist.get_Item(i).sourceURL);
                }
                writer.Close();
            }
        }

        /// <summary>
        ///     <description>
        ///         Loads a previously saved playlist from a file.
        ///         The file must be with <extention name=".playlist"/> extention.
        ///     </description>
        ///     <dependencies>
        ///         Using <see cref="OpenFileDialog"/> for loading the file.
        ///     </dependencies>
        /// </summary>
        private void LoadPlaylist(object sender, EventArgs e)
        {
            player.currentPlaylist.clear();

            playlistListbox.Items.Clear();
            this.oldSongFiles = this.oldSongPaths = this.songFiles = this.songPaths = Array.Empty<string>();

            string line;
            if (loadPlaylistDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> filenames = new List<string>();
                List<string> filepaths = new List<string>();
                using (StreamReader fileReader = new StreamReader(loadPlaylistDialog.OpenFile()))
                {
                    // Update the playlist name with the name of the loaded playlist file
                    player.currentPlaylist.name = loadPlaylistDialog.SafeFileName.Substring(0, loadPlaylistDialog.SafeFileName.Length - 4);

                    // Fill the WMP with the songs from the loaded playlist
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        string[] filenamePath = line.Split(new char[] { '\\' });
                        playlistListbox.Items.Add(filenamePath[filenamePath.Length - 1]);
                        player.currentPlaylist.appendItem(player.newMedia(line));
                        filenames.Add(filenamePath[filenamePath.Length - 1]);
                        filepaths.Add(line);
                        this.songsCount++;
                    }
                    this.oldSongFiles = this.songFiles = filenames.ToArray();
                    this.oldSongPaths = this.songPaths = filepaths.ToArray();
                }
            }

            UpdatePlaylistSongsCount();
        }

        /// <summary>
        ///     <description>
        ///         Implementing Drag-and-Drop functionality.
        ///         <usecases>
        ///             <usecase>
        ///                 Dropping <file extention=".playlist"/>: Resets the current playlist and loads the dropped playlist file.
        ///             </usecase>
        ///             <usecase>
        ///                 Dropping <file extention=".mp3|.wav"/>: Adds the dropped file to the current playlist.
        ///             </usecase>
        ///         </usecases>
        ///     </description>
        /// </summary>
        private void DropSongInPlaylist(object sender, DragEventArgs e)
        {
            string[] droppedItem = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string filePath = droppedItem[0];

            List<string> filenames = new List<string>();
            List<string> filepaths = new List<string>();

            if (filePath.EndsWith(".playlist"))
            {
                this.ResetPlaylistCollections();

                StreamReader sr = new StreamReader(filePath);
                string line;
                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.EndsWith(".mp3") || line.EndsWith(".wav"))
                        {
                            string[] filenamePath = line.Split(new char[] { '\\' });
                            playlistListbox.Items.Add(filenamePath[filenamePath.Length - 1]);
                            player.currentPlaylist.appendItem(player.newMedia(line));
                            filenames.Add(filenamePath[filenamePath.Length - 1]);
                            filepaths.Add(line);
                            this.songsCount++;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    this.oldSongFiles = this.songFiles = filenames.ToArray();
                    this.oldSongPaths = this.songPaths = filepaths.ToArray();
                    playlistListbox.SelectedIndex = 0;
                    this.UpdatePlaylistSongsCount();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loading your playlist. Please check your playlist file and try again.", "Error loading your playlist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ResetPlaylistCollections();
                }
            }
            else if (filePath.EndsWith(".mp3") || filePath.EndsWith(".wav"))
            {
                string[] filenamePath = filePath.Split(new char[] { '\\' });
                filepaths = this.songPaths.ToList();
                filepaths.Add(filePath);
                this.oldSongPaths = this.songPaths = filepaths.ToArray();

                filenames = this.songFiles.ToList();
                filenames.Add(filenamePath[filenamePath.Length - 1]);
                this.oldSongFiles = this.songFiles = filenames.ToArray();

                player.currentPlaylist.appendItem(player.newMedia(filePath));
                playlistListbox.Items.Add(filenamePath[filenamePath.Length - 1]);

                this.UpdatePlaylistSongsCount();
            }
            else
            {
                MessageBox.Show("The file is not in the correct format", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        ///     <description>
        ///         Allows Drag-and-Drop functionality on <see cref="playlistListbox.DragDrop"/> event if a file is being dragged.
        ///     </description>
        /// </summary>
        private void playlistListbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        ///     <description>
        ///         Shows info form which contains information about the software.
        ///     </description>
        /// </summary>
        private void DisplayAboutForm(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        ///     <description>
        ///         Removes the selected song from the WMP Controller and modifies the global arrays that contain file references.
        ///         Updates the songs count using <see cref="UpdatePlaylistSongsCount"/>
        ///         Updates the playlist properly if the currently-playing song is deleted.
        ///     </description>
        ///     <dependencies>
        ///         Using <see cref="Utility"/> service for error handling.
        ///     </dependencies>
        /// </summary>
        private void RemoveSongFromPlaylist(object sender, EventArgs e)
        {
            if (player.currentPlaylist.count == 0)
            {
                UtilityService.HandleEmptyPlaylistException();
            }
            else
            {
                int selectedIndex = playlistListbox.SelectedIndex;
                playlistListbox.Items.RemoveAt(selectedIndex);

                player.currentPlaylist.removeItem(player.currentPlaylist.get_Item(selectedIndex));
                this.oldSongPaths = this.songPaths = this.songPaths.Where((source, index) => index != selectedIndex).ToArray();
                this.oldSongFiles = this.songFiles = this.songFiles.Where((source, index) => index != selectedIndex).ToArray();
                this.UpdatePlaylistSongsCount();
                if (player.currentPlaylist.count != 0)
                {
                    this.UpdateCurrentItem();
                }
            }
        }

        /// <summary>
        ///     <description>
        ///         Adds selected songs to the current playlist. Has option for multiple file selection.
        ///         Supported file formats are <format name=".mp3|.wav"/>
        ///     </description>
        ///     <dependencies>
        ///         Using <see cref="OpenFileDialog"/> for adding the files to the playlist.
        ///     </dependencies>
        /// </summary>
        internal void AddSongsToPlaylist(object sender = null, EventArgs e = null)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (this.oldSongFiles.Length != 0 && this.oldSongPaths.Length != 0)
                    {
                        this.songFiles = this.oldSongFiles.Concat(openFileDialog.SafeFileNames).ToArray();
                        this.songPaths = this.oldSongPaths.Concat(openFileDialog.FileNames).ToArray();
                        this.oldSongFiles = this.songFiles;
                        this.oldSongPaths = this.songPaths;
                    }
                    else
                    {
                        this.songFiles = this.oldSongFiles = openFileDialog.SafeFileNames;
                        this.songPaths = this.oldSongPaths = openFileDialog.FileNames;
                    }
                }
                catch (NullReferenceException)
                {
                    this.songFiles = this.oldSongFiles = openFileDialog.SafeFileNames;
                    this.songPaths = this.oldSongPaths = openFileDialog.FileNames;
                }

                playlistListbox.Items.Clear();

                for (int i = 0; i < this.songFiles.Length; i++)
                {
                    playlistListbox.Items.Add(this.songFiles[i]);
                    player.currentPlaylist.appendItem(player.newMedia(this.songPaths[i]));
                    this.songsCount++;
                }
                playlistListbox.SelectedIndex = 0;

                this.UpdatePlaylistSongsCount();
            }
        }
    }
}
