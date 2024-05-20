using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3_Games
{
    public class GamesApp
    {
        private static List<Gamer> gamers; 
        private static List<GameInterface> games;
        public GamesApp()
        {
            gamers = new List<Gamer>();
        }
        public bool auth(string username, string password)
        {
            return true;
        }
        public bool registr(string username, string password)
        {
            gamers.Add(new Gamer(username));
            return true;
        }
        public void addGame(GameInterface game)
        {
            games.Add(game);
        }
        public void beginGamesApp()
        {
            auth("admin", "admin");
        }
    }
}
