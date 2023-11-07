using Lab_3;
using Lab4.Main.Expressions;
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

namespace Lab4.Main.Fields
{
    public class StreetField : Field<string>
    {
        public override string Name => _name;
        private const string _name = "Street";
        public StreetField() : base(new StringFieldFilterView(_name), new StringInputFieldView(_name))
        {
        }

        public override string Value
        {
            get { return Firm.Street; }
            set { Firm.Street = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(FirmViewElement.Street));
        }

        public override Field<string> Clone()
        {
            return new StreetField();
        }

        public override IFilterRule CreateRule()
        {
            return new StreetRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
