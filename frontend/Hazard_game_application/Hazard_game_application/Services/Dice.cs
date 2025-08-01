using System;

namespace Hazard_game_application.Services
{

    public class Dice
    {
        private Random random;
        
        public (int die1, int die2) Roll()
        {
            random = new Random();
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            return (die1, die2);


        }

    }
}
