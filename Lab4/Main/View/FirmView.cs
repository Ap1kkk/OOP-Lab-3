using Lab_3;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.View
{
    public class FirmView
    {
        public event Action<List<string>> OnFieldsChanged;

        public List<IFieldBase> Fields => _fields;
        public List<string> FieldNames => Converter.ConvertFields(Fields);

        private List<IFieldBase> _fields = new List<IFieldBase>();

        public void ClearFields()
        {
            _fields.Clear();
            OnFieldsChanged?.Invoke(FieldNames);
        }
        public void AddField(IFieldBase field)
        {
            _fields.Add(field);
            OnFieldsChanged?.Invoke(FieldNames);
        }
        public void AddField(List<IFieldBase> fields)
        {
            _fields.AddRange(fields);
            OnFieldsChanged?.Invoke(FieldNames);
        }
    }
}
