using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_MusicPlayer
{
    public partial class MusicPlayer : Form
    {   
        List<Song> _songs;   
       
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true; 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                

                //Add song to List
                AddSongtoList(dlg.SafeFileNames.ToList(), dlg.FileNames.ToList());
            }
        }
        private void AddSongtoList(List<string> names,List<string> paths)
        {
            if (_songs == null)
            {
                _songs = new List<Song>();
            }
            //if (_songPaths == null)
            //{
            //    _songPaths = new List<string>();
            //}
            foreach (var item in names)
         
                {                
                    if (!ExistsOnList(item))
                    
                    _songs.Add(new Song(item,GetPath(item,paths)));  
                    
                    
                
                }
               refreshList();   
         }

        
        private bool ExistsOnList(string song)
        {
            bool exists = false;    
            foreach (var item in _songs) {
                if (item.Name == song) { 
                    exists=true; 
                }
                
              }return exists;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private string GetPath(string filename,List<string> songsPath=null)
        {
            string actualPath = string.Empty;
            if (songsPath == null)
            { foreach (var song in _songs)
                {
                    if (song.Name == filename) 
                        actualPath= song.Path;
                } 
            }
            else 
            { 
                foreach(var path in songsPath)
                {
                if (path.Contains(filename)) {
                    actualPath = path;
                   }
                
                } 
            }
           
            return actualPath;
        }
        private void songsList_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = GetPath(songsList.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Song songToRemove = null;

            foreach (var song in _songs)
            {
                if (song.Name == songsList.Text)
                {
                    songToRemove = song;
                }
            }
            if (songToRemove != null){
            _songs.Remove(songToRemove);
            }
           
            refreshList();

        }
        private void refreshList()
        {
            List<String> songNames = new List<string>();
            foreach (var item in _songs) 
                songNames.Add(item.Name);
            songsList.DataSource = null;
            songsList.DataSource = songNames;
        }
    }
}
