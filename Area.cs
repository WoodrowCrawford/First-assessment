using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


namespace HelloWorld
{
    //This is used for the map the player moves around in
    class Area
    {
        private string _areaName;
        private string _enemyName;
        private int _enemyHealth;
        private int _enemyDamage;
        






        public void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        //The first area
        public Area()
        {
            _areaName = "Area 2";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;
            Console.WriteLine("You are in" + _areaName);
            
            Console.WriteLine("It's cold here. You wake up on a cold hard stone floor. " +
                "You can't remember how you got here.");
            Console.WriteLine("You find a " + _enemyName + "!");
            
            Console.WriteLine("There are 3 doors in this room. One on the left, one in front of you, and one to your right.");
        }


        //The second area
        public void Area2()
        {
           

        }


        //The third area
        public void Area3()
        {
            Console.WriteLine("You are now in .");
            ClearScreen();
            Console.WriteLine("This time the room is a bit different. There is a bright light bulb in the room." +
                " It gives off a bright glow. ");
            ClearScreen();
            Console.WriteLine("You see a mouse run past. You try and chase after it but you fail miserably." +
                "The mouse goes in a mouse hole and \n you run into a wall");
            ClearScreen();
            Console.WriteLine("As you recover from your mistake, You notice one door in front of you. " +
                "\n  You start to wonder how many doors are in this area...");
            ClearScreen();


        }


        //The fourth area
        public void Area4()
        {
            Console.WriteLine("You are now in  .");

        }


        //The fifth area
        public void Area5()
        {
            Console.WriteLine("You are in .");
        }


        //The sixth area
        public void Area6()
        {
            Console.WriteLine("You are in .");
        }


        //The seventh area
        public void Area7()
        {
            Console.WriteLine("You are in .");
        }


        //The eighth area
        public void Area8()
        {
            Console.WriteLine("You are in .");
        }


        //The ninth area
        public void Area9()
        {
            Console.WriteLine("You are in .");
        }

        


    }






}
