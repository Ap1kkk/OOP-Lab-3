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
using System.Xml.Linq;

namespace Lab4.Main.Fields.FirmFields
{
    public class UserField : Field<string>
    {
        public override string DisplayingName => _fieldName;
        public override string Name => _fieldName;
        private readonly string _fieldName;

        public UserField(string fieldName) 
            : base(FieldViewType.String)
        {
            _fieldName = fieldName;
        }

        public override Field<string> Clone()
        {
            return new UserField(_fieldName);
        }

        public override IFilterRule CreateRule()
        {
            return new UserFieldRule(FilterView.IsFilterActive, _fieldName, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
