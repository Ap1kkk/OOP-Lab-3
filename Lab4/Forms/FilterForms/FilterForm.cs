using Lab4.Main;
using Lab4.Main.Rules;
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

    public abstract partial class FilterForm : Form
    {
        protected readonly MainController MainController;
        protected TableLayoutPanel FilterLayout => FilterTableLayout;
        public FilterForm(MainController mainController)
        {
            InitializeComponent();
            MainController = mainController;
            Initialize();
        }

        protected abstract void Initialize();
        protected abstract void ApplyButton_Click(object sender, EventArgs e);
    }
}
