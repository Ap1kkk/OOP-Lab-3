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
    public class DateFieldFilterView : FieldFilterView<DateTime>
    {
        public override DateTime FilteringValue => _dateTimePicker.Value;

        public override ILogicalExpression<DateTime> LogicalExpression => _logicalExpression;
        private ILogicalExpression<DateTime> _logicalExpression;

        private DateTimePicker _dateTimePicker = new DateTimePicker() { };

        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==", AutoSize = true };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=", AutoSize = true };
        private RadioButton _lessRadioButton = new RadioButton() { Text = "<", AutoSize = true };
        private RadioButton _greaterRadioButton = new RadioButton() { Text = ">", AutoSize = true };

        public DateFieldFilterView(string label) : base(label)
        {
            Initialize();
        }
        ~DateFieldFilterView()
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

            tableLayoutPanel.Controls.Add(_dateTimePicker);
            LayoutPanel.Controls.Add(_equalsRadioButton);
            LayoutPanel.Controls.Add(_notEqualsRadioButton);
            LayoutPanel.Controls.Add(_lessRadioButton);
            LayoutPanel.Controls.Add(_greaterRadioButton);

            tableLayoutPanel.Controls.Add(LayoutPanel);
        }

        public override void EnableControls()
        {
            _dateTimePicker.Enabled = true;
            _equalsRadioButton.Enabled = true;
            _notEqualsRadioButton.Enabled = true;
            _lessRadioButton.Enabled = true;
            _greaterRadioButton.Enabled = true;
        }

        public override void DisableControls()
        {
            _dateTimePicker.Enabled = false;
            _equalsRadioButton.Enabled = false;
            _notEqualsRadioButton.Enabled = false;
            _lessRadioButton.Enabled = false;
            _greaterRadioButton.Enabled = false;
        }

        private void _equalsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<DateTime>(LogicalExpressions.Equals);
        }

        private void _notEqualsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<DateTime>(LogicalExpressions.NotEquals);
        }

        private void _lessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<DateTime>(LogicalExpressions.Less);
        }

        private void _greaterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<DateTime>(LogicalExpressions.Greater);
        }

    }
}
