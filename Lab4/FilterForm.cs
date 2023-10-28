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
        FilterSelector _filterSelector = new FilterSelector(FirmPool.Instance);

        public FilterForm()
        {
            InitializeComponent();

            //_filterView = new FieldFilterView<NameRule>(FilterRuleType.String, "msgapn");
            //_filterView.Display(FilterTableLayout);
            _filterSelector.Display(FilterTableLayout);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _filterSelector.GetSelectedFirms();
        }
    }
}
