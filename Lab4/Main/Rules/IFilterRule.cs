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
    public interface IFilterRule<F, T> : IFilterRuleBase where T : IComparable where F : IFieldBase
    {
        T ComparingValue { get; }
        ILogicalExpression<T> LogicalExpression { get; }
        bool FirmRespond(F comparable);
    }
}
