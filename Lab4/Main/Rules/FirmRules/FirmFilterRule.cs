using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.Rules.FirmRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public abstract class FirmFilterRule<T> : IFirmFilterRule where T : IComparable
    {
        public bool IsFilterActive { get; }

        protected T ComparingValue { get; }
        protected ILogicalExpression<T> LogicalExpression { get; }


        public FirmFilterRule(bool isFilterActive, T comparingValue, ILogicalExpression<T> logicalExpression)
        {
            IsFilterActive = isFilterActive;
            ComparingValue = comparingValue;
            LogicalExpression = logicalExpression;
        }

        public abstract bool FirmRespond(Firm firm);
    }
}
