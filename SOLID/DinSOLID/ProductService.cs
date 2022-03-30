namespace SOLID.DinSOLID
{
    public class ProductService
    {
        private IDatabase _database;
        public ProductService(IDatabase database)
        {
            _database = database;
        }

        public void SaveProduct(string name)
        {
            _database.Save(name);
        }

    }
}
