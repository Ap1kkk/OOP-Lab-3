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

    public class FieldFilterView<F> where F : class, IFilterRuleBase
    {
        private Label _label = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter};
        private TextBox _textBox = new TextBox() { Text = "Searching string", TextAlign = HorizontalAlignment.Center};
        private DateTimePicker _dateTimePicker = new DateTimePicker() { };
        private NumericUpDown _numericUpDown = new NumericUpDown() { };

        private CheckBox _filterCheckBox = new CheckBox() { Text = "filter"};
        private RadioButton _equalsRadioButton = new RadioButton() { Text = "=="};
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=" };
        private RadioButton _containsRadioButton = new RadioButton() { Text = "contains" };
        private RadioButton _notContainsRadioButton = new RadioButton() { Text = "not contains" };
        private RadioButton _lessRadioButton = new RadioButton() { Text = "<" };
        private RadioButton _greaterRadioButton = new RadioButton() { Text = ">" };

        private LogicalExpressions _currentLogicalExpression;

        FilterRuleType _ruleType;

        public FieldFilterView(FilterRuleType ruleType, string label)
        {
            _ruleType = ruleType;
            _label.Text = label;

            _filterCheckBox.CheckedChanged += _filterCheckBox_CheckedChanged;
            _filterCheckBox.Checked = false;
            DisableRadioButtons();

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

        public void Display(TableLayoutPanel tableLayoutPanel)
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
            tableLayoutPanel.Controls.Add(_equalsRadioButton);
            tableLayoutPanel.Controls.Add(_notEqualsRadioButton);
            switch (_ruleType)
            {
                case FilterRuleType.String:
                    tableLayoutPanel.Controls.Add(_containsRadioButton);
                    tableLayoutPanel.Controls.Add(_notContainsRadioButton);
                    break;
                default:
                    tableLayoutPanel.Controls.Add(_lessRadioButton);
                    tableLayoutPanel.Controls.Add(_greaterRadioButton);
                    break;
            }
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
