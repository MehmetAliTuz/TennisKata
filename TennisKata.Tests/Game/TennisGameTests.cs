using NUnit.Framework;
using TennisKata.Game;

namespace TennisKata.Tests.Game
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void Score_ShouldBe_LoveAll_AtStart()
        {
            // Arrange
            var game = new TennisGame();

            // Act
            var score = game.GetScore();

            // Assert
            Assert.AreEqual("Love-All", score);
        }

        [Test]
        public void Score_ShouldBe_FifteenLove_WhenPlayer1ScoresOnce()
        {
            // Arrange
            var game = new TennisGame();

            // Act
            game.PointToPlayer1();
            var score = game.GetScore();

            // Assert
            Assert.AreEqual("Fifteen-Love", score);
        }

        [Test]
        public void Score_ShouldBe_LoveFifteen_WhenPlayer2ScoresOnce()
        {
            // Arrange
            var game = new TennisGame();

            // Act
            game.PointToPlayer2();
            var score = game.GetScore();

            // Assert
            Assert.AreEqual("Love-Fifteen", score);
        }
        [Test]
        public void Score_ShouldBe_Deuce_WhenBothHaveThreePoints()
        {
            var game = new TennisGame();

            for (int i = 0; i < 3; i++)
            {
                game.PointToPlayer1();
                game.PointToPlayer2();
            }

            var score = game.GetScore();

            Assert.AreEqual("Deuce", score);
        }
        [Test]
        public void Score_ShouldBe_AdvantagePlayer1_WhenPlayer1LeadsByOneAfterDeuce()
        {
            var game = new TennisGame();

            for (int i = 0; i < 3; i++)
            {
                game.PointToPlayer1();
                game.PointToPlayer2();
            }

            game.PointToPlayer1();

            var score = game.GetScore();

            Assert.AreEqual("Advantage player1", score);
        }
        [Test]
        public void Score_ShouldBe_WinForPlayer1_WhenPlayer1WinsFourToZero()
        {
            var game = new TennisGame();

            for (int i = 0; i < 4; i++)
            {
                game.PointToPlayer1();
            }

            var score = game.GetScore();

            Assert.AreEqual("Win for player1", score);
        }
    }
}
