
namespace SOLID.IinSOLID
{
    public class Aircraft : Vehicle, IAbleToFly
    {
        public void Back()
        {
            Console.WriteLine("Aircraft goes back");
        }

        public void Forward()
        {
            Console.WriteLine("Aircraft goes forward");
        }

        public void Rise()
        {
            Console.WriteLine("Aircraft rose");
        }
    }
}
