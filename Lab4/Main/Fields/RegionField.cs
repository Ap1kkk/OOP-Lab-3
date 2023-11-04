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
    public class RegionField : Field<string>
    {
        public RegionField() : base(new StringFieldFilterView("Reegion"))
        {
        }

        public override string Value
        {
            get { return Firm.Region; }
            set { Firm.Region = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Region", nameof(FirmViewElement.Region));
        }

        public override Field<string> Clone()
        {
            return new RegionField();
        }

        public override IFilterRule CreateRule()
        {
            return new RegionRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
