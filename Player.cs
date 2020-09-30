using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        //Default variables for the Player class
        private string _name;
        private int _health;
        private int _damage;
        private Item[] _inventory;
        private int _gold;
        

        //Default stats for player
        public Player()
        {
            _name = "Traveler";
            _health = 100;
            _damage = 10;
            _gold = 20;
            
        }

       
       //Opens the inventory for the player
        public void OpenInventory(Item[] _inventory)
        {
            string[] Item = { "Gloves", "More gloves", "A toy" };
        }

        //Prints the current stats for the player
        public void PrintStats()
        {
            Console.WriteLine(" Health: " + _health);
            Console.WriteLine(" Damage: " + _damage);
            Console.WriteLine(" Current Gold: " + _gold);
        }
        
    }
}
