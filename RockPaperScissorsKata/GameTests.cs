using NUnit.Framework;

namespace RockPaperScissorsKata
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasRock_ShouldReturnPlayerWins()
        {
            //Arrange
            var player = Action.Paper;
            var opponent = Action.Rock;

            //System under test
            var sut = new Game();

            //Act
            var actual = sut.Play(player, opponent);

            //Assert
            var expected = "Player Wins";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasScissors_AndOpponentHasPaper_ShouldReturnPlayerWins()
        {
            //Arrange
            var player = Action.Scissors;
            var opponent = Action.Paper;

            //System under test
            var sut = new Game();

            //Act
            var actual = sut.Play(player, opponent);

            //Assert
            var expected = "Player Wins";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasPaper_ShouldReturnTie()
        {
            //Arrange
            var player = Action.Paper;
            var opponent = Action.Paper;

            //System under test
            var sut = new Game();

            //Act
            var actual = sut.Play(player, opponent);

            //Assert
            var expected = "Tie";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasPaper_AndOpponentHasScissors_ShouldReturnPlayerLoses()
        {
            //Arrange
            var player = Action.Paper;
            var opponent = Action.Scissors;

            //System under test
            var sut = new Game();

            //Act
            var actual = sut.Play(player, opponent);

            //Assert
            var expected = "Player Loses";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerHasRock_AndOpponentHasPaper_ShouldReturnPlayerLoses()
        {
            //Arrange
            var player = Action.Rock;
            var opponent = Action.Paper;

            //System under test
            var sut = new Game();

            //Act
            var actual = sut.Play(player, opponent);

            //Assert
            var expected = "Player Loses";

            Assert.AreEqual(expected, actual);
        }
    }

    public class Game
    {
        public string Play(Action player, Action opponent)
        {
            string result = "Player Wins";

            if (player == opponent)
                return "Tie";

            switch(player)
            {
                case Action.Paper:
                    if(opponent == Action.Scissors)
                        result = "Player Loses";
                    break;
                case Action.Rock:
                    if (opponent == Action.Paper)
                        result = "Player Loses";
                    break;
                case Action.Scissors:
                    if (opponent == Action.Rock)
                        result = "Player Loses";
                    break;
                default:
                    break;
            }

            return result;
        }
    }

    public enum Action
    {
        Rock,
        Paper,
        Scissors
    }
}
