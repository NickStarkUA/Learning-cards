using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_cards
{
    internal class Card
    {
        public string WordName { get; set; } 
        public string TranslationValue { get; set; }

        public Card()
        {

        }
        public Card(string wordName, string translationValue)
        {
            WordName = wordName;
            TranslationValue = translationValue;
        }

        public override string ToString()
        {
            return "Card: " + WordName + " - " + TranslationValue;
        }


    }
}
