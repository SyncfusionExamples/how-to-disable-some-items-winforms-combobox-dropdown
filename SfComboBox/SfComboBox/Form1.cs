using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SfComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void DropDownListView_SelectionChanged(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == this.sfComboBox.DropDownListView.View.Items.Count)
            {
                for (int i = 0; i < this.sfComboBox.DropDownListView.CheckedItems.Count; i++)
                {
                    if ((this.sfComboBox.DropDownListView.CheckedItems[i] as Details).IsEnabled == false)
                        this.sfComboBox.DropDownListView.CheckedItems.RemoveAt(i);
                }
            }
        }

        private void DropDownListView_ItemChecking(object sender, Syncfusion.WinForms.ListView.Events.ItemCheckingEventArgs e)
        {
            bool isItemEnable = (this.sfComboBox.ComboBoxMode == ComboBoxMode.MultiSelection && this.sfComboBox.AllowSelectAll && e.ItemIndex == 0) ? true : (e.ItemData as Details).IsEnabled;
            if (!isItemEnable)
                e.Cancel = true;
        }

        private void DropDownListView_SelectionChanging(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangingEventArgs e)
        {
            if (e.AddedItems.Count > 0 && !(e.AddedItems[0] as Details).IsEnabled && e.AddedItems.Count != this.sfComboBox.DropDownListView.View.Items.Count )
                e.Cancel = true;
        }

        private void DropDownListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            bool isItemEnable = (this.sfComboBox.ComboBoxMode == ComboBoxMode.MultiSelection && this.sfComboBox.AllowSelectAll && e.ItemIndex == 0) ? true : (e.ItemData as Details).IsEnabled;
            if (!isItemEnable)
            {
                e.Style.BackColor = Color.LightGray;
                e.Style.ForeColor = Color.Gray;
            }
        }

        #endregion

        #region Data Setting 

        public class Details
        {
            public string Name { get; set; }

            public bool IsEnabled { get; set; } = true;
        }

        public List<Details> GetData()
        {
            List<Details> list = new List<Details>();
            list.Add(new Details { Name = "Amir", IsEnabled = false });
            list.Add(new Details { Name = "Asif" });
            list.Add(new Details { Name = "Catherine" });
            list.Add(new Details { Name = "Cindrella" });
            list.Add(new Details { Name = "David", IsEnabled = false });
            list.Add(new Details { Name = "Ellis" });
            list.Add(new Details { Name = "Farooq" });
            list.Add(new Details { Name = "Muhammad" });
            list.Add(new Details { Name = "Saleem" });
            list.Add(new Details { Name = "Usman" });
            return list;
        }

        #endregion
    }
}



