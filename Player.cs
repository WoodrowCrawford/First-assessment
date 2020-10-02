using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        //Default variables for the Player class
        private int _health;
        private Item[] _inventory;
        private int _gold;
        

        //Default stats for player
        public Player()
        {
            _health = 100;
            _gold = 20;
            _inventory = new Item[3];
        }

        //Makes the player buy an item and put it in their inventory.
        public bool Buy(Item item, int inventorySlot)
        {
            if (_gold >= item.cost)
            {
                _gold -= item.cost;
                _inventory[inventorySlot] = item;
                return true;
            }
            else
            {
                return false;
            }
        }

       
       //Opens the inventory for the player
        public Item[] OpenInventory()
        {
            return _inventory;
        }

        //Prints the current stats for the player
        public void PrintStats()
        {
            Console.WriteLine(" Health: " + _health);
            Console.WriteLine(" Current Gold: " + _gold);
           
        }

        public int GetGold()
        {
            return _gold;
        }
       
        


        
        
    }
}
