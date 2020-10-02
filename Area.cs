using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using System.Security.Authentication;
using System.Text;


namespace HelloWorld
{
    //This is used for the map the player moves around in.
    class Area
    {
        private string _areaName;
        private string _enemyName;
        private int _enemyHealth;
        private int _enemyDamage;





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
                if (input == '1')
                {
                    Console.WriteLine("You go to room 1.");
                    Area1();
                }
                if (input == '2')
                {
                    Console.WriteLine("You go to room 5.");
                    Area5();
                }
                if (input == '3')
                {
                    Console.WriteLine("You go to room 3.");
                    Area3();
                }
                else if (input != '1' && input != '2' && input != '3')
                    Console.WriteLine("Please pick one of the available areas.");

            }
        }


        //Gets input from the player when there is only one option.
        //Used to make the player feel like they have some freedom.
        public void GetInput(string option1, string query)
        {
            char input = ' ';
            while (input != '1')
            {
                Console.WriteLine("1. " + option1, "Go in the room.");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == '1')
                {
                    Console.WriteLine("You continue your journey. That old man is something else.");
                    Area6();
                }
                else if (input != '1')
                {
                    Console.WriteLine("Old Man: YARRRR! GO ON AND GIT ALREADY!!");

                }
            }
        }


        public void GetInputArea3(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("1. " + option1, "Pick a room");
                Console.WriteLine("2. " + option2, "Pick a room");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            if (input =='1')
            {
                Console.WriteLine("You decide to go to room 2.");
                Area2();
            }
            if (input == '2')
            {
                Console.WriteLine("You decide to go to room 4.");
                Area4();
            }
            else if (input != '1' && input != '2')
            {
                Console.WriteLine("Please pick a room.");
            }
        }

        //Picks what door to go into in area 4.
        public void GetInputArea4(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("1. " + option1, "Pick a room");
                Console.WriteLine("2. " + option2, "Pick a room");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input =='1')
                {
                    Console.WriteLine("You decide to go to room 5.");
                    Area5();
                }
                if (input =='2')
                {
                    Console.WriteLine("You decide to go to room 3.");
                    Area3();
                }
                else if (input != '1' && input != '2')
                {
                    Console.WriteLine("Please select a room.");
                }
            }
        }

        //Picks what door to go into in area 5.
        public void GetInputArea5(string option1, string option2, string option3, string option4, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2' && input !='3' && input != '4')
            {
                Console.WriteLine("1. " + option1, "Pick a room");
                Console.WriteLine("2. " + option2, "Pick a room");
                Console.WriteLine("3. " + option3, "Pick a room");
                Console.WriteLine("4. " + option4, "Pick a room");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input =='1')
                {
                    Console.WriteLine("You go to room 6.");
                    Area6();
                }
                if (input =='2')
                {
                    Console.WriteLine("You decide to go to room 8.");
                    Area8();
                }
                if (input =='3')
                {
                    Console.WriteLine("You go to room 4.");
                    Area4();
                }
                if (input == '4')
                {
                    Console.WriteLine("You decide to go to room 2.");
                    Area2();
                }
                else if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Please pick a room.");
                }

            }
        }
        //Picks what door to go into in area 6.
        public void GetInputArea6(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("1. " + option1, "Pick a room");
                Console.WriteLine("2. " + option2, "Pick a room");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == '1')
                {
                    Console.WriteLine("You decide to go to room 7. \n " +
                        "Maybe you'll find a way out.");
                    Area7();
                }
                if (input == '2')
                {
                    Console.WriteLine("You go to room 5.");
                    Area5();
                }
                else if (input != '1' && input != '2')
                {
                    Console.WriteLine("You really don't want to go back in that room with that old man \n" +
                        "You should probably pick another room to go into.");
                }
            }
        }


        //Picks what door to go into in area 7.
        public void GetInputArea7(string option1, string query)
        {
            char input = ' ';
            while (input != '1')
            {
                Console.WriteLine("1. " + option1, "Go in the next room.");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == '1')
                {
                    Console.WriteLine("You go to room 8.");
                    Area8();
                }
                else if (input != '1')
                {
                    Console.WriteLine("You need to get out of here!");
                }
            }
        }

        //Picks what door to go into in area 8.
        public void GetInputArea8(string option1, string option2, string option3, string query)
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
                if (input == '1')
                {
                    Console.WriteLine("You go to room 9.");
                    Area9();
                }
                if (input == '2')
                {
                    Console.WriteLine("You go in room 5.");
                    Area5();
                }
                if (input == '3')
                {
                    Console.WriteLine("You decide to go to room 7.");
                    Console.ReadLine();
                    Area7();
                }
            }
        }

        //Clears screen
        public void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }


        //The first area
        public void Area1()
        {
            _areaName = "Area 1";
            _enemyName = "Earl";
            _enemyHealth = 50;
            _enemyDamage = 10;

            
            ClearScreen();
            Console.WriteLine("You start to feel warm and fuzzy. \n " +
                "In front of you is a fireplace.");
            Console.ReadLine();
            Console.WriteLine("In front of the fireplace is an old man in a chair. But... \n " +
                "It appeaers he's playing a GameBoy...");
            ClearScreen();
            Console.WriteLine("After a while of looking at him, You here the sound of a Pokemon being caught. \n " +
                "He then stars to look around and notices you staring at him.");
            Console.ReadLine();
            Console.WriteLine("???: Ah yes, you have finally awoken traveler... ");
            ClearScreen();
            Console.WriteLine("??? : Allow me to introduce myself. ");
            Console.WriteLine(_enemyName + ": My name is " + _enemyName + ".");
            Console.ReadLine();
            Console.WriteLine("Earl: I will explain your situation right now. \n" +
                "Earl: Right now you are in a dungeon.");
            Console.ReadLine();
            Console.WriteLine("Earl: I captured you and brought you here \n " +
                "Earl: You are my pokemon and I am your pokemon master. \n" +
                "Earl: You are to make your way through this dungeon.");
            ClearScreen();
            Console.WriteLine("Earl: And don't worry I'm not going to hurt you.");
            Console.ReadLine();
            Console.WriteLine("Earl: Anyways go on into the next room and good luck.");
            ClearScreen();
            Console.WriteLine("Go forward");
            GetInput("Room 6", "Go forward");


        }


        //The second area
        //The Player starts here
        public void Area2()
        {
            _areaName = "Area 2";
            _enemyName = "enemies";
            _enemyHealth = 50;
            _enemyDamage = 10;


            
            Console.WriteLine("You are in " + _areaName);
            Console.WriteLine("It's cold here. You wake up on a cold hard stone floor. " +
                "You can't remember how you got here.");
            Console.WriteLine("There are no " + _enemyName + " in " + _areaName + "!");

            Console.WriteLine("There are 3 doors in this room. One on the left, one in front of you, and one to your right.");
            ClearScreen();
            Console.WriteLine("Pick a room");
            GetInput("Room 1", "Room 5", "Room 3", "Pick a room");
        }


        //The third area
        public void Area3()
        {

            _areaName = "Area 3";
            _enemyName = "none";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            ClearScreen();
            Console.WriteLine("This time the room is a bit different. There is a bright light bulb in the room." +
                " It gives off a bright glow. ");
            ClearScreen();
            Console.WriteLine("You see a mouse run past. You try and chase after it but you fail miserably." +
                "The mouse goes in a mouse hole and \n you run into a wall");
            ClearScreen();
            Console.WriteLine("As you recover from your mistake" +
                "\n  You start to wonder how many doors are in this area...");
            ClearScreen();
            Console.WriteLine("There is a door in front of you.");
            GetInputArea3("Room 2", "Room 4", "Pick a room.");
            

        }


        //The fourth area
        public void Area4()
        {
            _areaName = "Area 4";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            Console.ReadLine();
            Console.WriteLine("The door in front of you is sealed with iron. \n" +
                "However, there is a room to your left.");
            Console.WriteLine("Please pick a room.");
            GetInputArea4("Room 5", "Room 3", "Please pick a room.");
        }


        //The fifth area
        public void Area5()
        {
            _areaName = "Area 5";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            Console.ReadLine();
            Console.WriteLine("In front of you are three doors again. One on the left," +
                "one in front of you and one on your right");
            Console.WriteLine("Pick a room.");
            GetInputArea5("Room 6", "Room 8", "Room 4", "Go back", "Pick a room");
        }


        //The sixth area
        public void Area6()
        {
            _areaName = "Area 6";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            Console.ReadLine();
            Console.WriteLine("There are two doors in this room. \n " +
                "One in front and one on your right.");
            Console.WriteLine("Pick a room.");
            GetInputArea6("Room 7", "Room 5", "Pick a room.");

        }


        //The seventh area
        public void Area7()
        {
            _areaName = "Area 7";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            Console.WriteLine("This area looks nice.");
            Console.ReadLine();
            Console.WriteLine("There is only one door here to your right.");
            Console.WriteLine("Go in the next room");
            GetInputArea7("Room 8", "Go in the next room");
        }


        //The eighth area
        public void Area8()
        {
            _areaName = "Area 8";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
            Console.ReadLine();
            Console.WriteLine("This room looks pretty different from the rest. \n" +
                "Mostly because right in front of you is a door with a boss icon lock.");
            Console.WriteLine("Pick a room");
            GetInputArea8("Room 9", "Room 5", "Go Back", "Pick a room");
        }


        //The ninth area
        public void Area9()
        {
            _areaName = "The Final room";
            _enemyName = "Slime";
            _enemyHealth = 50;
            _enemyDamage = 10;


            ClearScreen();
            Console.WriteLine("You are now in " + _areaName);
        }

        


    }






}
