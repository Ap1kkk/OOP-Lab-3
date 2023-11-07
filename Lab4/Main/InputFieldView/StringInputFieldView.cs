using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.InputFieldView
{
    public class StringInputFieldView : InputFieldView<string>
    {
        public override string Value => _inputTextBox.Text;
        private TextBox _inputTextBox = new TextBox() { };

        public StringInputFieldView(string label) : base(label)
        {
        }

        public override void Display(TableLayoutPanel layoutPanel)
        {
            base.Display(layoutPanel);

            layoutPanel.Controls.Add(_inputTextBox);
            layoutPanel.Controls.Add(MessageTextBox);
        }
    }
}
