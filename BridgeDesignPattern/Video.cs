using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Video : ICall
    {
        public void Call()
        {
            Console.WriteLine("video call is starting");
        }
    }
}
