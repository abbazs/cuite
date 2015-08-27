﻿using System;
using System.Linq;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// CUITe wrapper for HtmlComboBox.
    /// </summary>
    public class HtmlComboBox : HtmlControl<CUITControls.HtmlComboBox>
    {
        public HtmlComboBox()
        {
        }

        public HtmlComboBox(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Selects the item in the combobox.
        /// </summary>
        /// <param name="sItem">Item as string</param>
        public void SelectItem(string sItem)
        {
            SourceControl.WaitForControlReady();
            SourceControl.SelectedItem = sItem;
        }

        /// <summary>
        /// Selects the item in the combobox by index.
        /// </summary>
        /// <param name="index">index of item</param>
        public void SelectItem(int index)
        {
            SourceControl.WaitForControlReady();
            SourceControl.SelectedIndex = index;
        }

        /// <summary>
        /// Gets the selected item in a combobox.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedItem;
            }
        }

        /// <summary>
        /// Gets the selected index in a combobox.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedIndex;
            }
        }

        /// <summary>
        /// Gets the count of the items in the combobox.
        /// </summary>
        public int ItemCount
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.ItemCount;
            }
        }

        /// <summary>
        /// Gets the items in a string array of the html combo box.
        /// </summary>
        public string[] Items
        {
            get
            {
                //trying to call InnerText of children will cause errors if child items are disabled
                return InnerText.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }

        /// <summary>
        /// Tells whether the specified item is present in the html combo box or not.
        /// </summary>
        public bool ItemExists(string sText)
        {
            return Items.Contains(sText);
        }
    }
}