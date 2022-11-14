using System;
using System.Collections.Generic;

namespace Hilo
{
    public class Deck 
    {
        // Scope: class, or in other words, global to this class
        public List<int> _cards;
        // Constructor
        public Deck()
        {
            int card = 5;
            _cards = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13};
        }
    }
}
