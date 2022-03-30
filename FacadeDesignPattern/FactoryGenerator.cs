namespace FacadeDesignPattern
{
    public class FactoryGenerator
    {
        public static AbstractFactory GetFactory(string choise)
        {
            if (choise == "cache")
            {
                return new CacheFactory();
            }
            else
            {
                return new DatabaseFactory();
            }
        }
    }
}
