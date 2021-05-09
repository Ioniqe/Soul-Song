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

    public partial class Login : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "edited",
            BasePath = "edited"
        };

        IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
        }

        private void nextForm()
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Dispose();

        }

        private void verifyLogin(User user)
        {
            if (username_textbox.Text == user.Username && password_textbox.Text == user.Password)
            {
                if(user.Type == "admin")
                {
                    this.Hide();
                    Admin_Form form = new Admin_Form();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    nextForm();
                }
                    

            }

        }

        private async void confirm_Butt_Click(object sender, EventArgs e)
        {

            configure_firebase();

            if (client == null)
            {
                error_label.Text = "Couldn't connect to the database";
            }
            else
            {

                //string username, password;
                int counter = 1;
                //FirebaseResponse response = client.Get(@"User/" + counter++);

                FirebaseResponse response = await client.GetTaskAsync(@"User/" + counter);
                counter++;


                while (response != null)
                {
                    try
                    {
                        User user = response.ResultAs<User>();
                        verifyLogin(user);

                        response = await client.GetTaskAsync(@"User/" + counter);
                        counter++;
                    }
                    catch (NullReferenceException exception)
                    {
                        break;
                    }

                }

                error_label.Text = "Wrong input";
            }

        }

        private void close_Butt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maximize_Butt_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
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

        private void new_user_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_User new_user = new New_User();
            new_user.ShowDialog();
            this.Close();
        }
    }
}
