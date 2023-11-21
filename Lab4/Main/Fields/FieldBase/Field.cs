using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab4.Main.Fields
{
    public abstract class Field<T> : IField<T> where T : IComparable
    {
        public abstract string Name { get; }
        public abstract string DisplayingName { get; }
        public FieldViewType Type { get; }
        protected IFieldFilterView<T> FilterView { get; set; }

        public Field(FieldViewType fieldViewType)
        {
            Type = fieldViewType;
        }

        public abstract Field<T> Clone();

        public abstract IFilterRule CreateRule();
    }
}
