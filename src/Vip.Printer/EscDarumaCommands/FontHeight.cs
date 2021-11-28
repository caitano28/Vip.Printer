using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class FontHeight : IFontHeight
    {
        //não testado
        public byte[] DoubleHeight()
        {
            return new byte[] { 27, 'w'.ToByte(), 1 };
        }
        //não testado
        public byte[] Normal()
        {
            return new byte[] { 27, 'w'.ToByte(), 1 };
        }
    }
    
}
