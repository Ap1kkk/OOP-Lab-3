using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.InputFieldView
{
    public abstract class InputFieldView<T> : IInputFieldView<T> where T : IComparable
    {
        public abstract T Value { get; }
        protected Label Label { get; } = new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter};
        protected TextBox MessageTextBox { get; } = new TextBox() { Dock = DockStyle.Fill, Enabled = false };


        public InputFieldView(string label)
        {
            Label.Text = label;
        }

        public virtual void Display(TableLayoutPanel layoutPanel)
        {
            layoutPanel.RowCount++;
            layoutPanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.AutoSize });
            layoutPanel.Controls.Add(Label);
        }
    }
}
