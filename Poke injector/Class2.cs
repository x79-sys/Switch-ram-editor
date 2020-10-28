using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Poke_injector
{
    class Class2
    {
        public Socket Connection = Socket(SocketType.Stream, ProtocolType.Tcp);

        private static Socket Socket(SocketType stream, ProtocolType tcp)
        {
            throw new NotImplementedException();
        }
    }
}
