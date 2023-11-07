using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using Lab4.Main.Rules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields.FirmFields
{
    public class RegionField : Field<string>
    {
        public override string Name => _name;
        private const string _name = "Region";

        public RegionField() : base(new StringFieldFilterView(_name), new StringInputFieldView(_name))
        {
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(FirmViewElement.Region));
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
