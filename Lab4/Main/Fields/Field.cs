using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab4.Main
{
    public abstract class Field<T> where T : IComparable<int>, IComparable<DateTime>
         
    {
        public virtual T Value { get; }

        public abstract Field<T> Clone();

        public int CompareTo(int other)
        {
            return other.CompareTo(Value);
        }

        public int CompareTo(DateTime other)
        {
            return other.CompareTo(Value);
        }

        public abstract void CreateRule();
    }
}
