using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using RestSharp.Extensions;

using System.Net;
using System.Media;
using Firebase.Storage;
using WMPLib;
using System.Threading;

namespace Project
{

    public partial class Playlist : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();

        private Song currentlyPlaying;
        private int currentlyPlaying_pos = 0;

        private List<Song> playlist = new List<Song>();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        Form1 captured;
        string emotion;

        public Playlist(string emotion, Form1 form1)
        {
            InitializeComponent();
            results.Text = emotion;
            captured = form1;
            this.emotion = emotion;

            Song_Form.PlayClick += UserClickedOnPlay; //listener for the buttons from flowlayoutcontrol

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.playlist = getSongs();
            loadPlaylist(); //also play song

        }

        private void UserClickedOnPlay(object sender, EventArgs e)
        {
            //slider.Value = 0;

            pauseSong(currentlyPlaying_pos);
            Song_Form song_form = (Song_Form)sender;
            playCurrentSong(song_form);

            int i = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(Song_Form))
                {
                    Song_Form sf = (Song_Form)control;
                    Song s = sf.Song;
                    if (sf == song_form)
                    {
                        currentlyPlaying_pos = i;
                    }
                    i++;
                }
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

        private void downloaded(Song song)
        {
            string encoded = song.File1 + song.File2 + song.File3 +
                song.File4 + song.File5 + song.File6 + song.File7 +
                song.File8 + song.File9 + song.File10;
            byte[] convertedData = Convert.FromBase64String(encoded);

            string path = @"Downloaded Songs\" + song.Name + ".mp3";

            if (!File.Exists(path))
                File.WriteAllBytes(path, convertedData);
        }

        private void back_Butt_Click(object sender, EventArgs e)
        {
            player.controls.stop();

            this.Hide();
            captured.Show();
            this.Close();
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

            var responseName = client.Get(@"Song/" + counter + "/Name");
            var responseEmotion = client.Get(@"Song/" + counter + "/Emotion");

            while (responseName.Body != "null" && responseEmotion.Body != "null")
            {
                Song song = new Song();
                string name = responseName.Body.Trim(new char[] { '"' });
                string currEmotion = responseEmotion.Body.Trim(new char[] { '"' });

                if (currEmotion == emotion)
                {
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
                            Emotion = currEmotion,
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
                            Name = name,
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
                }

                
                counter++;

                responseName = client.Get(@"Song/" + counter + "/Name");
                responseEmotion = client.Get(@"Song/" + counter + "/Emotion");

            }

            return playlist;
        }

        private int i = 0;
        private Color dark_blue = Color.FromArgb(18, 23, 39);
        private Color light_blue = Color.FromArgb(11, 29, 49);

        private void loadPlaylist()
        {
            foreach (Song song in this.playlist)
            {
                if (i == 0) //also play it
                {
                    pictureBox1.Image = getImage(song.Picture);
                    songLabel.Text = song.Name;
                    artistLabel.Text = song.Artist;
                    currentlyPlaying = song;

                    downloaded(song);

                    string path = @"Downloaded Songs\" + song.Name + ".mp3";
                    player.URL = path;
                    //player.controls.play(); //play the song

                    Song_Form sf = new Song_Form(); //display in flowlayoutpanel
                    sf.Song = song;
                    sf.loadSong();

                    sf.makeButt_invisible();

                    if (i % 2 == 0)
                        sf.BackColor = light_blue;
                    else
                        sf.BackColor = dark_blue;


                    flowLayoutPanel1.Controls.Add(sf);
                }
                else//just add it into the list
                {
                    Song_Form sf = new Song_Form(); //display in flowlayoutpanel
                    sf.Song = song;
                    sf.loadSong();

                    if (i % 2 == 0)
                        sf.BackColor = light_blue;
                    else
                        sf.BackColor = dark_blue;

                    flowLayoutPanel1.Controls.Add(sf);
                }

                i++;
            }
        }

        private Image getImage(string img)
        {
            Image image;
            byte[] array = Convert.FromBase64String(img);
            using (var ms = new MemoryStream(array))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        Boolean paused = false;
        private void play_Click(object sender, EventArgs e)
        {
            if (!paused) //playing
            {
                player.controls.pause();
                paused = true;
                play.Image = new Bitmap(@"icons\play.png");
            }
            else//paused
            {
                player.controls.play();
                paused = false;
                play.Image = new Bitmap(@"icons\pause.png");

            }

        }

        private void playCurrentSong(Song_Form sf)
        {
            Song song = sf.Song;
            sf.makeButt_invisible();

            pictureBox1.Image = getImage(song.Picture);
            songLabel.Text = song.Name;
            artistLabel.Text = song.Artist;
            currentlyPlaying = song;

            downloaded(song);

            string path = @"Downloaded Songs\" + song.Name + ".mp3";
            player.URL = path;
            player.controls.play();

        }

        private void pauseSong(int pos)
        {
            int i = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(Song_Form))
                {
                    if (i == pos)
                    {
                        Song_Form sf = (Song_Form)control;
                        sf.makeButt_visible();
                        return;
                    }

                    i++;
                }
            }
        }

        private void skip_next_Click(object sender, EventArgs e)
        {
            //slider.Value = 0;

            currentlyPlaying_pos++;

            int i = 0;
            if (currentlyPlaying_pos == playlist.Count)
            {
                currentlyPlaying_pos = 0;
                pauseSong(playlist.Count - 1);
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(Song_Form))
                {
                    Song_Form sf = (Song_Form)control;

                    if (i == currentlyPlaying_pos - 1)
                    {
                        pauseSong(currentlyPlaying_pos - 1);
                    }

                    else if (i == currentlyPlaying_pos)
                    {
                        playCurrentSong(sf);

                        break;
                    }

                    i++;
                }

            }

        }

        private void skip_back_Click(object sender, EventArgs e)
        {
            //slider.Value = 0;

            currentlyPlaying_pos--;

            if (currentlyPlaying_pos == playlist.Count - 1)
            {
                pauseSong(0);
            }
            else if (currentlyPlaying_pos == -1)
            {
                pauseSong(0);
                currentlyPlaying_pos = playlist.Count - 1;
            }
            else
            {
                pauseSong(currentlyPlaying_pos + 1);
            }

            int i = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(Song_Form))
                {
                    Song_Form sf = (Song_Form)control;

                    if (i == currentlyPlaying_pos)
                    {
                        playCurrentSong(sf);
                        break;
                    }

                    i++;
                }

            }
        }

        private void changeValue(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
        }

    }
}
