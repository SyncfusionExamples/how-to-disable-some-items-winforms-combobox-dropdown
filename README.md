# how-to-disable-items-winforms-combobox-dropdown
This example demonstrates how to disable items from a winforms combobox dropdown. For more details please refer [how to disable items from winforms combobox dropdown](https://www.syncfusion.com/kb/11254/how-to-disable-some-items-winforms-combobox-dropdown).

## Changing forecolor for disabled items in dropdown
You can change the forecolor for disabled items by handling SfComboBox.DropDownListView.DrawItem event to show the items is disabled.

# C#

    sfComboBox.DropDownListView.DrawItem += DropDownListView_DrawItem;
 
    private void DropDownListView_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            bool isItemEnable = (this.sfComboBox.ComboBoxMode == ComboBoxMode.MultiSelection && this.sfComboBox.AllowSelectAll && e.ItemIndex == 0) ? true : (e.ItemData as Details).IsEnabled;
        if (!isItemEnable)
        {
             e.Style.BackColor = Color.LightGray;
             e.Style.ForeColor = Color.Gray;
        }
    }

## Handling selection for disabled items in dropdown
Selection of disabled items in multi selection mode handled using SfComboBox.DropDownListView.SelectionChanged and SfComboBox.DropDownListView.ItemChecking event. In single selection mode, selection is handled using SfComboBox.DropDownListView.SelectionChanging event.

# C#

    private void DropDownListView_SelectionChanged(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == this.sfComboBox.DropDownListView.View.Items.Count)S
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
        if (e.AddedItems.Count > 0 && !(e.AddedItems[0] as Details).IsEnabled && e.AddedItems.Count != this.sfComboBox.DropDownListView.View.Items.Count)
        e.Cancel = true;
    }    

![Disable items in ComboBox](SfComboBox/SfComboBox/ComboBox%20Images/Disable%20some%20items%20in%20ComboBox.png)

