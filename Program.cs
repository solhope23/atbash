using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static string atbash(string txt)
        {
            char[] chars = {
                'a', 'b', 'c', 'd', 'e', 'f', 'g',
    'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
    'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
    'x', 'y', 'z'};
            char[] reverse = new char[chars.Length];
            Dictionary<char, char> map = new Dictionary<char, char>();
            string newtxt = "";

            for (int i = 0; i < chars.Length; i++)
            { reverse[i] = chars[i]; }

            for (int j = 0; j < chars.Length; j++)
            { map[chars[j]] = reverse[j]; }

            foreach (char c in txt)
                newtxt += map[c];
            
            return newtxt;
            }
        }
    }

