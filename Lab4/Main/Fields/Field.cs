using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab4.Main
{
    public abstract class Field<T> : IFieldBase where T : IComparable
    {
        public abstract string Name { get; }
        public abstract T Value { get; set; }
        protected IFieldFilterView<T> FilterView { get; }
        protected Firm Firm;

        public Field(IFieldFilterView<T> filterView)
        {
            FilterView = filterView;
        }

        public abstract Field<T> Clone();

        public abstract IFilterRule CreateRule();

        public abstract void AddDisplayingColumn(DataGridView gridView);
        public void DisplayFilter(TableLayoutPanel layoutPanel)
        {
            FilterView.Display(layoutPanel);
        }

        protected void AddDisplayingColumn(DataGridView gridView, string name, string dataPropertyName)
        {
            gridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = name, DataPropertyName = dataPropertyName });
        }

    }
}
