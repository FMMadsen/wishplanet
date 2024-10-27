namespace WP.Core.UseCases.Support
{
    internal class WishIDFactory
    {
        internal string Create()
        {
            string newId = Guid.NewGuid().ToString();
            return newId;
        }
    }
}
