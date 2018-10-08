using System;
using Xunit;

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
            Assert.True(game.GetType().Equals(typeof(Game)));
        }

        [Fact]
        public void Player_Health_100_At_Start()
        {
            Assert.True(game.CurrentPlayer.Health.Equals(100));
        }

        [Fact]
        public void Game_Has_4_Rooms()
        {
            Assert.True(game.Rooms.Count.Equals(4));
        }

        [Fact]
        public void Room_1_Has_1_Item()
        {
            Assert.True(game.Rooms[1].Items.Count.Equals(1));
        }

        [Fact]
        public void Room_1_Has_Key()
        {
            Assert.True(game.Rooms[1].Items[0].Name.Equals("key"));
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
            Assert.True(Items.Count.Equals(1));
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(1000, 1000)]
        public void Player_Health_Passed_In(int startHealth, int expectedHealth)
        {
            Game g = new Game(startHealth);
            Assert.True(g.CurrentPlayer.Health.Equals(expectedHealth));
        }



        public void Dispose()
        {
            game = null;
        }


    }
}
