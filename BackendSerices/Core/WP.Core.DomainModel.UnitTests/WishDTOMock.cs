using WP.Core.DomainModel.Interfaces;

namespace WP.Core.DomainModel.UnitTests
{
    public class WishDTOMock : IGenericWish
    {
        public WishDTOMock()
        {
            Title = "ABCdef";
            Description = "abcdefghij123456789";
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
