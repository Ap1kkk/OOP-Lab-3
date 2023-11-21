using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields
{
    public interface IFieldBase
    {
        string DisplayingName { get; }
        string Name { get; }
        FieldViewType Type { get; }
        IFilterRule CreateRule();
    }
}
