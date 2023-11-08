using Lab4.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Forms.FilterForms
{
    public class FirmFilterForm : FilterForm
    {
        public FirmFilterForm(MainController mainController) : base(mainController)
        {
        }

        protected override void Initialize()
        {
            MainController.DisplayFirmFilters(FilterLayout);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MainController.DisplayFirmFilters(FilterLayout);
        }

        protected override void ApplyButton_Click(object sender, EventArgs e)
        {
            MainController.ApplyFirmFilter();
            Close();
        }
    }
}
