using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismProject
{
    internal class AccountManagement
    {
        private List<Account> accounts;

        public AccountManagement()
        {
            // TODO: Read accs from file;
            accounts = new List<Account>() 
            { 
                new Account(123, "Gio", "paroli123"),
                new Account(124, "Sandro", "paroli124"),
            };
        }

        public Account Login(int Id, string Password) {
            return accounts.Where(acc=>acc.Id == Id).Where(acc=> acc.Password == Password).FirstOrDefault();
        }

    }
}
