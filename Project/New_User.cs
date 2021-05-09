using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using RestSharp.Extensions;

namespace Project
{
    public partial class New_User : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        public New_User()
        {
            InitializeComponent();
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

        private void configure_firebase()
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private bool existsAlready(string username, string password)
        {
            if (username_textbox.Text == username)
                return true;
            return false;
        }

        private async void create_new_user_Butt_Click(object sender, EventArgs e)
        {
            configure_firebase();

            if (client == null)
            {
                error_label.Text = "Couldn't connect to the database";
            }
            else
            {
                int counter = 1;

                FirebaseResponse response = await client.GetTaskAsync(@"User/" + counter);
                //counter++;

                Boolean ok = true;
                while (response != null)
                {
                    try
                    {
                        User user = response.ResultAs<User>();
                        if (existsAlready(user.Username, user.Password))
                        {
                            error_label.Text = "User Exists Already!";
                            username_textbox.Text = "";
                            password_textbox.Text = "";
                            ok = false;
                            break;
                        }

                        counter++;
                        response = await client.GetTaskAsync(@"User/" + counter);
                    }
                    catch (NullReferenceException exception)
                    {
                        break;
                    }

                }

                if (ok)
                {
                    User user = new User()
                    {
                        Id = counter.ToString(),
                        Username = username_textbox.Text,
                        Password = password_textbox.Text,
                        Type = "client"
                    };

                    response = client.Set("User/" + counter, user);
                    MessageBox.Show("Save Success!");
                    
                    nextForm();
                }

            }

        }


        private void nextForm()
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void back_Butt_Click(object sender, EventArgs e)
        {
            nextForm();
        }
    }
}
