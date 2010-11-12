using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTKEYBOARD.Protocol
{
    public class FTKEYBOARD
    {
        public const ushort FTKEYBOARD_VERSION = 0x01;

        public enum FTKEYBOARDOPcodes : byte
        {
            Reach_PING = 0x00,
            Reach_PONG = 0x01,

            FTKEYBOARD_LOGIN_REQ = 0x10,
            FTKEYBOARD_LOGIN_RES = 0x11,

            FTKEYBOARD_KEY_DOWN = 0x20,
            FTKEYBOARD_KEY_UP = 0x21,
            FTKEYBOARD_KEY_PRESS = 0x22,
        }
    }
}
