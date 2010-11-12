using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FTKEYBOARD.IO
{
    public class FTBinaryWriter : BinaryWriter
    {
        public FTBinaryWriter(Stream stream) : base(stream)
        { }
    }
}
