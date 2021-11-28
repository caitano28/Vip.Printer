using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class FontEmphasized : IFontEmphasized
    {
        //Testei na Jetway que utiliza EscPos e Tanca
        public byte[] Emphasized()
        {
            return new byte[] { 27, 'E'.ToByte(), 8 };
        }
        //Testei na Jetway que utiliza EscPos e Tanca
        public byte[] EmphasizedOff()
        {
            return new byte[] { 27, 'E'.ToByte(), 0 };
        }
    }
}
