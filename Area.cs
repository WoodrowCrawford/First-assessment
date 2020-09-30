using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;


namespace HelloWorld
{
    //This is used for the map the player moves around in
    class Area
    {
        private string _area1;
        private string _area2;
        private string _area3;
        private string _area4;
        private string _area5;
        private string _area6;
        private string _area7;
        private string _area8;
        private string _area9;

        //Names the areas
        public Area()
        {
            _area1 = "Area 1";
            _area2 = "Area 2";
            _area3 = "Area 3";
            _area4 = "Area 4";
            _area5 = "Area 5";
            _area6 = "Area 6";
            _area7 = "Area 7";
            _area8 = "Area 8";
            _area9 = "Area 9";
        }


        public void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        //The first area
        public void Area1()
        {
            Console.WriteLine("You are in " + _area1 + ".");
            ClearScreen();
            Console.WriteLine("You instantly feel the warmth of fire on your skin. You see a fireplace, and in front of it is an...");
            ClearScreen();
            Console.WriteLine("? \n It's an old man in a chair with a game in his hand.");
            ClearScreen();
            Console.WriteLine("He has a GameBoy in his hands and it looks like he's playing Pokemon. \n ... You don't know which one.");
            ClearScreen();
            Console.WriteLine("He notices you after he catches a Pokemon. You have so many questions.");
            Console.ReadLine();
            Console.WriteLine("Old Man: *Ahem...* \n Old Man: Yes hello there fellow traveler. You look confused. Allow me to help you.");
            ClearScreen();
            Console.WriteLine("Old Man: You are in a dungeon. Simple as that. I put you here. \n But don't worry I'm not going to hurt you.");
            Console.ReadLine();
            Console.WriteLine("Old Man: You are a wild pokemon and I caught you...");
            Console.ReadLine();
            Console.WriteLine("Old Man: Now, my dear pokemon, you are to go through this dungeon area for me.");
            ClearScreen();
            Console.WriteLine("Old Man: Proceed to the next door and good luck.");
            Console.ReadLine();


        }


        //The second area
        public void Area2()
        {
            Console.WriteLine("You are in " + _area2 + ".");
            ClearScreen();
            Console.WriteLine("It's cold here. You wake up on a cold hard stone floor. " +
                "You can't remember how you got here.");
            ClearScreen();
            Console.WriteLine("There are 3 doors in this room. One on the left, one in front of you, and one to your right.");

        }


        //The third area
        public void Area3()
        {
            Console.WriteLine("You are now in " + _area3 + ".");
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
            Console.WriteLine("You are now in " + _area4 + ".");

        }


        //The fifth area
        public void Area5()
        {
            Console.WriteLine("You are in " + _area5 + ".");
        }


        //The sixth area
        public void Area6()
        {
            Console.WriteLine("You are in " + _area6 + ".");
        }


        //The seventh area
        public void Area7()
        {
            Console.WriteLine("You are in " + _area7 + ".");
        }


        //The eighth area
        public void Area8()
        {
            Console.WriteLine("You are in " + _area8 + ".");
        }


        //The ninth area
        public void Area9()
        {
            Console.WriteLine("You are in " + _area9 + ".");
        }

        string[,] room = new string[,] { { , 2 }, { 3, 3 } };
        

    }




  
    
}
