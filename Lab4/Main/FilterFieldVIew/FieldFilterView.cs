using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public abstract class FieldFilterView<T> : IFieldFilterView<T> where T : IComparable
    {
        public bool IsFilterActive => FilterCheckBox.Checked;
        public abstract T FilteringValue { get; }

        public abstract ILogicalExpression<T> LogicalExpression { get; }

        protected CheckBox FilterCheckBox { get; } = new CheckBox() { Text = "Filter", AutoSize = true };
        protected Label Label { get; } = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter };


        protected FlowLayoutPanel LayoutPanel = new FlowLayoutPanel() { Dock = DockStyle.Fill };

        public FieldFilterView(string label)
        {
            Label.Text = label;
        }
        ~FieldFilterView()
        {
            FilterCheckBox.CheckedChanged -= FilterCheckBox_CheckedChanged;
        }

        protected virtual void Initialize()
        {
            FilterCheckBox.CheckedChanged += FilterCheckBox_CheckedChanged;

            FilterCheckBox.Checked = false;
            DisableControls();
        }

        public virtual void Display(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.Controls.Add(FilterCheckBox);
            tableLayoutPanel.Controls.Add(Label);
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(FilterCheckBox.Checked)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        public abstract void EnableControls();
        public abstract void DisableControls();
    }
}
