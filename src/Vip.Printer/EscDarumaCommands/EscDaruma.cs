﻿using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class EscDaruma : IPrintCommand
    {
        #region Properties

        public IFontMode FontMode { get; set; }
        public IFontWidth FontWidth { get; set; }
        public IFontHeight FontHeight { get; set; }
        public IFontEmphasized FontEmphasized { get; set; }
        public IAlignment Alignment { get; set; }
        public IPaperCut PaperCut { get; set; }
        public IDrawer Drawer { get; set; }
        public IQrCode QrCode { get; set; }
        public IImage Image { get; set; }
        public IBarCode BarCode { get; set; }
        public IInitializePrint InitializePrint { get; set; }
        public int ColsNomal => 48;
        public int ColsCondensed => 57;
        public int ColsExpanded => 25;

        #endregion

        #region Constructor

        public EscDaruma()
        {
            FontMode = new FontMode();
            FontWidth = new FontWidth();
            FontHeight  = new FontHeight();
            FontEmphasized = new FontEmphasized();
            Alignment = new Alignment();
            PaperCut = new PaperCut();
            Drawer = new Drawer();
            QrCode = new QrCode();
            Image = new Image();
            BarCode = new BarCode();
            InitializePrint = new InitializePrint();
        }

        #endregion

        #region Methods

        public byte[] Separator()
        {
            return FontMode.Condensed(PrinterModeState.On)
                .AddBytes(new string('-', ColsCondensed))
                .AddBytes(FontMode.Condensed(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] AutoTest()
        {
            return new byte[] {28, 'M'.ToByte(), 254, 0};
        }

        #endregion
    }
}