using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class FontHeight : IFontHeight
    {
        public byte[] Normal()
        {
            return new byte[] { 27, '!'.ToByte(), 0 };
        }
        public byte[] DoubleHeight()
        {
           return new byte[] { 27, '!'.ToByte(), 16 };
        }

    }
}
