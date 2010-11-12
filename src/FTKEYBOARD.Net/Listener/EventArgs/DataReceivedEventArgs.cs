using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FTKEYBOARD.Net.Listener
{
    public class DataReceivedEventArgs : EventArgs
    {
        public IPEndPoint EndPoint { get; set; }
        public byte[] Data { get; set; }
    }
}
