using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTKEYBOARD.Protocol
{
    public enum ProtocolType : byte
    {
        //FTKEYBOARD 1
        OP_FTKEYBOARDHEADER = 0x77,
        OP_FTKEYBOARDPACKEDPROT = 0x78,
    }
}
