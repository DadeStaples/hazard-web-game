using Xunit;
using Hazard_game_application.Services;

namespace HazardGame.Tests
{
    public class WinLoseTests
    {
        [Theory]
        [InlineData(7, 7, true, true)]
        [InlineData(7, 2, true, false)]
        [InlineData(7, 3, true, false)]
        [InlineData(7, 12, true, false)]
        public void CheckWinLose_ReturnsWinOrLose(int main, int roll, bool expectedOver, bool expectedWin)
        {
            var (gameOver, isWin) = GameLogic.CheckWinLose(main, roll);

            Assert.Equal(expectedOver, gameOver);
            Assert.Equal(expectedWin, isWin);
        }

        [Theory]
        [InlineData(7, 5)]
        [InlineData(7, 8)]
        [InlineData(7, 11)]
        public void CheckWinLose_NeitherWinNorLose(int main, int roll)
        {
            var (gameOver, isWin) = GameLogic.CheckWinLose(main, roll);

            Assert.False(gameOver);
            Assert.False(isWin);
        }
    }
}
