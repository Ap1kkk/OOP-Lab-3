using Lab_3;
using Lab4.Main.Fields;
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
        private FilterSelector _filterSelector;

        private DataGridView _firmsTable;
        private BindingSource _firmsLayout;
        private DataGridView _subFirmsTable;
        private BindingSource _subFirmsLayout;
        private DataGridView _contactsTable;
        private BindingSource _contactsLayout;
        public MainController(DataGridView firmsTable, BindingSource firmsLayout,
                            DataGridView subFirmsTable, BindingSource subFirmsLayout,
                            DataGridView contactsTable, BindingSource contactsLayout)
        {
            _firmsTable = firmsTable;
            _firmsLayout = firmsLayout;
            _subFirmsTable= subFirmsTable;
            _subFirmsLayout = subFirmsLayout;
            _contactsTable = contactsTable;
            _contactsLayout = contactsLayout;

            _firmPool = FirmPool.Instance;
            _filterSelector = new FilterSelector(_firmPool);

            Test();
        }

        private void Test()
        {
            _firmsTable.Columns.Add("Name", nameof(FirmViewElement.Name));
            var col = _firmsTable.Columns["Name"];
            col.DataPropertyName = "Name";
        }

        public void ApplyFilter()
        {
            var selectedFirms = _filterSelector.FilteredFirms;
            _firmsLayout.DataSource = selectedFirms;
            List<SubFirmViewElement> filteredSubFirms = new List<SubFirmViewElement>();
            foreach (var firmView in _filterSelector.FilteredFirmViews)
            {
                filteredSubFirms.AddRange(firmView.DisplaySubFirmsElements);
            }
            _subFirmsLayout.DataSource = filteredSubFirms;
            List<ContactViewElement> filteredContacts = new List<ContactViewElement>();
            foreach (var firmView in _filterSelector.FilteredFirmViews)
            {
                filteredContacts.AddRange(firmView.DisplayContactsElements);
            }
            _contactsLayout.DataSource = filteredContacts;
        }
        public void DisplayAllData()
        {
            _firmsLayout.DataSource = _firmPool.FirmViews.ConvertAll(new Converter<FirmView, FirmViewElement>(Converter.ConvertFirm));

            List<SubFirm> subFirms = _firmPool.SubFirms;
            List<SubFirmViewElement> subFirmViews = subFirms.ConvertAll(new Converter<SubFirm, SubFirmViewElement>(Converter.ConvertSubFirm));
            _subFirmsLayout.DataSource = subFirmViews;

            List<Contact> contacts = _firmPool.Contacts;
            List<ContactViewElement> contactViews = contacts.ConvertAll(new Converter<Contact, ContactViewElement>(Converter.ConvertContact));
            _contactsLayout.DataSource = contactViews;
        }

        public void DisplayFilters(TableLayoutPanel layoutPanel)
        {
            _filterSelector.Display(layoutPanel);
        }

    }
}
