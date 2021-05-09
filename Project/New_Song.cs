using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
using WMPLib;

namespace Project
{
    public partial class New_Song : Form
    {
        //private Song song = new Song();
        //private WMPLib.WindowsMediaPlayer player;

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

        private string image;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        public New_Song()
        {
            InitializeComponent();
            GetInfo();
        }

        public void GetInfo()
        {
            emotionResolution.Items.Add("Happiness");
            emotionResolution.Items.Add("Anger");
            emotionResolution.Items.Add("Contempt");
            emotionResolution.Items.Add("Disgust");
            emotionResolution.Items.Add("Fear");
            emotionResolution.Items.Add("Neutral");
            emotionResolution.Items.Add("Sadness");
            emotionResolution.Items.Add("Surprise");

            emotionResolution.SelectedIndex = 0;
        }

        private void configure_firebase()
        {
            client = new FireSharp.FirebaseClient(config);
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


        private void upload_song_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"";
            ofd.Title = "Select Image";
            ofd.Filter = "MP3 files|*.mp3";

            string song_string = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                song_string = ofd.FileName;

                byte[] data = File.ReadAllBytes(song_string);
                string encoded = Convert.ToBase64String(data); //asta trebe pus in Firebase

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
            }
            else if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                file1 = "";
                file2 = "";
                file3 = "";
                file4 = "";
                file5 = "";
                file6 = "";
                file7 = "";
                file8 = "";
                file9 = "";
                file10 = "";
            }


        }

        public static byte[] imageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void upload_picture_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"";

            ofd.Title = "Select Image";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";

            Image img;
            byte[] arr;
            string image_string = "";
            string final = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image_string = ofd.FileName;

                img = new Bitmap(image_string);

                arr = imageToByteArray(img); // from image to byte array

                //from byte array to string
                final = Convert.ToBase64String(arr);

                //-------convert from byte array to picture
                using (var ms = new MemoryStream(arr))
                {
                    Image result = Image.FromStream(ms);

                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Image = result;
                }
            }
            else if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                image_string = @"";

                img = new Bitmap(image_string);

                arr = imageToByteArray(img); // from image to byte array

                //from byte array to string
                final = Convert.ToBase64String(arr);

                //-------convert from byte array to picture
                using (var ms = new MemoryStream(arr))
                {
                    Image result = Image.FromStream(ms);

                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Image = result;
                }
            }



            //song.Picture = final;
            image = final;
        }

        private void back_to_admin()
        {
            this.Hide();
            Admin_Form form = new Admin_Form();
            form.ShowDialog();
            this.Close();

        }

        private async void save_Butt_Click(object sender, EventArgs e)
        {
            int counter = 1;
            Boolean exists = false;
            configure_firebase();
            FirebaseResponse response = await client.GetTaskAsync(@"Song/" + counter);

            while (response != null)
            {
                try
                {
                    Song curr_song = response.ResultAs<Song>();


                    if (curr_song.Name == name_textbox.Text)
                    {
                        exists = true;
                        break;
                    }


                    counter++;
                    response = await client.GetTaskAsync(@"Song/" + counter);
                }
                catch (NullReferenceException exception)
                { break; }

            }

            Song song = new Song()
            {
                Id = counter.ToString(),
                Artist = artist_textbox.Text,
                Emotion = emotionResolution.Text,
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
                Name = name_textbox.Text,
                Picture = image
            };

            if (exists)
            {
                MessageBox.Show("Song Already in the Database!");
            }
            else
            {
                response = client.Set("Song/" + counter, song);
                MessageBox.Show("Save Success!");

                back_to_admin();
            }

        }

        private void cancel_Butt_Click(object sender, EventArgs e)
        {
            back_to_admin();
        }
    }
}
