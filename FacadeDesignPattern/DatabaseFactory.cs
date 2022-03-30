namespace FacadeDesignPattern
{
    public class DatabaseFactory : AbstractFactory
    {
        public override ICache GetCache(string cachetype)
        {
            return null;
        }

        public override IDatabase GetDatabase(string databasetype)
        {
            if (databasetype == "database")
            {
                return new DatabaseService();
            }
            return null;
        }
    }
}
