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
    public class StreetField : Field<string>
    {
        public override string DisplayingName => _name;
        public override string Name => nameof(FirmViewElement.Street);
        private const string _name = "Street";

        public StreetField()
            : base(FieldViewType.String)
        {
        }

        public override Field<string> Clone()
        {
            return new StreetField();
        }

        public override IFilterRule CreateRule()
        {
            return new StreetRule();
        }
    }
}
