using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FTKEYBOARD.Application;

namespace FTKEYBOARD.CLILoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new Kernel();
            kernel.Start();

            Console.ReadLine();
        }
    }
}
