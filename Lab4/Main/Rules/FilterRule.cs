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
    public abstract class FilterRule<F, T> : IFilterRule<F, T> where T : IComparable where F : IFieldBase
    {
        public T ComparingValue { get; }
        public ILogicalExpression<T> LogicalExpression { get; }

        public FilterRule(T comparingValue, ILogicalExpression<T> logicalExpression)
        {
            ComparingValue = comparingValue;
            LogicalExpression = logicalExpression;
        }

        public bool FirmRespond(F comparable)
        {
            return LogicalExpression.Compare(ComparingValue, comparable as Field<T>);
        }
    }
}
