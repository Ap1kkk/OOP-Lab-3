using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{
    public class StringFieldFilterView : IFieldFilterView<string>
    {
        public string FilteringValue => _textBox.Text;
        public ILogicalExpression<string> LogicalExpression { get; }


        private Label _label = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
        private TextBox _textBox = new TextBox() { Text = "Search", TextAlign = HorizontalAlignment.Center };

        private CheckBox _filterCheckBox = new CheckBox() { Text = "filter" };
        private RadioButton _equalsRadioButton = new RadioButton() { Text = "==" };
        private RadioButton _notEqualsRadioButton = new RadioButton() { Text = "!=" };
        private RadioButton _containsRadioButton = new RadioButton() { Text = "contains" };
        private RadioButton _notContainsRadioButton = new RadioButton() { Text = "not contains" };

        public StringFieldFilterView(string label)
        {
            _label.Text = label;

            LogicalExpression = LogicalExpressionFactory.Create<string>(LogicalExpressions.NotContains);
        }

        public void Display(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.Controls.Add(_label);

            tableLayoutPanel.Controls.Add(_textBox);
            tableLayoutPanel.Controls.Add(_filterCheckBox);
            tableLayoutPanel.Controls.Add(_equalsRadioButton);
            tableLayoutPanel.Controls.Add(_notEqualsRadioButton);
            tableLayoutPanel.Controls.Add(_containsRadioButton);
            tableLayoutPanel.Controls.Add(_notContainsRadioButton);
        }


    }
}
