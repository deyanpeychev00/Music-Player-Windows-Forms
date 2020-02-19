using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_MusicPlayer
{
    class Utility
    {
        internal MusicPlayerForm parentForm;
        internal Utility(MusicPlayerForm form)
        {
            parentForm = form;
        }

        /// <summary>
        ///     Updates the main form global songs counter and updates the UI.
        /// </summary>
        /// <param name="songsCount"></param>
        /// <returns value="songsCount" type="int"></returns>
        internal int UpdatePlaylistSongsCount(int songsCount)
        {
            if(songsCount == 1)
            {
                parentForm.songsCountLabel.Text = $"({songsCount} song)";
            }
            else
            {
                parentForm.songsCountLabel.Text = $"({songsCount} songs)";
            }
            return songsCount;
        }

        /// <summary>
        ///     Clears the playlist listbox and the WMP Controller playlist.
        /// </summary>
        /// <returns value="Array.Empty<string>" type="string[]"></returns>
        internal string[] ResetPlaylistCollections()
        {
            parentForm.playlistListbox.Items.Clear();
            parentForm.player.currentPlaylist.clear();

            return Array.Empty<string>();
        }


        /// <summary>
        ///     Shows error message for empty playlist and provides option for adding songs to the playlist.
        /// </summary>
        internal void HandleEmptyPlaylistException()
        {
            DialogResult dialogResult =
                    MessageBox.Show(
                        "Your playlist is empty. Do you want to add songs to your playlist?",
                        "Invalid operation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                parentForm.AddSongsToPlaylist();
            }
        }

        internal void SetPlaylistMode(CheckBox checkBox)
        {
            parentForm.player.settings.setMode(checkBox.Tag.ToString(), checkBox.Checked);
        }
    }
}
