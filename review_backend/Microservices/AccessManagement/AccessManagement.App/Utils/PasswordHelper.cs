using System;
using System.Linq;
using System.Text;

namespace AccessManagement.App.Utils
{
    public static class PasswordHelper
    {

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException(nameof(password));
            }

            using var hmac = new System.Security.Cryptography.HMACSHA512();

            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            if (storedHash.Length != 64)
                throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");

            if (storedSalt.Length != 128)
                throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt);

            return storedHash.SequenceEqual(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}