using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class FontEmphasized : IFontEmphasized
    {
        //Não testado
        public byte[] Emphasized()
        {
            return new byte[] { 27, '!'.ToByte(), 3 };
        }
        //Não testado
        public byte[] EmphasizedOff()
        {
            return new byte[] { 27, '!'.ToByte(), 3 };
        }
    }
}
