using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public class StringFieldFilterView : FieldFilterView<string>
    {
        public override string FilteringValue => _textBox.Text;
        public override ILogicalExpression<string> LogicalExpression => _logicalExpression;
        private ILogicalExpression<string> _logicalExpression;

        private TextBox _textBox = new TextBox() { Text = "Search", TextAlign = HorizontalAlignment.Center };

        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==", AutoSize = true };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=", AutoSize = true };
        private RadioButton _containsRadioButton = new RadioButton() { Text = "contains", AutoSize = true };
        private RadioButton _notContainsRadioButton = new RadioButton() { Text = "not contains", AutoSize = true };

        public StringFieldFilterView(string label) : base(label)
        {
            Initialize();
        }
        ~StringFieldFilterView()
        {
            _equalsRadioButton.CheckedChanged -= _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged -= _notEqualsRadioButton_CheckedChanged;
            _containsRadioButton.CheckedChanged -= _containsRadioButton_CheckedChanged;
            _notContainsRadioButton.CheckedChanged -= _notContainsRadioButton_CheckedChanged;
        }

        public override void Display(TableLayoutPanel tableLayoutPanel)
        {
            base.Display(tableLayoutPanel);

            tableLayoutPanel.Controls.Add(_textBox);
            LayoutPanel.Controls.Add(_equalsRadioButton);
            LayoutPanel.Controls.Add(_notEqualsRadioButton);
            LayoutPanel.Controls.Add(_containsRadioButton);
            LayoutPanel.Controls.Add(_notContainsRadioButton);

            tableLayoutPanel.Controls.Add(LayoutPanel);
        }

        protected override void Initialize()
        {
            base.Initialize();

            _equalsRadioButton.CheckedChanged += _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged += _notEqualsRadioButton_CheckedChanged;
            _containsRadioButton.CheckedChanged += _containsRadioButton_CheckedChanged;
            _notContainsRadioButton.CheckedChanged += _notContainsRadioButton_CheckedChanged;

            _equalsRadioButton.Checked = true;
        }

        public override void EnableControls()
        {
            _textBox.Enabled = true;
            _equalsRadioButton.Enabled = true;
            _notEqualsRadioButton.Enabled = true;
            _containsRadioButton.Enabled = true;
            _notContainsRadioButton.Enabled = true;
        }

        public override void DisableControls()
        {
            _textBox.Enabled = false;
            _equalsRadioButton.Enabled = false;
            _notEqualsRadioButton.Enabled = false;
            _containsRadioButton.Enabled = false;
            _notContainsRadioButton.Enabled = false;
        }

        private void _containsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<string>(LogicalExpressions.Contains);
        }

        private void _notContainsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<string>(LogicalExpressions.NotContains);
        }

        private void _equalsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<string>(LogicalExpressions.Equals);
        }

        private void _notEqualsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _logicalExpression = LogicalExpressionFactory.Create<string>(LogicalExpressions.NotEquals);
        }
    }
}
