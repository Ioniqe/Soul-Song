using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        private string id;
        private string username;
        private string password;
        private string type;

        public User(){}

        public User(string id, string username, string password, string type)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
    }
}
