using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3_Games
{
    public interface GameInterface
    {
        void startGame();
        string getGameName();
        bool isWin();
    }
}
