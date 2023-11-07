using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.ContactRules
{
    public abstract class ContactFilterRule<T> : IContactFilterRule where T : IComparable
    {
        public bool IsFilterActive { get; }

        protected T ComparingValue { get; }
        protected ILogicalExpression<T> LogicalExpression { get; }


        public ContactFilterRule(bool isFilterActive, T comparingValue, ILogicalExpression<T> logicalExpression)
        {
            IsFilterActive = isFilterActive;
            ComparingValue = comparingValue;
            LogicalExpression = logicalExpression;
        }

        public abstract bool ContactRespond(Contact contact);
    }
}
