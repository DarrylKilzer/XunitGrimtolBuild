using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;
using XunitGrimtolBuild.Models;

namespace GrimtolTests
{
    public class GrimtolTest
    {

        Game game;

        public GrimtolTest()
        {
            game = new Game();
        }

        [Fact]
        public void IsGame()
        {
            Assert.Equal(game.GetType(),(typeof(Game)));
        }

        [Fact]
        public void Player_Health_100_At_Start()
        {
            Assert.Equal(100, game.CurrentPlayer.Health);
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(1000, 1000)]
        public void Player_Health_Passed_In(int startHealth, int expectedHealth)
        {
            Game g = new Game(startHealth);
            Assert.Equal(expectedHealth, g.CurrentPlayer.Health);
        }

        [Fact]
        public void Game_Has_4_Rooms()
        {
            Assert.Equal(4, game.Rooms.Count);
        }

        [Fact]
        public void Room_1_Has_1_Item()
        {
            Assert.Single(game.Rooms[0].Items);
        }

        [Fact]
        public void Room_1_Has_Key()
        {
            Assert.Equal("key", game.Rooms[0].Items[0].Name);
        }

        [Fact]
        public void Ensure_Only_One_Key()
        {
            List<Item> Items = new List<Item>();

            foreach (Room room in game.Rooms)
            {
                foreach (Item item in room.Items)
                {
                    if (item.Name.Equals("key"))
                    {
                        Items.Add(item);
                    }
                }
            }
            Assert.Single(Items);
        }
    }
}
