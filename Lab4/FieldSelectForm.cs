using Lab_3;
using Lab4.Main;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FieldSelectForm : Form
    {
        private MainController _mainController;

        private NameField _nameField = new NameField();
        private CountryField _countryField = new CountryField();
        private RegionField _regionField = new RegionField();
        private TownField _townField = new TownField();
        private StreetField _streetField = new StreetField();
        private PostIndexField _postIndexField = new PostIndexField();
        private WebsiteUrlField _websiteField = new WebsiteUrlField();
        private EnterDateField _enterDateField = new EnterDateField();
        private ContactsAmountField _contactsAmountField = new ContactsAmountField();
        private UserField _userField1 = new UserField(FirmFactory.FieldName1);
        private UserField _userField2 = new UserField(FirmFactory.FieldName2);
        private UserField _userField3 = new UserField(FirmFactory.FieldName3);
        private UserField _userField4 = new UserField(FirmFactory.FieldName4);
        private UserField _userField5 = new UserField(FirmFactory.FieldName5);

        private List<IFieldBase> _fields = new List<IFieldBase>();
        private List<FieldCheckBox> _checkBoxes = new List<FieldCheckBox>();

        public FieldSelectForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;

            _fields.Add(_nameField);
            _fields.Add(_countryField);
            _fields.Add(_regionField);
            _fields.Add(_streetField);
            _fields.Add(_townField);
            _fields.Add(_postIndexField);
            _fields.Add(_websiteField);
            _fields.Add(_enterDateField);
            _fields.Add(_contactsAmountField);
            _fields.Add(_userField1);
            _fields.Add(_userField2);
            _fields.Add(_userField3);
            _fields.Add(_userField4);
            _fields.Add(_userField5);

            foreach (var field in _fields)
            {
                var fieldCheckBox = new FieldCheckBox(field.Name, field);
                fieldCheckBox.CheckChanged += FieldCheckBox_CheckChanged;
                FieldSelectPanel.Controls.Add(fieldCheckBox.CheckBox);
                _checkBoxes.Add(fieldCheckBox);
            }

            _fields.Clear();
        }
        ~FieldSelectForm()
        {
            foreach (var item in _checkBoxes)
            {
                item.CheckChanged -= FieldCheckBox_CheckChanged;
            }
        }

        private void FieldCheckBox_CheckChanged(bool isChecked, IFieldBase field)
        {
            if(isChecked)
            {
                _fields.Add(field);
            }
            else
            {
                _fields.Remove(field);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _mainController.ApplyDisplayingFields(_fields);
        }

    }
}
