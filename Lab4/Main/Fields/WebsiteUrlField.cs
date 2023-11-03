using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields
{
    public class WebsiteUrlField : Field<string>
    {
        public WebsiteUrlField() : base(new StringFieldFilterView("Website url"))
        {
        }
        public override string Value
        {
            get { return Firm.WebsiteUrl; }
            set { Firm.WebsiteUrl = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Website Url", nameof(FirmViewElement.WebsiteUrl));
        }

        public override Field<string> Clone()
        {
            return new WebsiteUrlField();
        }

        public override IFilterRule CreateRule()
        {
            return new WebsiteUrlRule(FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
