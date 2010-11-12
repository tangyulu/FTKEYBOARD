using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FTKEYBOARD.IO
{
    public class FTBinaryReader : BinaryReader
    {
        public FTBinaryReader(Stream stream) : base(stream)
        { }
    }
}
