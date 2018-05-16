using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContextMenuTest
{
    public partial class Form1 : Form
    {
        AdvancedListView advancedListView;
        public Form1()
        {
            InitializeComponent();
            advancedListView = new AdvancedListView();
            advancedListView.Parent = this;
            advancedListView.Dock = DockStyle.Fill;
            advancedListView.View = View.Details;
            advancedListView.Columns.Add("Column1", 100, HorizontalAlignment.Left);
            advancedListView.Items.Add(new ListViewItem("listViewItem"));
        }
    }

    public class AdvancedListView : ListView
    {
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.X < 120) MessageBox.Show("Item selected");
            else MessageBox.Show("ContextMenu");
            base.OnMouseUp(e);
        }
    }
}