using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

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
            Stream data = new MemoryStream(e.Data);
            IPEndPoint endpoint = e.EndPoint;

            var header = (FTKEYBOARD.Protocol.ProtocolType)data.ReadByte();
            switch (header)
            {
                case FTKEYBOARD.Protocol.ProtocolType.OP_FTKEYBOARDHEADER:
                    ProcessPacketFTK(ref data, ref endpoint);
                    break;
                default:
                    //todo:
                    break;
            }
        }

        private static void ProcessPacketFTK(ref Stream data, ref IPEndPoint endpoint)
        {
            var command = (FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes)data.ReadByte();
            switch (command)
            {
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_PING:
                    ProcessPacketFTK_PING(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_PONG:
                    ProcessPacketFTK_PONG(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_LOGIN_REQ:
                    ProcessPacketFTK_LOGIN_REQ(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_LOGIN_RES:
                    ProcessPacketFTK_LOGIN_RES(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_KEY_DOWN:
                    ProcessPacketFTK_KEY_DOWN(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_KEY_UP:
                    ProcessPacketFTK_KEY_UP(ref data, ref endpoint);
                    break;
                case FTKEYBOARD.Protocol.FTKEYBOARD.FTKEYBOARDOPcodes.FTKEYBOARD_KEY_PRESS:
                    ProcessPacketFTK_KEY_PRESS(ref data, ref endpoint);
                    break;
                default:
                    //todo:
                    break;
            }
        }

        private static void ProcessPacketFTK_PING(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_PONG(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_LOGIN_REQ(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_LOGIN_RES(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_KEY_DOWN(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_KEY_UP(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        private static void ProcessPacketFTK_KEY_PRESS(ref Stream data, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

    }
}
