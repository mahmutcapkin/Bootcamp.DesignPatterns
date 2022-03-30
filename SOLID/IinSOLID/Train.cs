namespace SOLID.IinSOLID
{
    public class Train : IDriveable
    {
        public void Back()
        {
            Console.WriteLine("Train goes back");
        }

        public void Forward()
        {
            Console.WriteLine("Train goes Forward");
        }
    }
}
