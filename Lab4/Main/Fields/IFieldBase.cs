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
        string Name { get; }
        void AddDisplayingColumn(DataGridView gridView);
        void DisplayFilter(TableLayoutPanel layoutPanel);
        IFilterRule CreateRule();
    }
}
