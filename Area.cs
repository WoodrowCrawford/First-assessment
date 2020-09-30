using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace HelloWorld
{
    //This is used for the map the player moves around in
    class Area
    {
        private string _area0;
        private string _area1;
        private string _area2;
        private string _area3;
        private string _area4;
        private string _area5;
        private string _area6;
        private string _area7;
        private string _area8;

        //Names the areas
        public Area()
        {
            _area0 = "Area 1";
            _area1 = "Area 2";
            _area2 = "Area 3";
            _area3 = "Area 4";
            _area4 = "Area 5";
            _area5 = "Area 6";
            _area6 = "Area 7";
            _area7 = "Area 8";
            _area8 = "Area 9";
        }

        //The first area
        public void Area1()
        {
            Console.WriteLine("You are in " + _area0 + ".");
            Console.WriteLine("It's cold here.");
        }


        //The second area
        public void Area2()
        {
            Console.WriteLine("You are in " + _area1 + ".");
        }


        //The third area
        public void Area3()
        {
            Console.WriteLine("You are in " + _area2 + ".");
        }


        //The fourth area
        public void Area4()
        {
            Console.WriteLine("You are in " + _area3 + ".");
        }


        //The fifth area
        public void Area5()
        {
            Console.WriteLine("You are in " + _area4 + ".");
        }


        //The sixth area
        public void Area6()
        {
            Console.WriteLine("You are in " + _area5 + ".");
        }


        //The seventh area
        public void Area7()
        {
            Console.WriteLine("You are in " + _area6 + ".");
        }


        //The eighth area
        public void Area8()
        {
            Console.WriteLine("You are in " + _area7 + ".");
        }


        //The ninth area
        public void Area9()
        {
            Console.WriteLine("You are in " + _area8 + ".");
        }

    }




  
    
}
