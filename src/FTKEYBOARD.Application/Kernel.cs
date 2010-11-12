using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FTKEYBOARD.Protocol;
using FTKEYBOARD.Net;
using FTKEYBOARD.Net.Listener;

namespace FTKEYBOARD.Application
{
    /// <summary>
    /// Kernel
    /// </summary>
    public class Kernel
    {
        private ListenerBase listener;

        public Kernel()
        {
            this.listener = new UDPListener(9999);
            this.listener.DataReceived += OnDataReceived;
        }

        public void Start()
        {
            this.listener.Start();
        }

        public void Stop()
        {
            this.listener.Stop();
        }

        private void OnDataReceived(object sender,DataReceivedEventArgs e)
        {
            //todo:
        }
    }
}
