using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{


    //Defines the item variable
    public struct Item
    {
        public string itemName;
        public int bonusDamage;
        public string descripion;
    }
    class Game
    {
        //Calls created varables
        private bool _gameover = false;
        private Player _player = new Player();
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

       //Gets various inputs from the player. Used to move between areas.
        public void GetInput(string option1, string option2, string option3, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                Console.WriteLine("1. " + option1, "Pick a room");
                Console.WriteLine("2. " + option2, "Pick a room");
                Console.WriteLine("3. " + option3, "Pick a room");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(input == '1')
                {
                    Console.WriteLine("You take the door to your left.");
                    _area.Area1();
                    

                }
                if (input == '2')
                {
                    Console.WriteLine("You walk straight ahead.");
                    _area.Area2();
                }
                if (input == '3')
                {
                    Console.WriteLine("You take the door to your right.");
                    _area.Area3();
                }
                else if (input != '1' && input != '2' && input != '3')
                    Console.WriteLine("Please pick one of the available areas.");
                
            }
        }


        public void GetInput(string option1, string query)
        {
            char input = ' ';
            while (input != '1')
            {
                Console.WriteLine("1. " + option1 , "Go in the room.");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(input == '1')
                {
                    Console.WriteLine("You continue your journey. That old man is something else.");
                    
                }
            }
        }

        //Performed once when the game begins
        public void Start()
        {
            
            Update();
        }

        //Repeated until the game ends
        public void Update()
        {
            _area.Area2();
            Console.WriteLine("Pick a room");
            GetInput("Room 1", "Room 2", "Room 3", "Pick a room"); 
            
            _player.PrintStats();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
