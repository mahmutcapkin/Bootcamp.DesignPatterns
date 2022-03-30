namespace FacadeDesignPattern
{
    public class DatabaseService : IDatabase
    {
        public void WritingDatabase()
        {
            Console.WriteLine("data written to database");
        }
    }
}
