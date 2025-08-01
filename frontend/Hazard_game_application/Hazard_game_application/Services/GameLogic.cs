
using System;        

namespace Hazard_game_application.Services
{
    public static class GameLogic
    {
        public static (bool GameOver, bool Win) CheckWinLose(int main, int roll)
        {
            if (main == 0)
            {
                throw new ArgumentException("Main must be set before checking win/lose.");
            }

            if (roll == main)
                return (true, true);

            if (roll == 2 || roll == 3 || roll == 12)
                return (true, false);

            return (false, false);
        }
    }
}
