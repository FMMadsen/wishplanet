using WP.Core.DomainModel.Entities;

namespace WP.Core.DomainModel.Factories
{
    public class WishEntityFactory
    {
        public WishEntity Create(
            string id, string ownerId, string title, string description)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("A wish entity must have an ID", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(ownerId))
            {
                throw new ArgumentException("A wish entity must have an owner", nameof(ownerId));
            }

            return new WishEntity(id, ownerId, title, description);
        }
    }
}
