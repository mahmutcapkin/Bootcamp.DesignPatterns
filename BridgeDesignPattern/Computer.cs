namespace BridgeDesignPattern
{
    public class Computer : ElectronicDevice
    {
        public Computer(IPlayType playType, ICall call) : base(playType, call)
        {
        }
    }
}
