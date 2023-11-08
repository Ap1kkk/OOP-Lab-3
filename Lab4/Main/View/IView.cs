using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.View
{
    public interface IView
    {
        List<IFieldBase> Fields { get; }
        void ClearFields();
        void AddField(IFieldBase field);

        void DisplayFilters(TableLayoutPanel filterLayout);

        void DisplayColumns(DataGridView fieldsView);

        void DisplayInputs(TableLayoutPanel inputLayout);
    }
}
