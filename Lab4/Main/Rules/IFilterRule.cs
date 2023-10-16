using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public interface IFilterRule<L, F, T> where L : ILogicalExpression<T> where T : IComparable where F : Field<T>
    {
        F Field { get; }
        bool FirmRespond(L expression, F comparable);
    }
}
