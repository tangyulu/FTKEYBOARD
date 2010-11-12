using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;

namespace FTKEYBOARD.Net.Listener
{
    /// <summary>
    /// Base Listener
    /// </summary>
    public abstract class ListenerBase
    {
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public abstract bool Running { get; }

        public abstract void Start();
        public abstract void Stop();

        protected void RaiseDataReceived(IPEndPoint point, byte[] data)
        {
            var e = new DataReceivedEventArgs() { EndPoint = point, Data = data };

            ThreadPool.QueueUserWorkItem(delegate
            {
                DataReceived(this, e);
            });
        }
    }
}
