using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public abstract class FilterRule<T> : IFilterRule<T> where T : IComparable
    {
        public Field<T> Field { get; }

        public FilterRule(Field<T> relatedField)
        {
            if(relatedField == null)
                throw new ArgumentNullException(nameof(relatedField));
            Field = relatedField;
        }
            
        public bool FirmRespond(ILogicalExpression<T> expression, Field<T> comparable)
        {
            return expression.Compare(Field, comparable);
        }
    }
}
