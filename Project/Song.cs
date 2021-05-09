using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Song
    {
        private string id;
        private string artist;
        private string emotion;
        private string name;
        private string picture;
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

        public string Id { get => id; set => id = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Emotion { get => emotion; set => emotion = value; }
        public string Name { get => name; set => name = value; }
        public string Picture { get => picture; set => picture = value; }
        public string File1 { get => file1; set => file1 = value; }
        public string File2 { get => file2; set => file2 = value; }
        public string File3 { get => file3; set => file3 = value; }
        public string File4 { get => file4; set => file4 = value; }
        public string File5 { get => file5; set => file5 = value; }
        public string File6 { get => file6; set => file6 = value; }
        public string File7 { get => file7; set => file7 = value; }
        public string File8 { get => file8; set => file8 = value; }
        public string File9 { get => file9; set => file9 = value; }
        public string File10 { get => file10; set => file10 = value; }

        public Song(string id, string artist, string emotion, string name,
            string picture, string file1, string file2, string file3, string file4,
            string file5, string file6, string file7, string file8, string file9, string file10)
        {
            this.id = id;
            this.artist = artist;
            this.emotion = emotion;
            this.name = name;
            this.picture = picture;
            this.file1 = file1;
            this.file2 = file2;
            this.file3 = file3;
            this.file4 = file4;
            this.file5 = file5;
            this.file6 = file6;
            this.file7 = file7;
            this.file8 = file8;
            this.file9 = file9;
            this.file10 = file10;
        }

        public Song() { }


    }
}
