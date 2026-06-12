using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurePasswordGenerator
{
    public static class PasswordEngine
    {
        public static string Generate(int blocks, int charsPerBlock, string separator, bool upper, bool lower, bool digits, bool special, bool umlauts)
        {
            string charSet = "";
            if (upper) charSet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (lower) charSet += "abcdefghijklmnopqrstuvwxyz";
            if (digits) charSet += "0123456789";
            if (special) charSet += "!@#$%^&*()-_=+[]{}|;:,.<>?";
            if (umlauts) charSet += "ÄÖÜäöüß";

            if (string.IsNullOrEmpty(charSet)) return "Fehler: Kriterien wählen!";

            List<string> blockList = new List<string>();
            using (var rng = RandomNumberGenerator.Create())
            {
                for (int b = 0; b < blocks; b++)
                {
                    byte[] data = new byte[charsPerBlock];
                    rng.GetBytes(data);
                    StringBuilder sb = new StringBuilder();
                    foreach (byte bVal in data)
                        sb.Append(charSet[bVal % charSet.Length]);
                    blockList.Add(sb.ToString());
                }
            }
            return string.Join(separator, blockList);
        }
    }
}