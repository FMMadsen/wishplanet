using WP.Core.DomainModel.Factories;

namespace WP.Core.DomainModel.UnitTests
{
    [TestFixture]
    public class WishEntityFactoryUnitTest
    {
        [Test]
        public void Create_HaveAllInputVariables_ReturnsEntityFullyPopulated()
        {
            //Prepare
            var id = Guid.NewGuid().ToString();
            var ownerId = Guid.NewGuid().ToString();
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);

            //assert
            Assert.That(result.Id, Is.EqualTo(id));
            Assert.That(result.OwnerId, Is.EqualTo(ownerId));
            Assert.That(result.Title, Is.EqualTo(title));
            Assert.That(result.Description, Is.EqualTo(description));
        }

        [Test]
        public void Create_WithEmptyId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithEmptyId);
        }

        [Test]
        public void Create_WithNullId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithNullId);
        }

        [Test]
        public void Create_WithWhitespaceId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithWhitespaceId);
        }

        [Test]
        public void Create_WithEmptyOwnerId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithEmptyOwner);
        }

        [Test]
        public void Create_WithNullOwnerId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithNullOwner);
        }

        [Test]
        public void Create_WithWhitespaceOwnerId_ThrowsException()
        {
            //assert
            Assert.Throws<ArgumentException>(Create_WithWhitespaceOwner);
        }

        private void Create_WithEmptyId()
        {
            //Prepare
            var id = string.Empty;
            var ownerId = Guid.NewGuid().ToString();
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }

        private void Create_WithNullId()
        {
            //Prepare
            string id = null;
            var ownerId = Guid.NewGuid().ToString();
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }

        private void Create_WithWhitespaceId()
        {
            //Prepare
            var id = "  ";
            var ownerId = Guid.NewGuid().ToString();
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }

        private void Create_WithEmptyOwner()
        {
            //Prepare
            var id = Guid.NewGuid().ToString();
            var ownerId = string.Empty;
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }

        private void Create_WithWhitespaceOwner()
        {
            //Prepare
            string id = Guid.NewGuid().ToString();
            var ownerId = " ";
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }

        private void Create_WithNullOwner()
        {
            //Prepare
            string id = Guid.NewGuid().ToString();
            string ownerId = null;
            var title = Guid.NewGuid().ToString();
            var description = Guid.NewGuid().ToString();
            var sut = new WishEntityFactory();

            //act
            var result = sut.Create(id, ownerId, title, description);
        }
    }
}