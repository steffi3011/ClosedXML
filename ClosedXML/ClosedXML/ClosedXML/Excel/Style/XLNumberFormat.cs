﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
    internal class XLNumberFormat : IXLNumberFormat
    {
        #region Properties

        IXLStylized container;

        private Int32 numberFormatId;
        public Int32 NumberFormatId
        {
            get { return numberFormatId; }
            set
            {
                if (container != null && !container.UpdatingStyle)
                {
                    container.Styles.ForEach(s => s.NumberFormat.NumberFormatId = value);
                }
                else
                {
                    numberFormatId = value;
                    format = String.Empty;
                }
            }
        }

        private String format = String.Empty;
        public String Format
        {
            get { return format; }
            set
            {
                if (container != null && !container.UpdatingStyle)
                {
                    container.Styles.ForEach(s => s.NumberFormat.Format = value);
                }
                else
                {
                    format = value;
                    numberFormatId = -1;
                }
            }
        }

        #endregion

        #region Constructors

        public XLNumberFormat(IXLStylized container, IXLNumberFormat defaultNumberFormat = null)
        {
            this.container = container;
            if (defaultNumberFormat != null)
            {
                numberFormatId = defaultNumberFormat.NumberFormatId;
                format = defaultNumberFormat.Format;
            }
        }

        #endregion

        #region Overridden

        public override string ToString()
        {
            return numberFormatId.ToString() + "-" + format.ToString();
        }

        #endregion
    }
}