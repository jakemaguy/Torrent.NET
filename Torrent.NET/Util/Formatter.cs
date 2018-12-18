using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentDotNet.Util
{
    public static class Formatter
    {
        public static string BytesToEnglish(long bytes)
        {
            // Took Algorithm From:
            // https://tinyurl.com/ybdrtzur

            int index = (int)Math.Floor(Math.Log(bytes) / Math.Log(1024));
            string[] sizes = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            return Math.Round(bytes / Math.Pow(1024, index), 2).ToString() + " " + sizes[index];
        }

        public static string HashToPercentEncoding(string hash)
        {
            var pe = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                if (i % 2 == 0)
                {
                    pe.Append("%");
                }
                pe.Append(hash[i]);
                //System.Threading.Thread.Sleep(10);
            }

            return pe.ToString();
        }

        public static string HashFormatter(string hash)
        {
            var newhash = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                if (char.IsLetter(hash[i]) && char.IsUpper(hash[i]))
                    newhash.Append(char.ToLower(hash[i]));
                else
                    newhash.Append(hash[i]);
            }

            return newhash.ToString();
        }
    }
}
