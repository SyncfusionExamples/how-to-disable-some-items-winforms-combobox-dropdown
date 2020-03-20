using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (e.AddedItems.Count == this.sfComboBox.DropDownListView.View.Items.Count())
            {
                foreach (var value in disableItems)
                    this.sfComboBox.DropDownListView.CheckedItems.Remove(value);
            }
        }

        private void DropDownListView_ItemChecking(object sender, Syncfusion.WinForms.ListView.Events.ItemCheckingEventArgs e)
        {
            bool isDisabledItem = disableItems.Contains(e.ItemData);
            if ((this.sfComboBox.AllowSelectAll == false && isDisabledItem) || (e.ItemIndex != 0 && isDisabledItem))
            {
                e.Cancel = true;
            }
        }

        private void DropDownListView_SelectionChanging(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangingEventArgs e)
        {
            if (this.disableItems.Contains(e.AddedItems[0]))
                e.Cancel = true;
        }

        private void DropDownListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            bool isDisabledItem = disableItems.Contains(e.ItemData);
            if ((this.sfComboBox.AllowSelectAll == false && isDisabledItem) || (e.ItemIndex != 0 && isDisabledItem))
            {
                e.Style.BackColor = Color.LightGray;
                e.Style.ForeColor = Color.Gray;
            }
        }

        #endregion

        #region Data Setting 

        List<string> disableItems = new List<string>() { "Asif" };

        public List<string> GetData()
        {
            List<string> list = new List<string>();
            list.Add("Amir");
            list.Add("Asif");
            list.Add("Catherine");
            list.Add("Cindrella");
            list.Add("David");
            list.Add("Ellis");
            list.Add("Farooq");
            list.Add("Muhammad");
            list.Add("Saleem");
            list.Add("Usman");
            return list;
        }

        #endregion
    }
}



