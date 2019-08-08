using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var consonants = "bcdfghjklmnpqrstvwxz";
            var text = "Tre politibetjenter rykket onsdag ut til et hus i Key Haven i Sanford i Florida etter å ha fått en nødsamtale fra telefonen til en tenåring, skriver Sanford Police Department på Facebook.";

            char lastCharacter = '#';
            for (var i = 0; i < text.Length; i++)
            {
                var character = text[i];
                if (consonants.Contains(character))
                {
                    if (character == lastCharacter)
                    {
                        lastCharacter = '#';
                        for (var j = i+1; j < text.Length; j++)
                        {
                            character = text[j];
                            if (consonants.Contains(character))
                            {
                                if (character == lastCharacter)
                                {
                                    var firstCharacterAfterSecondDoubleConsonant = text[j + 1];
                                    Console.WriteLine("Første tegn etter andre dobbeltkonsonant er: "
                                        +firstCharacterAfterSecondDoubleConsonant);
                                    return;
                                }
                            }
                            lastCharacter = character;
                        }
                    }

                }
                lastCharacter = character;
            }
        }
    }
}
