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
        public bool IsFilterActive => _filterCheckBox.Checked;
        public abstract T FilteringValue { get; }

        public abstract ILogicalExpression<T> LogicalExpression { get; }

        protected FlowLayoutPanel LayoutPanel = new FlowLayoutPanel() { Dock = DockStyle.Fill, Size = new System.Drawing.Size(300, 50) };
        protected TableLayoutPanel TableLayoutPanel;

        private CheckBox _filterCheckBox { get; } = new CheckBox() { Text = "Filter", AutoSize = true };
        private Label _label { get; } = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter };


        public FieldFilterView(string label, TableLayoutPanel tableLayoutPanel)
        {
            _label.Text = label;
            TableLayoutPanel = tableLayoutPanel;
        }
        ~FieldFilterView()
        {
            _filterCheckBox.CheckedChanged -= FilterCheckBox_CheckedChanged;
        }

        protected virtual void Initialize()
        {
            _filterCheckBox.CheckedChanged += FilterCheckBox_CheckedChanged;

            _filterCheckBox.Checked = false;
            DisableControls();
        }

        public virtual void Display()
        {
            TableLayoutPanel.RowCount++;
            TableLayoutPanel.Controls.Add(_filterCheckBox);
            TableLayoutPanel.Controls.Add(_label);
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(_filterCheckBox.Checked)
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
