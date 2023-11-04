using Lab4.Main.Expressions;
using Lab4.Main.FilterFieldVIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public interface IFieldFilterView<T> : IFieldFilterViewBase where T : IComparable
    {
        bool IsFilterActive { get; }
        T FilteringValue { get; }
        ILogicalExpression<T> LogicalExpression { get; }
    }
}
