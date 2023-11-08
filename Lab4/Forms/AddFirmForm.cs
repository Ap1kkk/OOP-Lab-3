using Lab4.Main;
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
    public partial class AddFirmForm : Form
    {
        private FirmFieldPool _fieldPool;
        public AddFirmForm(FirmFieldPool fieldPool)
        {
            InitializeComponent();
            _fieldPool = fieldPool;

            foreach (var item in _fieldPool.Fields)
            {
                item.DisplayInput(InputLayoutPanel);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private bool ValidateInputFirm()
        {
            return false;
        }
    }
}
