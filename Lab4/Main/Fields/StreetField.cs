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
    public class StreetField : Field<string>
    {
        public StreetField() : base(new StringFieldFilterView("Street"))
        {
        }

        public override string Value
        {
            get { return Firm.Street; }
            set { Firm.Street = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Street", nameof(FirmViewElement.Street));
        }

        public override Field<string> Clone()
        {
            return new StreetField();
        }

        public override IFilterRule CreateRule()
        {
            return new StreetRule(FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
