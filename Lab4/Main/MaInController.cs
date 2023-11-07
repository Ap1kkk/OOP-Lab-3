using Lab_3;
using Lab4.Main.Fields;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public class MainController
    {
        private FirmPool _firmPool;
        private FirmView _firmView;
        private FilterSelector _filterSelector;

        private BindingSource _firmsLayout;
        private BindingSource _subFirmsLayout;
        private BindingSource _contactsLayout;

        public MainController(BindingSource firmsLayout,
                            BindingSource subFirmsLayout,
                            BindingSource contactsLayout)
        {
            _firmsLayout = firmsLayout;
            _subFirmsLayout = subFirmsLayout;
            _contactsLayout = contactsLayout;

            _firmPool = FirmPool.Instance;
            _firmView = new FirmView(_firmPool);
            _filterSelector = new FilterSelector(_firmPool, _firmView);
        }
        public void ApplyFilter()
        {
            _firmsLayout.DataSource = _filterSelector.FilteredFirmElements;
            _subFirmsLayout.DataSource = Converter.ConvertFirmsToSubFirms(_filterSelector.SelectedFirms);
            _contactsLayout.DataSource = Converter.ConvertFirmsToContacts(_filterSelector.SelectedFirms);
        }

        public void ApplyDisplayingFields(List<IFieldBase> fields)
        {
            ClearFields();
            foreach (IFieldBase field in fields)
            {
                AddField(field);
            }
        }

        public void DisplayAllData()
        {
            _firmsLayout.DataSource = Converter.ConvertFirms(_firmPool.Firms);
            _subFirmsLayout.DataSource = Converter.ConvertFirmsToSubFirms(_firmPool.Firms);
            _contactsLayout.DataSource = Converter.ConvertFirmsToContacts(_firmPool.Firms);
        }

        public void DisplayFilters(TableLayoutPanel layoutPanel)
        {
            _firmView.DisplayFilters(layoutPanel);
        }
        public void DisplayColumns(DataGridView gridView)
        {
            _firmView.DisplayColumns(gridView);
        }
        private void ClearFields()
        {
            _firmView.ClearFields();
        }
        private void AddField(IFieldBase field)
        {
            _firmView.AddField(field);
        }
    }
}
