using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashUtils
{
    public class clsHash
    {
        private string CreateSalt()
        {
            string salt;
            using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[32];
                rng.GetBytes(bytes);
                salt = BitConverter.ToString(bytes);
            }
            return salt;
        }
        public string CreatePassword(string pass)
        {
            string passHashed;
            string saltHash = CreateSalt();
            using(SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(pass + saltHash));
                passHashed = BitConverter.ToString(bytes);
            }
            return passHashed;
        }
        public bool ValidatePass(string passwordUser, string passwordDB)
        {
            if(string.Equals(passwordUser, passwordDB))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
