namespace BridgeDesignPattern
{
    public class Telephone : ElectronicDevice
    {
        public Telephone(IPlayType playType, ICall call) : base(playType, call)
        {
        }
    }
}
