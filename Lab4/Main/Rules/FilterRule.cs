using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public abstract class FilterRule<L, F, T> : IFilterRule<L, F, T> where L : ILogicalExpression<T> where T : IComparable where F : Field<T>
    {
        public F Field { get; }

        public FilterRule(F relatedField)
        {
            if(relatedField == null)
                throw new ArgumentNullException(nameof(relatedField));
            Field = relatedField;
        }
            
        public bool FirmRespond(L expression, F comparable)
        {
            return expression.Compare(Field, comparable);
        }
    }
}
