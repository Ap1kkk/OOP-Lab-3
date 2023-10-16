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
    public class EnterDateField : Field<DateTime>
    {
        public EnterDateField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override DateTime Value => Firm.EnterDate;

        public override IFilterRule<ILogicalExpression<DateTime>, Field<DateTime>, DateTime> FilterRule
            => new EnterDateRule(this) as IFilterRule<ILogicalExpression<DateTime>, Field<DateTime>, DateTime>;

        public override Field<DateTime> Clone()
        {
            return new EnterDateField(Firm);
        }
    }
}
