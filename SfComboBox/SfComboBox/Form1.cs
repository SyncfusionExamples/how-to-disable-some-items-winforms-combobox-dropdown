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

        int disableItemIndex = 1;

        private void DropDownListView_SelectionChanged(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == this.sfComboBox1.DropDownListView.View.Items.Count())
            {
                 this.sfComboBox1.DropDownListView.CheckedItems.RemoveAt(disableItemIndex - 1);
            }
        }

        private void DropDownListView_ItemChecking(object sender, Syncfusion.WinForms.ListView.Events.ItemCheckingEventArgs e)
        {
            if(e.ItemIndex == disableItemIndex)
            {
                e.Cancel = true;
            }
        }

        private void DropDownListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            if (e.ItemIndex == disableItemIndex)
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
        }

        public List<Details> GetData()
        {
            List<Details> list = new List<Details>();
            list.Add(new Details() { Name = "Amir"});
            list.Add(new Details() { Name = "Asif"});
            list.Add(new Details() { Name = "Catherine"});
            list.Add(new Details() { Name = "Cindrella"});
            list.Add(new Details() { Name = "David"});
            list.Add(new Details() { Name = "Ellis"});
            list.Add(new Details() { Name = "Farooq"});
            list.Add(new Details() { Name = "Muhammad"});
            list.Add(new Details() { Name = "Saleem"});
            list.Add(new Details() { Name = "Usman"});
            return list;
        }

        #endregion
    }
}



