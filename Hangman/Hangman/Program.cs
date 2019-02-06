using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public static void Main(string[] args)
        {

            string theWordToGuess;
            Char theChosenLetter;
            bool lettersGuessed = bool[26];
            for (int i = 0; i < lettersGuessed.Length; i++)
            {
                lettersGuessed[i] = false;
            }
        }
    }
}
