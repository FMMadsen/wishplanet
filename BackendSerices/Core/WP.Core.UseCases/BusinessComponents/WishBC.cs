using WP.Core.DomainModel.Entities;
using WP.Core.DomainModel.Factories;
using WP.Core.DomainModel.Interfaces;
using WP.Core.UseCases.Support;

namespace WP.Core.UseCases.BusinessComponents
{
    public class WishBC
    {
        public WishEntity AddNewWish(IGenericWish newWish, string userId)
        {
            if (newWish == null)
            {
                throw new ArgumentNullException(nameof(newWish));
            }

            if (string.IsNullOrWhiteSpace(newWish.Title))
            {
                throw new ArgumentException("A wish must have a title", nameof(newWish));
            }

            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("There must be an owner on a wish entity", nameof(userId));
            }

            var wishIdFactory = new WishIDFactory();
            var wishEntityFactory = new WishEntityFactory();

            var newId = wishIdFactory.Create();
            var newCreatedWishEntity = wishEntityFactory.Create(newId, userId, newWish.Title, newWish.Description);
            //var newInsertedWishEntity = _wishRepository.Insert(newCreatedWishEntity);
            return newCreatedWishEntity;
        }
    }
}
