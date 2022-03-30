namespace BridgeDesignPattern
{
    public class Tablet : ElectronicDevice
    {
        public Tablet(IPlayType playType, ICall call) : base(playType, call)
        {
        }
    }
}
