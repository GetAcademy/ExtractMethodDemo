using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethodDemo
{
    class Program
    {
        static int FindNextDoubleConsonant(int startPos, string text)
        {
            var lastCharacter = '#';
            for (var i = 0; i < text.Length; i++)
            {
                var character = text[i];
                if (IsConsonant(character) && character == lastCharacter) return i;
                lastCharacter = character;
            }
            return -1;
        }

        private static bool IsConsonant(char character)
        {
            var consonants = "bcdfghjklmnpqrstvwxz";
            return consonants.Contains(character);
        }


        static void Main(string[] args)
        {
            var text = "Tre politibetjenter rykket onsdag ut til et hus i Key Haven i Sanford i Florida etter å ha fått en nødsamtale fra telefonen til en tenåring, skriver Sanford Police Department på Facebook.";
            var i1 = FindNextDoubleConsonant(0, text);
            var i2 = FindNextDoubleConsonant(i1, text);
            Console.WriteLine("Første tegn etter andre dobbeltkonsonant er: " + text[i2 + 1]);
        }
    }
}
