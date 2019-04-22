using System;
using System.Collections.Generic;
using System.Text;

namespace XunitGrimtolBuild.Models
{
    public class Game
    {
        public Player CurrentPlayer { get; set; }
        public List<Room> Rooms { get; set; }

        public Game(int startHealth = 100)
        {
            CurrentPlayer = new Player(startHealth);
            Rooms = new List<Room>();
            Setup();
        }

        private void Setup()
        {
            Room roomOne = new Room();
            Room roomTwo = new Room();
            Room roomThree = new Room();
            Room roomFour = new Room();

            Item key = new Item("key", "It is a shiny key");
            Item sword = new Item("sword", "It is a shiny sword");
            roomTwo.Items.Add(sword);
            roomOne.Items.Add(key);

            Rooms.Add(roomOne);
            Rooms.Add(roomTwo);
            Rooms.Add(roomThree);
            Rooms.Add(roomFour);
        }

    }
}
