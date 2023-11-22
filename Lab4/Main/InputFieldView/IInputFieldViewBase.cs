using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.InputFieldView
{
    public interface IInputFieldViewBase
    {
        void Display(TableLayoutPanel layoutPanel);
        bool Validate();
        void ResetMessage();
    }
}
