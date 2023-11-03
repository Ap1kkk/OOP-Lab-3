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

        private DataGridView _firmsTable;
        private BindingSource _firmsLayout;
        private DataGridView _subFirmsTable;
        private BindingSource _subFirmsLayout;
        private DataGridView _contactsTable;
        private BindingSource _contactsLayout;
        public MainController(BindingSource firmsLayout,
                            BindingSource subFirmsLayout,
                            BindingSource contactsLayout)
        {
            _firmsTable = firmsTable;
            _firmsLayout = firmsLayout;
            _subFirmsTable= subFirmsTable;
            _subFirmsLayout = subFirmsLayout;
            _contactsTable = contactsTable;
            _contactsLayout = contactsLayout;

            _firmPool = FirmPool.Instance;
            _firmView = new FirmView(_firmPool);
            _filterSelector = new FilterSelector(_firmPool, _firmView);
        }

        private void Test()
        {
            _firmsTable.Columns.Add("Name", nameof(FirmViewElement.Name));
            var col = _firmsTable.Columns["Name"];
            col.DataPropertyName = "Name";
        }

        public void ApplyFilter()
        {
            _firmsLayout.DataSource = _filterSelector.FilteredFirmElements;
            _subFirmsLayout.DataSource = Converter.ConvertFirmsToSubFirms(_filterSelector.SelectedFirms);
            _contactsLayout.DataSource = Converter.ConvertFirmsToContacts(_filterSelector.SelectedFirms);
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
        public void DisplayAllData()
        {
            _firmsLayout.DataSource = _firmPool.FirmViews.ConvertAll(new Converter<FirmView, FirmViewElement>(Converter.ConvertFirm));

        public void DisplayColumns(DataGridView gridView)
        {
            _firmView.DisplayColumns(gridView);
        }
        public void AddField(IFieldBase field)
        {
            _firmView.AddField(field);
        }

    }
}
