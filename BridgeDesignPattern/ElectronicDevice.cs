using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class ElectronicDevice
    {
        protected readonly IPlayType _playType; 
        protected readonly ICall _call;
        protected ElectronicDevice(IPlayType playType, ICall call)
        {
            _playType = playType;
            _call = call;
        }

        public void Call()
        {
            _call.Call();
        }
        public void Play()
        {
            _playType.Play();
        }

    }


}
