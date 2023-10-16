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
    public class ContactsAmountField : Field<int>
    {
        public ContactsAmountField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override int Value => Firm.Main.CountContacts;

        public override IFilterRule<ILogicalExpression<int>, Field<int>, int> FilterRule =>
            new ContactsAmountRule(this) as IFilterRule<ILogicalExpression<int>, Field<int>, int>;

        public override Field<int> Clone()
        {
            return new ContactsAmountField(Firm);
        }

    }
}
