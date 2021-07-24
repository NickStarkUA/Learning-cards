using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_cards
{
    internal class User
    {
        public string Name { get; private set; }
        private int _number = 1;
        public Dictionary<string, int> DeckProgree { get; set; }

        public User(string name, int number = 1)
        {
            Name = name;
            _number = number;
        }

        public void SetNumber(int number)
        {
            _number = number;
        }
    }
}
