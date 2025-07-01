using NUnit.Framework;
using Moq;
using PlayersManagerLib;
using System;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> _mockMapper;

        [OneTimeSetUp]
        public void Init()
        {
            _mockMapper = new Mock<IPlayerMapper>();
        }

        [Test]
        public void RegisterNewPlayer_ShouldCreatePlayer_WhenNameIsUnique()
        {
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            var player = Player.RegisterNewPlayer("Rohit", _mockMapper.Object);

            Assert.That(player.Name, Is.EqualTo("Rohit"));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));
        }

        [Test]
        public void RegisterNewPlayer_ShouldThrowException_WhenNameIsEmpty()
        {
            var ex = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("", _mockMapper.Object));
            Assert.That(ex.Message, Does.Contain("can’t be empty"));
        }

        [Test]
        public void RegisterNewPlayer_ShouldThrowException_WhenNameExists()
        {
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            var ex = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("Virat", _mockMapper.Object));
            Assert.That(ex.Message, Does.Contain("already exists"));
        }
    }
}
