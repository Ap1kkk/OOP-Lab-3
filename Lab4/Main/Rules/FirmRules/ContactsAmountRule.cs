using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public class ContactsAmountRule : FirmFilterRule<int>
    {
        public ContactsAmountRule(bool isFilterActive, int comparingValue, ILogicalExpression<int> logicalExpression) 
            : base(isFilterActive, comparingValue, logicalExpression)
        {
        }

        public override bool FirmRespond(Firm firm)
        {
            return LogicalExpression.Compare(ComparingValue, firm.ContactsAmount);
        }
    }
}
