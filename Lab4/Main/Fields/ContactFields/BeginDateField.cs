using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using Lab4.Main.Rules;
using Lab4.Main.Rules.ContactRules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields.ContactFields
{
    public class BeginDateField : Field<DateTime>
    {
        public override string Name => _name;
        private const string _name = "Begin date";

        public BeginDateField() : base(new DateFieldFilterView(_name), new DateInputFieldView(_name))
        {
        }
        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(ContactViewElement.Description));
        }

        public override Field<DateTime> Clone()
        {
            return new BeginDateField();
        }

        public override IFilterRule CreateRule()
        {
            return new BeginDateRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
