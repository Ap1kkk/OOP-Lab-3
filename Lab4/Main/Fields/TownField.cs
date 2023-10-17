using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Fields
{
    public class TownField : Field<string>
    {
        public TownField(Firm relatedFirm) : base(relatedFirm)
        {
        }
        public override string Value
        {
            get { return Firm.Town; }
            set { Firm.Town = value; }
        }

        protected override IFilterRule<ILogicalExpression<string>, Field<string>, string> FilterRule =>
            new TownRule(this) as IFilterRule<ILogicalExpression<string>, Field<string>, string>;

        public override Field<string> Clone()
        {
            return new TownField(Firm);
        }
    }
}
