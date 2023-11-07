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

    public partial class FilterForm : Form
    {
        private MainController _mainController;
        public FilterForm(MainController maInController)
        {
            InitializeComponent();
            _mainController = maInController;
            _mainController.DisplayFilters(FilterTableLayout);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _mainController.DisplayFilters(FilterTableLayout);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _mainController.ApplyFilter();
            Close();
        }
    }
}
