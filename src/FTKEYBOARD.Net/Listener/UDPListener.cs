using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace FTKEYBOARD.Net.Listener
{
    /// <summary>
    /// UDP Listener
    /// </summary>
    public class UDPListener : ListenerBase
    {
        private UdpClient listener;
        private IPEndPoint endpoint;

        public override bool Running
        {
            get { return listener != null; }
        }

        /// <summary>
        /// UDPListener
        /// </summary>
        /// <param name="port">port</param>
        public UDPListener(int port) : this(new IPEndPoint(IPAddress.Any, port))
        { }

        /// <summary>
        /// UDPListener
        /// </summary>
        /// <param name="endpoint">endpoint</param>
        public UDPListener(IPEndPoint endpoint)
        {
            this.endpoint = endpoint;
        }

        public override void Start()
        {
            if (Running)
                return;

            listener = new UdpClient(endpoint.Port);
            listener.BeginReceive(new AsyncCallback(ReceiveData), listener);
        }

        public override void Stop()
        {
            if (!Running)
                return;

            UdpClient listener = this.listener;
            this.listener = null;
            listener.Close();
        }

        private void ReceiveData(IAsyncResult ar)
        {
            try
            {
                UdpClient listener = ar.AsyncState as UdpClient;
                byte[] data = listener.EndReceive(ar, ref endpoint);

                RaiseDataReceived(endpoint, data);
            }
            catch (Exception e)
            {
                //todo: ??
            }
            finally
            {
                if (Running)
                    listener.BeginReceive(new AsyncCallback(ReceiveData), listener);
            }
        }
    }
}
