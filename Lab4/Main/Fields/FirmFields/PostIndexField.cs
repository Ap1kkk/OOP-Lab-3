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
    public class PostIndexField : Field<string>
    {
        public override string DisplayingName => _name;
        public override string Name => nameof(FirmViewElement.PostIndex);
        private const string _name = "Post index";

        public PostIndexField()
            : base(FieldViewType.String)
        {
        }

        public override Field<string> Clone()
        {
            return new PostIndexField();
        }

        public override IFilterRule CreateRule()
        {
            return new PostIndexRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
