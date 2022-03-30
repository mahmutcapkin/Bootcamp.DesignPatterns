namespace FacadeDesignPattern
{
    public class CacheFactory : AbstractFactory
    {
        public override ICache GetCache(string cachetype)
        {
            if (cachetype == "cache")
            {
                return new CacheService();
            }
            return null;
        }

        public override IDatabase GetDatabase(string databasetype)
        {
            return null;
        }
    }
}
