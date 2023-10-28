using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public enum FilterRuleType
    {
        String,
        DateTime,
        Int
    }

    public class FieldFilterView<F> : FieldFilterViewBase where F : class, IFilterRuleBase
    {
        private Label _label = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter};
        private TextBox _textBox = new TextBox() { Text = "Searching string", TextAlign = HorizontalAlignment.Center};
        private DateTimePicker _dateTimePicker = new DateTimePicker() { };
        private NumericUpDown _numericUpDown = new NumericUpDown() { };

        private FlowLayoutPanel _layoutPanel = new FlowLayoutPanel() { Dock = DockStyle.Fill};

        private CheckBox _filterCheckBox = new CheckBox() { Text = "filter", AutoSize = true};
        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==", AutoSize = true };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=" , AutoSize = true };
        private RadioButton _containsRadioButton = new RadioButton() { Text = "contains" , AutoSize = true };
        private RadioButton _notContainsRadioButton = new RadioButton() { Text = "not contains", AutoSize = true };
        private RadioButton _lessRadioButton = new RadioButton() { Text = "<" , AutoSize = true };
        private RadioButton _greaterRadioButton = new RadioButton() { Text = ">" , AutoSize = true };

        private LogicalExpressions _currentLogicalExpression;

        FilterRuleType _ruleType;

        public FieldFilterView(FilterRuleType ruleType, string label)
        {
            _ruleType = ruleType;
            _label.Text = label;

            _filterCheckBox.CheckedChanged += _filterCheckBox_CheckedChanged;
            _filterCheckBox.Checked = false;
            DisableRadioButtons();

            _equalsRadioButton.CheckedChanged += _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged += _notEqualsRadioButton_CheckedChanged;
            _containsRadioButton.CheckedChanged += _containsRadioButton_CheckedChanged;
            _notContainsRadioButton.CheckedChanged += _notContainsRadioButton_CheckedChanged;
            _lessRadioButton.CheckedChanged += _lessRadioButton_CheckedChanged;
            _greaterRadioButton.CheckedChanged += _greaterRadioButton_CheckedChanged;


            _layoutPanel.Controls.Add(_equalsRadioButton);
            _layoutPanel.Controls.Add(_notEqualsRadioButton);

            switch (_ruleType)
            {
                case FilterRuleType.String:
                    _layoutPanel.Controls.Add(_containsRadioButton);
                    _layoutPanel.Controls.Add(_notContainsRadioButton);
                    break;
                default:
                    _layoutPanel.Controls.Add(_lessRadioButton);
                    _layoutPanel.Controls.Add(_greaterRadioButton);
                    break;
            }
        }
        ~FieldFilterView()
        {
            _filterCheckBox.CheckedChanged -= _filterCheckBox_CheckedChanged;

            _equalsRadioButton.CheckedChanged -= _equalsRadioButton_CheckedChanged;
            _notEqualsRadioButton.CheckedChanged -= _notEqualsRadioButton_CheckedChanged;
            _containsRadioButton.CheckedChanged -= _containsRadioButton_CheckedChanged;
            _notContainsRadioButton.CheckedChanged -= _notContainsRadioButton_CheckedChanged;
            _lessRadioButton.CheckedChanged -= _lessRadioButton_CheckedChanged;
            _greaterRadioButton.CheckedChanged -= _greaterRadioButton_CheckedChanged;

        }

        public F GetFilterRule()
        {
            object filterRule = null;
            if(!_filterCheckBox.Checked)
            {
                return filterRule as F;
            }

            switch (_ruleType)
            {
                case FilterRuleType.String:
                    return (F)Activator.CreateInstance(typeof(F), _textBox.Text, LogicalExpressionFactory.Create<string>(_currentLogicalExpression));
                case FilterRuleType.DateTime:
                    return (F)Activator.CreateInstance(typeof(F), _dateTimePicker.Value, LogicalExpressionFactory.Create<DateTime>(_currentLogicalExpression));
                case FilterRuleType.Int:
                    return (F)Activator.CreateInstance(typeof(F), _numericUpDown.Text, LogicalExpressionFactory.Create<int>(_currentLogicalExpression));
                default:
                    return null;
            }

        }

        public override void Display(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.Controls.Add(_label);

            switch (_ruleType)
            {
                case FilterRuleType.String:
                    tableLayoutPanel.Controls.Add(_textBox);
                    break;
                case FilterRuleType.DateTime:
                    tableLayoutPanel.Controls.Add(_dateTimePicker);
                    break;
                case FilterRuleType.Int:
                    tableLayoutPanel.Controls.Add(_numericUpDown);
                    break;
                default:
                    break;
            }
            tableLayoutPanel.Controls.Add(_filterCheckBox);


            tableLayoutPanel.Controls.Add(_layoutPanel);
        }

        private void _greaterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.Greater;
        }

        private void _lessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.Less; 
        }

        private void _notContainsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.NotContains; 
        }

        private void _containsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.Contains; 
        }

        private void _notEqualsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.NotEquals;
        }

        private void _equalsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentLogicalExpression = LogicalExpressions.Equals;
        }

        private void _filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(_filterCheckBox.Checked)
            {
                EnableRadioButtons();
            }
            else
            {
                DisableRadioButtons();
            }
        }

        private void DisableRadioButtons()
        {
            _equalsRadioButton.Enabled = false;
            _notEqualsRadioButton.Enabled = false;
            _containsRadioButton.Enabled = false;
            _notContainsRadioButton.Enabled = false;
            _lessRadioButton.Enabled = false;
            _greaterRadioButton.Enabled = false;
        }
        private void EnableRadioButtons()
        {
            _equalsRadioButton.Enabled = true;
            _notEqualsRadioButton.Enabled = true;
            _containsRadioButton.Enabled = true;
            _notContainsRadioButton.Enabled = true;
            _lessRadioButton.Enabled = true;
            _greaterRadioButton.Enabled = true;
        }
    }
}
