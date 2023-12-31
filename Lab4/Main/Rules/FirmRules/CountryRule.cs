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
    public class CountryRule : FirmFilterRule<string>
    {
        //public CountryRule(bool isFilterActive, string comparingValue, ILogicalExpression<string> logicalExpression)
        //    : base(isFilterActive, comparingValue, logicalExpression)
        //{
        //}
        public override bool FirmRespond(Firm firm)
        {
            return LogicalExpression.Compare(ComparingValue, firm.Country);
        }
    }
}
