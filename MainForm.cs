using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FirmFactory _firmFactory = new FirmFactory();
            _firmFactory.Create("1", "2", "3", "4", "5", "6", "7", "8", new DateTime(2004, 4, 7), "9", "10", "11");
        }
    }
}
