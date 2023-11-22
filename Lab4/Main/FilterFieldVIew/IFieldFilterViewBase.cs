using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public interface IFieldFilterViewBase
    {
        void Display();
        //bool IsFilterActive { get; }
        //T GetValue<T>() where T : IComparable;
        //ILogicalExpression<T> GetLogicalExpression<T>() where T :IComparable;
    }
}
