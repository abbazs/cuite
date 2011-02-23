﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlComboBox : CUITe_ControlBase
    {
        private SilverlightComboBox _SlComboBox;

        public CUITe_SlComboBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Wrap(SilverlightComboBox control)
        {
            base.Wrap(control);
            this._SlComboBox = control;
        }

        public SilverlightComboBox UnWrap()
        {
            return this._SlComboBox;
        }

        public void SelectItem(string sItem)
        {
            this._SlComboBox.WaitForControlReady();
            this._SlComboBox.SelectedItem = sItem;
        }

        public string SelectedItem
        {
            get 
            {
                this._SlComboBox.WaitForControlReady();
                return this._SlComboBox.SelectedItem; 
            }
        }
    }
}