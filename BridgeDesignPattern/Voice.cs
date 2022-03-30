namespace BridgeDesignPattern
{
    public class Voice : ICall
    {
        public void Call()
        {
            Console.WriteLine("Voice call is starting");
        }
    }
}
