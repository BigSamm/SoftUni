namespace Services
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    using Contracts;

    public class HashService : IHashService
    {
        public string Hash(string stringToHash)
        {  
            using (var sha256 = SHA256.Create())
            {
                string hashSalt = "07ADD49BECE94EF09C2C958B89564D79";
                stringToHash += hashSalt;

                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(stringToHash));
                string hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return hash;
            }
        }
    }
}
