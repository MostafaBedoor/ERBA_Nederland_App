using System;
using System.Security.Cryptography;
using System.Text;

namespace DataLayer
{
    public class Cryptor
    {
        //private string DataConnString = "i7y+MJ2JgAYLWtzPeWFO3VyYKYvjB5vBbGFjl7JRhNJCQUHtaQ0hmv529zBuilYE6VyWHPt3Xd7D/n/G4ET61RK5xjmbyLWVi5ZZDLWkenLXw0BhA8AgembHcftTWqheSLX8BajnAPSkutqAYDNc9GgPfHEO8WhjI6y48HqTd5KgbfCgCSN/eiXc9R7XrGAF14rggwa3CRlsIDwIMQFIyw1Y+gr6Ya+gk7cOODoNdb7YBmDegPHZ9Qx3bwralNvXjs0dzKXdb1ex1ssUwxrqealGiHnVvoczWYOexvnu9jvQf7+UI5e57+3ouEahXDtNlHlEAMRRdn34R727oV5nJGc0aKIzKu3003fBHyMb/nYBuuXEp86AW+jE0j6KjUlLvLB2NxJNsJvn2jnVd2oI6/FuznjfEQgm";
        private string _key = "GhYu(!*67hk995#7H$&*^*&$@#$N)*)&7";
        private TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

        public Cryptor()
        {
            TripleDes.Key = TruncateHash(_key, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
        }

        private byte[] TruncateHash(string key, int length)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            // Hash the key.
            byte[] keyBytes = Encoding.Unicode.GetBytes(key);
            byte[] hash = sha1.ComputeHash(keyBytes);
            // Truncate or pad the hash.
            Array.Resize(ref hash, length);
            return hash;
        }

        public string EncryptData(string plaintext)
        {
            try
            {
                // Convert the plaintext string to a byte array.
                byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);
                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the encoder to write to the stream.
                CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                // Use the crypto stream to write the byte array to the stream.
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                encStream.FlushFinalBlock();
                // Convert the encrypted stream to a printable string.
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

        public string DecryptData(string encryptedtext)
        {
            try
            {
                // Convert the encrypted text string to a byte array.
                byte[] encryptedBytes = Convert.FromBase64String(encryptedtext);
                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the decoder to write to the stream.
                CryptoStream decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                // Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                decStream.FlushFinalBlock();
                // Convert the plaintext stream to a string.
                return System.Text.Encoding.Unicode.GetString(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }
    }
}
