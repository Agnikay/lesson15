using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //whiteFilterEntriesListView.View = View.Details;

        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                inputFileTextBox.Text = fileDialog.FileName;
            }
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputFileTextBox.Text = fileDialog.FileName;
            }
        }

        private void startFilteringButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputFileTextBox.Text))
            {
                MessageBox.Show("Please choose input file!");
                return;
            }

            if (String.IsNullOrEmpty(outputFileTextBox.Text))
            {
                MessageBox.Show("Please choose output file");
                return;
            }

            if (inputFileTextBox.Text.Equals(outputFileTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Choose different files!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                whiteListConfigFileTextBox.Text = fileDialog.FileName;
            }

            using (StreamReader reader = new StreamReader(whiteListConfigFileTextBox.Text))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    whiteFilterListBox.Items.Add(line);
                }
            }
        }

        private void addItemToListButton_Click(object sender, EventArgs e)
        {
            whiteFilterListBox.Items.Add(newWhiteItemTextBox.Text);
        }

        private void newWhiteItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addItemToWhiteListButton.Enabled = !String.IsNullOrEmpty(newWhiteItemTextBox.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(whiteListConfigFileTextBox.Text))
                {
                    foreach (string whiteListItem in whiteFilterListBox.Items)
                    {
                        writer.WriteLine(whiteListItem);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("File is read only");
            }
        }
    }
}

