﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightHyperlink.
    /// </summary>
    public class CUITe_SlHyperlink : CUITe_SlControl<SilverlightHyperlink>
    {
        public CUITe_SlHyperlink() : base() { }
        public CUITe_SlHyperlink(string searchParameters) : base(searchParameters) { }
    }
}
