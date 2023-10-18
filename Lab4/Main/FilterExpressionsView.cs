using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public enum FilterExpressionTypes
    {
        String,
        DateTime,
        Int
    }
    public class FilterExpressionsView
    {
        public Panel Panel => _panel;
        private Panel _panel;
        private List<RadioButton> _filterExpressions = new List<RadioButton>();
        private Dictionary<LogicalExpressions, bool> _checkedLogicalExpressions = new Dictionary<LogicalExpressions, bool>();

        const string _equalsText = "==";
        const string _notEqualsText = "!=";
        const string _containsText = "Contains";
        const string _notContainsText = "Not contains";
        const string _lessText = "<";
        const string _greaterText = ">";

        public FilterExpressionsView(FilterExpressionTypes expressionType)
        {
            _panel = new Panel() { AutoSize = true };
            CheckBox filterCheckBox = new CheckBox();

            filterCheckBox.CheckedChanged += FilterCheckChanged;

            RadioButton equals = new RadioButton() { Text = _equalsText};
            equals.CheckedChanged += ExpressionCheckedChanged;
            RadioButton notEquals = new RadioButton() { Text = _notEqualsText};
            _filterExpressions.Add(equals);
            _checkedLogicalExpressions.Add(LogicalExpressions.Equals, false);
            _filterExpressions.Add(notEquals);
            _checkedLogicalExpressions.Add(LogicalExpressions.NotEquals, false);
            if(expressionType == FilterExpressionTypes.String)
            {
                RadioButton contains = new RadioButton() { Text = _containsText};
                _checkedLogicalExpressions.Add(LogicalExpressions.Contains, false);
                RadioButton notContains = new RadioButton() { Text = _notContainsText};
                _checkedLogicalExpressions.Add(LogicalExpressions.NotContains, false);

                _filterExpressions.Add(contains);
                _filterExpressions.Add(notContains);
            }
            else
            {
                RadioButton less = new RadioButton() { Text = _lessText};
                RadioButton greater = new RadioButton() { Text = _greaterText};
                _filterExpressions.Add(less);
                _checkedLogicalExpressions.Add(LogicalExpressions.Less, false);
                _filterExpressions.Add(greater);
                _checkedLogicalExpressions.Add(LogicalExpressions.Greater, false);
            }

            DisableExpressions();
        }

        private void ExpressionCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Text)
            {
                case _equalsText:
                    _checkedLogicalExpressions[LogicalExpressions.Equals] = radioButton.Checked;
                    break;
                case _notEqualsText:
                    _checkedLogicalExpressions[LogicalExpressions.NotEquals] = radioButton.Checked;
                    break;
                case _containsText:
                    _checkedLogicalExpressions[LogicalExpressions.Contains] = radioButton.Checked;
                    break;
                case _notContainsText:
                    _checkedLogicalExpressions[LogicalExpressions.NotContains] = radioButton.Checked;
                    break;
                case _lessText:
                    _checkedLogicalExpressions[LogicalExpressions.Less] = radioButton.Checked;
                    break;
                case _greaterText:
                    _checkedLogicalExpressions[LogicalExpressions.Greater] = radioButton.Checked;
                    break;
            }
        }

        private void FilterCheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                EnableExpressions();
            else
                DisableExpressions();
        }

        public void EnableExpressions()
        {
            foreach (var radioButton in _filterExpressions)
            {
                radioButton.Enabled = true;
            }
        }
        public void DisableExpressions()
        {
            foreach (var radioButton in _filterExpressions)
            {
                radioButton.Enabled = false;
            }
        }
    }
}
