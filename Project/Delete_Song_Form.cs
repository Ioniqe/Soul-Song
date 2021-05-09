using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Delete_Song_Form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        private List<Song> playlist = new List<Song>();

        public Delete_Song_Form()
        {
            InitializeComponent();
            Song_Form.PlayClick += UserClickedOnPlay; //listener for the buttons from flowlayoutcontrol

            this.playlist = getSongs();
            loadPlaylist();
        }

        private void UserClickedOnPlay(object sender, EventArgs e)
        {
            configure_firebase();

            Song_Form song_form = (Song_Form)sender;
            Song s = song_form.Song;
            int i = 0;
            int counter = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(Song_Form))
                {
                    Song_Form sf = (Song_Form)control;
                    if (sf == song_form)
                    {
                        int cnt = i + 1;
                        string path = @"Downloaded Songs\" + sf.Song.Name + ".mp3";
                        File.Delete(path);
                        flowLayoutPanel1.Controls.Remove(sf);
                        client.Delete(@"Song/" + cnt);

                        updateAll(i + 1);
                    }

                    i++;
                }
            }
        }

        private void backForm()
        {
            this.Hide();
            Admin_Form l = new Admin_Form();
            l.ShowDialog();
            this.Close();
        }

        private void updateAll(int i)
        {
            configure_firebase();


            for (int j = i; j < this.playlist.Count; j++)
            {
                client.Update("Song/" + j, this.playlist[j]);
            }

            client.Delete("Song/" + this.playlist.Count);

            MessageBox.Show("Done Updating the Database");
            backForm();
        }

        private void configure_firebase()
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private Boolean existsInFile(string name)
        {
            string path = @"Downloaded Songs\" + name + ".mp3";
            return File.Exists(path);
        }

        private string file1;
        private string file2;
        private string file3;
        private string file4;
        private string file5;
        private string file6;
        private string file7;
        private string file8;
        private string file9;
        private string file10;

        private List<Song> getSongs()
        {
            configure_firebase();

            List<Song> playlist = new List<Song>();
            int counter = 1;
            //var response = client.Get(@"Song/" + counter);
            var response = client.Get(@"Song/" + counter + "/Name");

            while (response.Body != "null")
            {
                Song song = new Song();
                string name = response.Body.Trim(new char[] { '"' });

                if (existsInFile(name))
                {
                    string path = @"Downloaded Songs\" + name + ".mp3";
                    byte[] data = File.ReadAllBytes(path);
                    string encoded = Convert.ToBase64String(data);

                    int size = encoded.Length / 10;

                    file1 = encoded.Substring(0, size);
                    file2 = encoded.Substring(size, size);
                    file3 = encoded.Substring(2 * size, size);
                    file4 = encoded.Substring(3 * size, size);
                    file5 = encoded.Substring(4 * size, size);
                    file6 = encoded.Substring(5 * size, size);
                    file7 = encoded.Substring(6 * size, size);
                    file8 = encoded.Substring(7 * size, size);
                    file9 = encoded.Substring(8 * size, size);
                    file10 = encoded.Substring(9 * size);


                    Song newSong = new Song()
                    {
                        Id = counter.ToString(),
                        Artist = client.Get(@"Song/" + counter + "/Artist").Body.Trim(new char[] { '"' }),
                        Emotion = client.Get(@"Song/" + counter + "/Emotion").Body.Trim(new char[] { '"' }),
                        File1 = file1,
                        File2 = file2,
                        File3 = file3,
                        File4 = file4,
                        File5 = file5,
                        File6 = file6,
                        File7 = file7,
                        File8 = file8,
                        File9 = file9,
                        File10 = file10,
                        Name = client.Get(@"Song/" + counter + "/Name").Body.Trim(new char[] { '"' }),
                        Picture = client.Get(@"Song/" + counter + "/Picture").Body.Trim(new char[] { '"' })
                    };

                    song = newSong;
                }
                else
                {
                    var responseSong = client.Get(@"Song/" + counter);
                    song = responseSong.ResultAs<Song>();
                }

                playlist.Add(song);

                counter++;

                //response = client.Get(@"Song/" + counter);
                response = client.Get(@"Song/" + counter + "/Name");

            }

            return playlist;
        }

        //private List<Song> getSongs()
        //{
        //    configure_firebase();

        //    List<Song> playlist = new List<Song>();
        //    int counter = 1;
        //    var response = client.Get(@"Song/" + counter);

        //    while (response.Body != "null")
        //    {
        //        Song song = new Song();

        //        song = response.ResultAs<Song>();
        //        playlist.Add(song);
        //        counter++;

        //        response = client.Get(@"Song/" + counter);
        //    }

        //    return playlist;
        //}

        private int i = 0;
        private Color dark_blue = Color.FromArgb(18, 23, 39);
        private Color light_blue = Color.FromArgb(11, 29, 49);

        private void loadPlaylist()
        {
            foreach (Song song in this.playlist)
            {
                Song_Form sf = new Song_Form(); //display in flowlayoutpanel
                sf.Song = song;
                sf.loadSong();

                if (i % 2 == 0)
                    sf.BackColor = light_blue;
                else
                    sf.BackColor = dark_blue;

                flowLayoutPanel1.Controls.Add(sf);
                i++;
            }
        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maximize_Butt_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void minimize_Butt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
