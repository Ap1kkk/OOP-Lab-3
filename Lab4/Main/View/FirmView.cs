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
        public List<FirmViewElement> DisplayFirmElements => Converter.ConvertFirms(_firmPool.Firms);
        public List<SubFirmViewElement> DisplaySubFirmsElements => Converter.ConvertFirmsToSubFirms(_firmPool.Firms);
        public List<ContactViewElement> DisplayContactsElements => Converter.ConvertFirmsToContacts(_firmPool.Firms);
        public List<IFieldBase> Fields => _fields;

        private List<IFieldBase> _fields = new List<IFieldBase>();

        private FirmPool _firmPool;

        public FirmView(FirmPool firmPool)
        {
            _firmPool = firmPool;
        }

        public void AddField(IFieldBase field)
        {
            _fields.Add(field);
        }

        public void DisplayFilters(TableLayoutPanel layoutPanel)
        {
            foreach (var field in _fields)
            {
                field.DisplayFilter(layoutPanel);
            }
        }

        public void DisplayColumns(DataGridView gridView)
        {
            foreach (var field in _fields)
            {
                field.AddDisplayingColumn(gridView);
            }
        }
    }
}
