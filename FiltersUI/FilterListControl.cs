using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersUI
{
    public partial class FilterListControl : UserControl, IFilterView
    {

        private string filterName = String.Empty;

        public FilterListControl()
        {
            InitializeComponent();
        }

        public string FilePath
        {
            get
            {
                return filterConfigPathTextBox.Text;
            }

            set
            {
                filterConfigPathTextBox.Text = value;
            }
        }

        public string FilterName
        {
            get
            {
                return filterName;
            }

            set
            {
                filterName = value;
                filterSettingsGroupBox.Text = String.Format("{0} Settings", filterName);
            }
        }

        public event ConfigFileSelectedEventHandler ConfigFileSelected;
        public event FilterItemAddedEventHandler ItemAdded;

        public void LoadFilterItems(List<string> filterItems)
        {
            foreach (string filter in filterItems)
            {              
                FilterItemsListBox.Items.Add(filter);
            }
        }

        private void filterBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filterConfigPathTextBox.Text = fileDialog.FileName;
                OnFileSelected();
            }
        }

        private void OnFileSelected()
        {
            if (ConfigFileSelected != null)
            {
                ConfigFileSelected(this, FilePath);
            }
        }

        private void addFilterItemButton_Click(object sender, EventArgs e)
        {
            OnItemAdded();
        }

        private void OnItemAdded()
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, newFilterItemTextBox.Text);
            }
        }
    }
}
