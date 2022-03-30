namespace FacadeDesignPattern
{
    public class CacheService : ICache
    {
        public void WritingCache()
        {
            Console.WriteLine("data is cached");
        }
    }
}
