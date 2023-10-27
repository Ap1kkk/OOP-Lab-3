using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public interface IFilterRule<T>  where T : IComparable
    {
        Field<T> Field { get; }
        bool FirmRespond(ILogicalExpression<T> expression, Field<T> comparable);
    }
}
