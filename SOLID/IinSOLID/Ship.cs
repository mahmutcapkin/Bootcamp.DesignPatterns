namespace SOLID.IinSOLID
{
    public class Ship : Vehicle, IFloatable
    {
        public void Back()
        {
            Console.WriteLine("Ship goes back");
        }

        public void Float()
        {
            Console.WriteLine("Ship goes Float");
        }

        public void Forward()
        {
            Console.WriteLine("Ship goes Forward");
        }
    }
}
