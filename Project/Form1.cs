using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.CodeDom.Compiler;
using Newtonsoft.Json;
using FireSharp.Extensions;
using RestSharp.Extensions;

namespace Project
{
    public partial class Form1 : Form
    {

        //---------------
        // Replace <Subscription Key> with your valid subscription key.
        const string subscriptionKey = "edited";

        // replace <myresourcename> with the string found in your endpoint URL
        const string uriBase =
            "https://eastus.api.cognitive.microsoft.com/face/v1.0/detect";

        //---------------


        int count = 1;
        Camera myCamera = new Camera();

        public Form1()
        {
            InitializeComponent();

            GetInfo();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
        }

        public void GetInfo()
        {
            var cameraResolutions = myCamera.GetSupportedResolutions();

            foreach (var r in cameraResolutions)
            {
                cameraResolution.Items.Add(r);
            }

            if(cameraResolutions.Count >= 6)
                cameraResolution.SelectedIndex = 6;
            else
                cameraResolution.SelectedIndex = 0;

        }

        public void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
                Image img = e.GetFrame();
                pictureBox1.Image = img;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void cameraResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(cameraResolution.SelectedIndex);
        }

        private void captureButt_Click(object sender, EventArgs e)
        {

            string filename = @"bin\Debug\Images\Image" + count.ToString();
            myCamera.Capture(filename);
    
            results.Text = "Captured";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile(@"bin\Debug\Images\Image" + count.ToString() + @".jpg");
            count++;
        }

        private void detect_butt_Click(object sender, EventArgs e)
        {
            //------AI------
            launchEmotionDetection();
        }

        private void launchEmotionDetection()
        {
            int cnt = count - 1;
            string imageFilePath = @"bin\Debug\Images\Image" + cnt.ToString() + @".jpg";

            if (File.Exists(imageFilePath))
            {
                try
                {
                    MakeAnalysisRequest(imageFilePath);

                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                //results.Text = "\nInvalid file path.\nPress Enter to exit...\n";
            }
        }

        async void MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add(
                "edited", subscriptionKey);

            string requestParameters = "returnFaceId=false&returnFaceLandmarks=false" +
            "&returnFaceAttributes=emotion";

            // Assemble the URI for the REST API Call.
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {

                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);

                // Get the JSON response.
                string contentString = await response.Content.ReadAsStringAsync();

                string json_data = format_json(contentString);

                JSON_Data data = JsonConvert.DeserializeObject<JSON_Data>(json_data);

                string emotion = getStrongest_Emotion(data.FaceAttributes.Emotion);
                results.Text = emotion;


                this.Hide();
                //Playlist playlist = new Playlist(emotion, this);
                Playlist playlist = new Playlist(emotion, this);
                playlist.ShowDialog();
                //this.Close();
            }
        }

        private string getStrongest_Emotion(Emotion emotion)
        {
            double strongest = 0;
            string strongest_emotion = "";

            if (emotion.Anger > strongest)
            {
                strongest = emotion.Anger;
                strongest_emotion = "Anger";
            }

            if (emotion.Contempt > strongest)
            {
                strongest =  emotion.Contempt;
                strongest_emotion = "Contempt";
            }

            if (emotion.Disgust > strongest)
            {
                strongest = emotion.Disgust;
                strongest_emotion = "Disgust";
            }

            if (emotion.Fear > strongest)
            {
                strongest = emotion.Fear;
                strongest_emotion = "Fear";
            }

            if (emotion.Happiness > strongest)
            {
                strongest = emotion.Happiness;
                strongest_emotion = "Happiness";
            }

            if (emotion.Neutral > strongest)
            {
                strongest = emotion.Neutral;
                strongest_emotion = "Neutral";
            }

            if (emotion.Sadness > strongest)
            {
                strongest = emotion.Sadness;
                strongest_emotion = "Sadness";
            }

            if (emotion.Surprise > strongest)
            {
                strongest = emotion.Surprise;
                strongest_emotion = "Surprise";
            }

            return strongest_emotion;
        }

        private string format_json(string contentString)
        {
            string new_json = contentString.Replace("[", "").Replace("]", "");

            return new_json;
        }

        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }

        static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");

            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            int offset = 0;
            int indentLength = 3;

            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore) quote = !quote;
                        break;
                    case '\'':
                        if (quote) ignore = !ignore;
                        break;
                }

                if (quote)
                    sb.Append(ch);
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (ch != ' ') sb.Append(ch);
                            break;
                    }
                }
            }

            return sb.ToString().Trim();
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
