using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AuthenticationAndEncryptDecrypt
{
     public class Authentication
    {
        public string Username { get; private set; }

        public string Hashpassword {  get; set; }

        public void Register(string username, string password)
        {
            this.Username = username;
            Hashpassword=HashPassword(password);
        }

        public bool Authenticate(string username, string password)
        {
            return (username == Username && Hashpassword == HashPassword(password));
        }

        public string HashPassword(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] b = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(b);
            }
        }
    }
}
