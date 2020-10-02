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
        private Map _map = new Map();
        
       
        
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

       


        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Hello there... \n You wake up in a dark area...");
            Console.ReadLine();
            Update();
        }

        //Repeated until the game ends
        public void Update()
        {
            _area.Area2();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
