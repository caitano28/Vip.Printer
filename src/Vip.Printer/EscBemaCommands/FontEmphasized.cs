using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
    internal class FontEmphasized : IFontEmphasized
    {
        //Não testado
        public byte[] Emphasized()
        {
            return new byte[] { 27, 'E'.ToByte()};
        }
        //Não testado
        public byte[] EmphasizedOff()
        {
            return new byte[] { 27, 'F'.ToByte()};
        }
    }
}
