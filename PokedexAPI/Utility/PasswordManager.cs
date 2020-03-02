using System;
using System.Linq;
using System.Security.Cryptography;

namespace PokedexAPI.Utility
{
    public class PasswordManager
    {
        /// <summary>
        /// Returns the hashed value of the password provided 
        /// </summary>
        public string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 5000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Returns bool if supplied password matches encrypted password when hashed
        /// </summary>
        public bool VerifyPassword(string password, string hashString)
        {
            byte[] hashBytes = Convert.FromBase64String(hashString);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 5000);
            byte[] hash = pbkdf2.GetBytes(20);

            return hash.SequenceEqual(hashBytes.Skip(16));
        }
    }
}
