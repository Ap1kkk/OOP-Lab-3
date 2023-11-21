using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using Lab4.Main.Rules;
using Lab4.Main.Rules.FirmRules;
using Lab4.Main.View;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields.FirmFields
{
    public class NameField : Field<string>
    {
        public override string DisplayingName => _name;
        public override string Name => nameof(FirmViewElement.Name);
        private const string _name = "Name";

        public NameField()
            : base(FieldViewType.String)
        {
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
