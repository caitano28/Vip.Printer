using System;
using System.Collections.Generic;
using System.Text;

namespace Vip.Printer.Interfaces.Command
{
    internal interface IFontHeight
    {
        byte[] Normal();
        byte[] DoubleHeight();
    }
}
