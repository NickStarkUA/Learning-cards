using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json;

namespace Learning_cards
{
    internal class Deck
    {
        public string DeckName { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string deckName, List<Card> cards)
        {
            DeckName = deckName;
            Cards = cards;
        }

        public void AddCard(Card card) => Cards.Add(card);

        public void Delete(Card card) => Cards.Remove(card);

        public void Update(Card card)
        {
            foreach (var item in Cards)
            {
                if (item.WordName == card.WordName)
                {
                    item.TranslationValue = card.TranslationValue;
                    break;
                }
            }
        }

        public IEnumerable<Card> Get(int number, int progress)
        {
            if (progress + number > Cards.Count)
            {
                number = Cards.Count - progress;
            }
            for (int i = progress; i < number; i++)
            {
                yield return Cards.ElementAt(i);
            }
        }

        public void Save()
        {
            File.WriteAllText("deck.json", JsonConvert.SerializeObject(Cards));
        }

        public void Load()
        {
            var json = File.ReadAllText("deck.json");
            var cards = JsonConvert.DeserializeObject<List<Card>>(json);
            Cards = cards;
        }

    }
}
