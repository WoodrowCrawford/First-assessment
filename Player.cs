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
        private string _name;
        private int _health;
        private int _damage;
        private Array[] _inventory;
        private int _gold = 10;
        

        //Default stats for player
        public Player()
        {
            _name = "Traveler";
            _health = 100;
            _damage = 10;
            
        }

       
        //OVerloaded stats for the player
        public Player(string name, int health, int damage)
        {
            _name = "Strong Traveler";
            _health = 200;
            _damage = 30;
        }

        public void PrintStats()
        {
            Console.WriteLine(" Name: " + _name);
            Console.WriteLine(" Health " + _health);
            Console.WriteLine(" Damage " + _damage);
        }
        
    }
}
