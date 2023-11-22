using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules;
using Lab4.Main.Rules.FirmRules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Fields.FirmFields
{
    public class XField : Field<string>
    {
        public override string Name => nameof(FirmViewElement.X);
        public override string DisplayingName => _name;

        private const string _name = "X";

        public XField() : base(FieldViewType.String)
        {
        }

        public override Field<string> Clone()
        {
            return new XField();
        }

        public override IFilterRule CreateRule()
        {
            return new XFieldRule();
        }
    }
}
