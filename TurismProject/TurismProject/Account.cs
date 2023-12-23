using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismProject
{
    public class Account
    {
        public Account(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        public Account()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
