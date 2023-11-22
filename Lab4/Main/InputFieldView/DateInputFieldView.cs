using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.InputFieldView
{
    public class DateInputFieldView : InputFieldView<DateTime>
    {
        public override DateTime Value => _datePicker.Value;
        private DateTimePicker _datePicker = new DateTimePicker() { };

        public DateInputFieldView(string label) : base(label)
        {
        }

        public override void Display(TableLayoutPanel layoutPanel)
        {
            base.Display(layoutPanel);

            layoutPanel.Controls.Add(_datePicker);
            layoutPanel.Controls.Add(MessageTextBox);
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
