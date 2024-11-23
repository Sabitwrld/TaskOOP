using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP
{
    public class User : IAccount
    {
        private static int _idcounter = 0;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password {  get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password does not meet the requirements.");
                }
            }
        }

        public User(string fullname, string email, string password)
        {
            Id = _idcounter++;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            foreach (char pass in password)
            {
                if (char.IsUpper(pass)) isUpper = true;
                if (char.IsLower(pass)) isLower = true;
                if (char.IsDigit(pass)) isDigit = true;

            }
            return isUpper && isLower && isDigit;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}, Password: {Password}");
        }
    }

}
