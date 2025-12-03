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
    }
}
