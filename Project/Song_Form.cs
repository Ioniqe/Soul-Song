using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Song_Form : UserControl
    {
        private Song song;
        private Boolean playing = false;

        public static event EventHandler PlayClick;
        public Song_Form()
        {
            InitializeComponent();
            songPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            bunifuImageButton1.Click += ClickedButton;
        }

        private void ClickedButton(object sender, EventArgs e)
        {
            if (PlayClick != null)
                PlayClick(this, e);
        }

        public void loadSong()
        {
            songLabel.Text = song.Name;
            artistLabel.Text = song.Artist;
          
            songPicture.Image = getImage(song.Picture);
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

        internal Song Song { get => song; set => song = value; }
        public bool Playing { get => playing; set => playing = value; }

        public void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.playing = true;
        }

        //public void changeButt_toPlaying()
        //{
        //    this.bunifuImageButton1.Image = new Bitmap(@"icons\transparent.png");
        //}

        //public void changeButt_toPaused()
        //{
        //    this.bunifuImageButton1.Image = new Bitmap(@"icons\play-button.png");
        //}

        public void makeButt_invisible()
        {
            this.bunifuImageButton1.Visible = false;
        }

        public void makeButt_visible()
        {
            this.bunifuImageButton1.Visible = true;
            this.bunifuImageButton1.Image = new Bitmap(@"icons\play-button.png");
        }
    }
}
