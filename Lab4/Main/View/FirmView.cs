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
        //public List<FirmViewElement> DisplayFirmElements => Converter.ConvertFirms(_firmPool.Firms);
        //public List<SubFirmViewElement> DisplaySubFirmsElements => Converter.ConvertFirmsToSubFirms(_firmPool.Firms);
        //public List<ContactViewElement> DisplayContactsElements => Converter.ConvertFirmsToContacts(_firmPool.Firms);
        public List<IFieldBase> Fields => _fields;

        private List<IFieldBase> _fields = new List<IFieldBase>();

        private FirmPool _firmPool;

        public FirmView(FirmPool firmPool)
        {
            _firmPool = firmPool;
        }

        public void ClearFields()
        {
            _fields.Clear();
        }
        public void AddField(IFieldBase field)
        {
            _fields.Add(field);
        }

        public void DisplayFilters(TableLayoutPanel filterLayout)
        {
            filterLayout.RowCount = 0;
            filterLayout.Controls.Clear();
            foreach (var field in _fields)
            {
                field.DisplayFilter(filterLayout);
            }
        }

        public void DisplayColumns(DataGridView fieldsView)
        {
            fieldsView.Columns.Clear();
            foreach (var field in _fields)
            {
                field.AddDisplayingColumn(fieldsView);
            }
        }

        public void DisplayInputs(TableLayoutPanel inputLayout)
        {
            inputLayout.RowCount = 0;
            inputLayout.Controls.Clear();
            foreach (var field in _fields)
            {
                field.DisplayInput(inputLayout);
            }
        }
    }
}
