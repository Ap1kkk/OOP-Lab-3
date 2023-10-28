using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public class RegionRule : FilterRule<RegionField, string>
    {
        public RegionRule(string comparingValue, ILogicalExpression<string> logicalExpression) : base(comparingValue, logicalExpression)
        {
        }
    }
}
