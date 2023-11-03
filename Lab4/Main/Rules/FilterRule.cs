﻿using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public abstract class FilterRule<T> : IFilterRule where T : IComparable
    {
        protected T ComparingValue { get; }
        protected ILogicalExpression<T> LogicalExpression { get; }

        public FilterRule(T comparingValue, ILogicalExpression<T> logicalExpression)
        {
            ComparingValue = comparingValue;
            LogicalExpression = logicalExpression;
        }

        public abstract bool FirmRespond(Firm firm);
    }
}
