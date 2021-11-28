using System;
using System.Collections.Generic;
using System.Text;

namespace Vip.Printer.Interfaces.Command
{
    internal interface IFontEmphasized
    {
        byte[] EmphasizedOff();
        byte[] Emphasized();
    }
}
