using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class ContainsExpression : ILogicalExpression<string>
    {
        public bool Compare(string left, string right)
        {
            return right.Contains(left);
        }
    }
}
