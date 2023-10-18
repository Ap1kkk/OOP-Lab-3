using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirmNameFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(FirmNameFilter.Checked)
            {

            }
        }


        private Panel CreateStringExpressionsView()
        {
            Panel panel = new Panel() {AutoSize = true };
            CheckBox filterCheckBox = new CheckBox() { Text = "filter" };



            return panel;
        }
    }
}
