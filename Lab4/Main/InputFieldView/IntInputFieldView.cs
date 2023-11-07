using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.InputFieldView
{
    public class IntInputFieldView : InputFieldView<int>
    {
        public override int Value => int.Parse(_numericUpDown.Value.ToString());

        private NumericUpDown _numericUpDown = new NumericUpDown() { };

        public IntInputFieldView(string label) : base(label)
        {
        }

        public override void Display(TableLayoutPanel layoutPanel)
        {
            base.Display(layoutPanel);

            layoutPanel.Controls.Add(_numericUpDown);
            layoutPanel.Controls.Add(MessageTextBox);
        }
    }
}
