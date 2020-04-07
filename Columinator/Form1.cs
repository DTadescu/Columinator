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
        public MainForm()
        {
            InitializeComponent();
        }

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
    }
}
