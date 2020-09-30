using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Map
    {
        public void GetPlayerLocation(Player _playerName, Area _areaName)
        {
            Console.WriteLine(_playerName + " is in " + _areaName);
        }
    }
}
