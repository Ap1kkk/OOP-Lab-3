using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.ContactRules
{
    public class DescriptionRule : ContactFilterRule<string>
    {
        public DescriptionRule(bool isFilterActive, string comparingValue, ILogicalExpression<string> logicalExpression)
            : base(isFilterActive, comparingValue, logicalExpression)
        {
        }

        public override bool ContactRespond(Contact contact)
        {
            return LogicalExpression.Compare(ComparingValue, contact.Description);
        }
    }
}
