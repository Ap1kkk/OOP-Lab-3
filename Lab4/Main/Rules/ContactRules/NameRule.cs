using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Rules.ContactRules
{
    public class NameRule : ContactFilterRule<string>
    {
        public NameRule(bool isFilterActive, string comparingValue, ILogicalExpression<string> logicalExpression)
            : base(isFilterActive, comparingValue, logicalExpression)
        {
        }

        public override bool ContactRespond(Contact contact)
        {
            return LogicalExpression.Compare(ComparingValue, contact.Type.Name);
        }
    }
}
