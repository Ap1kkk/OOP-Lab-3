using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public class FieldCheckBox
    {
        public event Action<bool, IFieldBase> CheckChanged;

        public CheckBox CheckBox { get; } = new CheckBox();
        private IFieldBase _relatedField;
        public FieldCheckBox(string label, IFieldBase field)
        {
            _relatedField = field;
            CheckBox.Text = label;
            CheckBox.Checked = false;

            CheckBox.CheckedChanged += _checkBox_CheckedChanged;
        }

        private void _checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged?.Invoke(CheckBox.Checked, _relatedField);
        }
    }
}
