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
    public class TownField : Field<string>
    {
        public override string Name => _name;
        private const string _name = "Town";
        public TownField() : base(new StringFieldFilterView(_name), new StringInputFieldView(_name))
        {
        }
        public override string Value
        {
            get { return Firm.Town; }
            set { Firm.Town = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(FirmViewElement.Town));
        }

        public override Field<string> Clone()
        {
            return new TownField();
        }

        public override IFilterRule CreateRule()
        {
            return new TownRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
