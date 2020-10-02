using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{


    //Defines the item variable
    public struct Item
    {
        public string itemName;
        public int cost;
        
        
    }
    class Game
    {
        //Makes new varables
        private bool _gameover;
        private Player _player;
        private Store _store;
        private Item[] _storeInventory;
        private Item _key;
        private Item _teddyBear;
        private Item _ps5;
        private Area _area = new Area();
        
        //Run the game
        public void Run()
        {
            Start();

            while(_gameover == false)
            {
                Update();
            }
            End();
        }

        //Gives the items descriptions and price tags.
        public void CreateItems()
        {
            _key.itemName = "Key";
            _key.cost = 2;
            _teddyBear.itemName = "Teddy bear";
            _teddyBear.cost = 4;
            _ps5.itemName = "PS5";
            _ps5.cost = 40;
        }


        //Prints the inventory.
        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].itemName + inventory[i].cost);
            }
        }

        private void OpenStore()
        {
            Console.WriteLine("Welcome to the game! Buy something before you start!");
            PrintInventory(_storeInventory);

            char input = Console.ReadKey().KeyChar;
            int itemNum = -1;
            switch (input)
            {
                case '1':
                    {
                        itemNum = 0;
                        break;
                    }
                case '2':
                    {
                        itemNum = 1;
                        break;
                    }
                case '3':
                    {
                        itemNum = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
                    
            }
            
            if (_player.GetGold() < _storeInventory[itemNum].cost)
            {
                Console.WriteLine("Yeahh... no. You are broke.");
                return;
            }

            StreamWriter writer;
            Console.WriteLine("Where do you want to put this item?");
            PrintInventory(_player.OpenInventory());
            input = Console.ReadKey().KeyChar;

            int playerInvNum = -1;

            switch (input)
            {
                case '1':
                    {
                        playerInvNum = 0;
                        Console.WriteLine("Thank You!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case '2':
                    {
                        playerInvNum = 1;
                        Console.WriteLine("Thank You!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case '3':
                    {
                        playerInvNum = 2;
                        Console.WriteLine("Thank You!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            
        }


        //Performed once when the game begins
        public void Start()
        {
            _gameover = false;
            _player = new Player();
            CreateItems();
            _storeInventory = new Item[] { _key, _teddyBear, _ps5 };
            _store = new Store(_storeInventory);
            
            Console.WriteLine("Hello there... \n You wake up in a dark area...");
            Console.ReadLine();
            Update();
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenStore();
            _area.Area2();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
