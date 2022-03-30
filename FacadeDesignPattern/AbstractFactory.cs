namespace FacadeDesignPattern
{
    public abstract class AbstractFactory
    {
        public abstract ICache GetCache(string cachetype);
        public abstract IDatabase GetDatabase(string databasetype);
    }
}
