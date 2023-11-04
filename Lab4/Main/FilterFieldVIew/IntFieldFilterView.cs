using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public class IntFieldFilterView : IFieldFilterView<int>
    {
        public int FilteringValue => int.Parse(_numericUpDown.Value.ToString());
        public ILogicalExpression<int> LogicalExpression { get; }

        public bool IsFilterActive => throw new NotImplementedException();

        private Label _label = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
        private NumericUpDown _numericUpDown = new NumericUpDown() { };

        private CheckBox _filterCheckBox = new CheckBox() { Text = "filter" };
        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==" };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=" };
        private RadioButton _lessRadioButton = new RadioButton() { Text = "<" };
        private RadioButton _greaterRadioButton = new RadioButton() { Text = ">" };

        public IntFieldFilterView(string label)
        {
            _label.Text = label;
        }

        public void Display(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.Controls.Add(_label);
            tableLayoutPanel.Controls.Add(_numericUpDown);

            tableLayoutPanel.Controls.Add(_filterCheckBox);
            tableLayoutPanel.Controls.Add(_equalsRadioButton);
            tableLayoutPanel.Controls.Add(_notEqualsRadioButton);
            tableLayoutPanel.Controls.Add(_lessRadioButton);
            tableLayoutPanel.Controls.Add(_greaterRadioButton);
        }
    }
}
