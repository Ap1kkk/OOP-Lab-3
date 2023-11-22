using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.View
{
    public abstract class ViewBase : IView
    {
        public List<IFieldBase> Fields => _fields;

        private List<IFieldBase> _fields = new List<IFieldBase>();

        public void ClearFields()
        {
            _fields.Clear();
        }
        public void AddField(IFieldBase field)
        {
            _fields.Add(field);
        }
    }
}
