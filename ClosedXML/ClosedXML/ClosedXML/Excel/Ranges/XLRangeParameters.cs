﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClosedXML.Excel
{
    internal class XLRangeParameters
    {
        public XLRangeParameters(IXLAddress firstCellAddress, IXLAddress lastCellAddress, XLWorksheet worksheet, IXLStyle defaultStyle)
        {
            FirstCellAddress = firstCellAddress;
            LastCellAddress = lastCellAddress;
            Worksheet = worksheet;
            DefaultStyle = defaultStyle;
        }
        #region Properties

        // Public
        public IXLAddress FirstCellAddress { get; private set; }
        public IXLAddress LastCellAddress { get; private set; }
        public XLWorksheet Worksheet { get; private set; }
        public IXLStyle DefaultStyle { get; private set; }

        // Private

        // Override


        #endregion

    }
}