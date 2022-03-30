namespace FacadeDesignPattern
{
    //Facade DesignPattern ve AbstractFactory DP bir arada kullanılmıştır.
    public class App
    {
        private IDatabase database;
        private ICache cache;
        public App(string factoryChoise, string choise)
        {
            if (factoryChoise == "cache")
            {
                AbstractFactory cacheFactory = FactoryGenerator.GetFactory(factoryChoise);
                cache = cacheFactory.GetCache(choise);
            }
            else
            {
                AbstractFactory databaseFactory = FactoryGenerator.GetFactory(factoryChoise);
                database = databaseFactory.GetDatabase(choise);
            }
        }
        public App()
        {
            AbstractFactory cacheFactory = FactoryGenerator.GetFactory("cache");
            cache = cacheFactory.GetCache("cache");
            AbstractFactory databaseFactory = FactoryGenerator.GetFactory("database");
            database = databaseFactory.GetDatabase("database");
        }


        public void WritingDatabaseAndCache()
        {
           
            if(database == null)
            {
                cache.WritingCache();
            }
            else if(cache == null)
            {
                database.WritingDatabase();
            }
            else
            {
                cache.WritingCache();
                database.WritingDatabase();
            }
        }



    }
}
