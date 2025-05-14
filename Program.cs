using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atbash
{
    internal class Program
    {


        static int WordCounter(string message, string[] words)
        {
            string[] message1 = message.Split(' ');

            int Counter = 0;

            foreach (string word in message1)
            {
                foreach (string word2 in words)
                {
                    if (word == word2)
                    {
                        Counter++;
                    }
                }
            }
            return Counter;
        }


        static void Main(string[] args)
        {
        }
    }
}
