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
            string txt = atbash("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.\r\n");
            int num = WordCounter("bomb, nukhba, fighter, rocket, secret");
            output(txt, num);
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

            int cnt = 0;
            for (int i = chars.Length - 1; i >= 0; i--)
            { reverse[cnt] = chars[i];
                cnt++;
            }

            for (int j = 0; j < chars.Length; j++)
            { map[chars[j]] = reverse[j]; }

            foreach (char c in txt)
                if (map.ContainsKey(c))
                { newtxt += map[c]; }
            else { newtxt += c; }
            
            return newtxt;
            }

        static void output(string txt, int num)
        {
            string level = "";
            if (num < 1)
            {  level = "nothing"; }
            else if (num < 6)
            {
                 level = "WARNING";
            }
            else if (num < 11)
            {
                 level = "DANGER!";
            }
            else
            {
                 level = "ULTRA ALERT!";
            }
            Console.WriteLine(level);
            Console.WriteLine($"Decrypted text: {txt}");
            Console.WriteLine($"Number of alerts: {num}.");
        }
        }
    }

