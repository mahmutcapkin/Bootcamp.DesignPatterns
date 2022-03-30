namespace SOLID.DinSOLID
{
    public class Postgresql : IDatabase
    {
        public void Save(string name)
        {
            Console.WriteLine($"The product named {name} was saved in the PostgreSql database");
        }
    }
}
