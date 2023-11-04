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
    public class EnterDateField : Field<DateTime>
    {
        public EnterDateField() : base(new DateFieldFilterView("Enter date"))
        {
        }

        public override DateTime Value
        {
            get { return Firm.EnterDate; }
            set { Firm.EnterDate = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Enter date", nameof(FirmViewElement.EnterDate));
        }

        public override Field<DateTime> Clone()
        {
            return new EnterDateField();
        }

        public override IFilterRule CreateRule()
        {
            return new EnterDateRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
