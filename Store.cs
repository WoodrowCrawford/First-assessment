using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Store
    {
        private int _gold;
        private Item[] _inventory;

        
        //Sets up the store for use.
        
        public Store()
        {
            _gold = 0;
            _inventory = new Item[3];
        }
        
        public Store(Item[] items)
        {
            _gold = 0;
            _inventory = items;
        }

        public bool Sell(Player player, int itemNum, int playerInvNum)
        {
            Item itemBuying = _inventory[itemNum];
            if (player.Buy(itemBuying, playerInvNum))
            {
                _gold += itemBuying.cost;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
