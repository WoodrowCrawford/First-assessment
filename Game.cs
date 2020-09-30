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

        //Performed once when the game begins
        public void Start()
        {
            _area.Area1();
            _player.PrintStats();
            Update();
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
