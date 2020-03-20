namespace SfComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sfComboBox
            // 
            this.sfComboBox.Location = new System.Drawing.Point(292, 94);
            this.sfComboBox.Name = "sfComboBox";
            this.sfComboBox.Size = new System.Drawing.Size(196, 36);
            this.sfComboBox.TabIndex = 0;
            this.sfComboBox.AllowSelectAll = true;
            this.sfComboBox.DataSource = this.GetData();
            this.sfComboBox.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            this.sfComboBox.DropDownListView.DrawItem += DropDownListView_DrawItem;
            this.sfComboBox.DropDownListView.ItemChecking += DropDownListView_ItemChecking;
            this.sfComboBox.DropDownListView.SelectionChanged += DropDownListView_SelectionChanged;
            this.sfComboBox.DropDownListView.SelectionChanging += DropDownListView_SelectionChanging;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sfComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox;
    }
}

