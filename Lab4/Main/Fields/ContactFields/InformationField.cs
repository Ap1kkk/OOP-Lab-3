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
    public class InformationField : Field<string>
    {
        public override string Name => _name;
        private const string _name = "Information";

        public InformationField() : base(new StringFieldFilterView(_name), new StringInputFieldView(_name))
        {
        }
        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(ContactViewElement.Information));
        }

        public override Field<string> Clone()
        {
            return new NoteField();
        }

        public override IFilterRule CreateRule()
        {
            return new InformationRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
