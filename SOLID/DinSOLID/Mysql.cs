namespace SOLID.DinSOLID
{
    public class Mysql : IDatabase
    {
        public void Save(string name)
        {
            Console.WriteLine($"The product named {name} was saved in the MySql database");
        }
    }
}
