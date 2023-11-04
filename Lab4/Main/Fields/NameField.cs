using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules;
using Lab4.Main.View;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields
{
    public class NameField : Field<string>
    {
        public NameField() : base(new StringFieldFilterView("Name"))
        {
        }

        public override string Value
        {
            get { return Firm.Name; }
            set { Firm.Name = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Name", nameof(FirmViewElement.Name));
        }

        public override Field<string> Clone()
        {
            return new NameField();
        }

        public override IFilterRule CreateRule()
        {
            return new NameRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
