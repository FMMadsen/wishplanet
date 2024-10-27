namespace WP.Core.DomainModel.Entities
{
    public class WishEntity
    {
        internal WishEntity(string id, string ownerId, string title, string description)
        {
            Id = id;
            OwnerId = ownerId;
            Title = title;
            Description = description;
        }

        public string Id;
        public string OwnerId;
        public string Title;
        public string Description;
    }
}
