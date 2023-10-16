using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab4.Main
{
    public abstract class Field<T> where T : IComparable
    {
        public abstract IFilterRule<ILogicalExpression<T>, Field<T>, T> FilterRule { get; }
        public abstract T Value { get; }
        protected Firm Firm;

        public Field(Firm relatedFirm)
        {
            if (relatedFirm == null)
                throw new ArgumentNullException(nameof(relatedFirm));
            Firm = relatedFirm;
        }

        public abstract Field<T> Clone();
    }
}
