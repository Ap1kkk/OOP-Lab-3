using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4.Main.FilterFieldVIew
{
    public class IntFieldFilterView : FieldFilterView<int>
    {
        public override int FilteringValue => int.Parse(_numericUpDown.Value.ToString());
        public override ILogicalExpression<int> LogicalExpression => _logicalExpression;
        private ILogicalExpression<int> _logicalExpression;

        private NumericUpDown _numericUpDown = new NumericUpDown() { };

        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==", AutoSize = true };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=", AutoSize = true };
        private RadioButton _lessRadioButton = new RadioButton() { Text = "<", AutoSize = true };
        private RadioButton _greaterRadioButton = new RadioButton() { Text = ">", AutoSize = true };

        public IntFieldFilterView(string label) : base(label)
        {
            Initialize();
        }
        ~IntFieldFilterView()
        {
            _equalsRadioButton.CheckedChanged -= _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged -= _notEqualsRadioButton_CheckedChanged;
            _lessRadioButton.CheckedChanged -= _lessRadioButton_CheckedChanged;
            _greaterRadioButton.CheckedChanged -= _greaterRadioButton_CheckedChanged;
        }

        protected override void Initialize()
        {
            base.Initialize();

            _equalsRadioButton.CheckedChanged += _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged += _notEqualsRadioButton_CheckedChanged;
            _lessRadioButton.CheckedChanged += _lessRadioButton_CheckedChanged;
            _greaterRadioButton.CheckedChanged += _greaterRadioButton_CheckedChanged;

            _equalsRadioButton.Checked = true;
        }

        public override void Display(TableLayoutPanel tableLayoutPanel)
        {
            base.Display(tableLayoutPanel);

            tableLayoutPanel.Controls.Add(_numericUpDown);
            LayoutPanel.Controls.Add(_equalsRadioButton);
            LayoutPanel.Controls.Add(_notEqualsRadioButton);
            LayoutPanel.Controls.Add(_lessRadioButton);
            LayoutPanel.Controls.Add(_greaterRadioButton);

            tableLayoutPanel.Controls.Add(LayoutPanel);
        }

        public override void EnableControls()
        {
            _numericUpDown.Enabled = true;
            _equalsRadioButton.Enabled = true;
            _notEqualsRadioButton.Enabled = true;
            _lessRadioButton.Enabled = true;
            _greaterRadioButton.Enabled = true;
        }

        public override void DisableControls()
        {
            _numericUpDown.Enabled = false;
            _equalsRadioButton.Enabled = false;
            _notEqualsRadioButton.Enabled = false;
            _lessRadioButton.Enabled = false;
            _greaterRadioButton.Enabled = false;
        }

        private void _equalsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<int>(LogicalExpressions.Equals);
        }

        private void _notEqualsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<int>(LogicalExpressions.NotEquals);
        }

        private void _lessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<int>(LogicalExpressions.Less);
        }

        private void _greaterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<int>(LogicalExpressions.Greater);
        }

    }
}
