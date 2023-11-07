using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.ContactRules
{
    public class EndDateRule : ContactFilterRule<DateTime>
    {
        public EndDateRule(bool isFilterActive, DateTime comparingValue, ILogicalExpression<DateTime> logicalExpression)
            : base(isFilterActive, comparingValue, logicalExpression)
        {
        }

        public override bool ContactRespond(Contact contact)
        {
            return LogicalExpression.Compare(ComparingValue, contact.EndDate);
        }
    }
}
