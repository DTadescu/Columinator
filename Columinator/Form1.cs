using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columinator
{
    public partial class MainForm : Form
    {
        private string filename_in = "";
        private string filename_out = "";
        private string folder_out = "";
        private char[] splitters_in;
        private char splitter_out;
        private int ignorable_rows = 0;
        private int ignorable_cols = 0;
        private int value_cols = 1;
        private int cols_out = 1;

        const char SPACE = ' ';
        const char TAB = '\t';

        public MainForm()
        {
            InitializeComponent();
            openFileDialogIn.InitialDirectory = Application.StartupPath;
            folderBrowserDialogOut.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        #region Private methods

        private bool InFileValidation()
        {
            if (textBoxInPath.Text.Length > 0)
            {
                filename_in = textBoxInPath.Text;
                return true;
            }
            else return false;
        }

        private bool OutFilePathValidation()
        {
            string folder = getOutFolder();
            if (folder.Length > 0)
            {
                if (radioButtonOldName.Checked)
                {
                    filename_out = folder + "\\" + (Data.StringBuilder.getFileName(filename_in).Length>0 ? Data.StringBuilder.getFileName(filename_in) : "new.txt");
                   // MessageBox.Show(filename_out);
                    return true;
                }
                if (radioButtonNewName.Checked && (textBoxNewName.Text.Length > 0))
                {
                    filename_out = folder + "\\" + textBoxNewName.Text;
                    //MessageBox.Show(filename_out);
                    return true;
                }
                else return false;

            }
            else return false;
        }

        private string getOutFolder()
        {
            if (radioButtonInFileDir.Checked)
            {
                folder_out = Data.StringBuilder.getDirectory(filename_in);
                return folder_out;
            }
            if (radioButtonAppDir.Checked)
            {
                folder_out = Application.StartupPath;
                return folder_out;
            }
            else return textBoxselDir.Text;
        }

        private bool InSplitterValidation()
        {
            List<char> chars = new List<char>();
            if (checkBoxSpace.Checked) chars.Add(SPACE);
            if (checkBoxTab.Checked) chars.Add(TAB);
            if (chars.Count > 0)
            {
                splitters_in = new Char[chars.Count];
                for (int i = 0; i < chars.Count; i++)
                {
                    splitters_in[i] = chars[i];
                    
                }
                return true;
            }
            else return false;
            
        }

        private bool OutSplitterValidation()
        {
            if (radioButtonOutSpace.Checked)
            {
                splitter_out = SPACE;
                return true;
            }
            if (radioButtonOutTab.Checked)
            {
                splitter_out = TAB;
                return true;
            }
            else return false;
        }

        private bool NumericsValidation()
        {
            if ((numericUpDownValCol.Value > 0) && (numericUpDownCol.Value > 0))
            {
                if (numericUpDownValCol.Value % numericUpDownCol.Value != 0) return false;
                ignorable_rows = (int)numericUpDownStrIgnore.Value;
                ignorable_cols = (int)numericUpDownColIgnore.Value;
                value_cols = (int)numericUpDownValCol.Value;
                cols_out = (int)numericUpDownCol.Value;
                return true;
            }
            return false;
        }

        private bool InValidation()
        {
            if (!InFileValidation())
            {
                
                return false;
            }
            if (!InSplitterValidation())
            {
               
                return false;
            }
            if (!OutFilePathValidation())
            {
                return false;
            }
            if (!OutSplitterValidation())
            {
                return false;
            }
            if (!NumericsValidation())
            {
                return false;
            }
            return true;
        }
#endregion

        #region Controls events
        private void radioButtonSelDir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSelDir.Checked)
            {
                textBoxselDir.Enabled = true;
                buttonSelDir.Enabled = true;
            }
            else
            {
                textBoxselDir.Enabled = false;
                buttonSelDir.Enabled = false;
            }
        }

        private void radioButtonNewName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNewName.Checked)
            {
                textBoxNewName.Enabled = true;
            }
            else
            {
                textBoxNewName.Enabled = false;
            }
        }

        private void checkBoxOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                textBoxChars.Enabled = true;
            }
            else textBoxChars.Enabled = false;
        }

        private void radioButtonOutOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOutOther.Checked)
            {
                textBoxOutSplitter.Enabled = true;
            }
            else textBoxOutSplitter.Enabled = false;
        }

        private void buttonInBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogIn.ShowDialog() == DialogResult.OK)
            {
                filename_in = openFileDialogIn.FileName;
                textBoxInPath.Text = filename_in;
            }
        }

        private void buttonSelDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOut.ShowDialog() == DialogResult.OK)
            {
                folder_out = folderBrowserDialogOut.SelectedPath;
                textBoxselDir.Text = folder_out;
            }
        }

       
       

        private void buttonExe_Click(object sender, EventArgs e)
        {
            if (!InValidation())
            {
                MessageBox.Show("In data error.");
                return;
            }
            string[] rows = Data.Filer.getRowsFromFile(filename_in, ignorable_rows);
            if (rows == null)
            {
                MessageBox.Show("File data error.");
                return;
            }
            string text_out = "";
            foreach (var line in rows)
            {
                string[] values = line.Split(splitters_in, StringSplitOptions.RemoveEmptyEntries);
                if (values.Length < (ignorable_cols + value_cols))
                {
                    MessageBox.Show("Incorrect data in file.");
                    return;
                }
                string[] start_rows = new string[ignorable_cols];
                string[] value_rows = new string[value_cols];
                string[] end_rows = new string[(values.Length - ignorable_cols - value_cols) > 0 ? (values.Length - ignorable_cols - value_cols) : 1];
                
                for (int i = 0; i < values.Length; i++)
                {
                    if (i < ignorable_cols) start_rows[i] = values[i];
                    else if (i < ignorable_cols + value_cols) value_rows[i - ignorable_cols] = values[i];
                    else end_rows[i - ignorable_cols - value_cols] = values[i];
                }
                //string row = String.Join(splitter_out.ToString(), start_rows, value_rows, end_rows);
                for (int i = 0; i < value_rows.Length; i+=cols_out)
                {
                    text_out += String.Join(splitter_out.ToString(), start_rows);
                    for (int j=0; j<cols_out; j++)
                    {
                        text_out += splitter_out.ToString() + value_rows[i + j];
                    }
                    text_out += splitter_out.ToString() + String.Join(splitter_out.ToString(), end_rows) + "\r\n";
                }

            }
            //MessageBox.Show(text_out);
            Data.Filer.WriteFile(filename_out, text_out);
            
            MessageBox.Show($"Convertation is finished.\r\n Path: {filename_out}");

        }
        #endregion
    }
}
