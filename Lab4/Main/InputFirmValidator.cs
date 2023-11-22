using Lab_3;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.InputFieldView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab4.Main
{
    public class InputFirmValidator
    {
        private StringInputFieldView _nameInput;
        private StringInputFieldView _countryInput;
        private StringInputFieldView _regionInput;
        private StringInputFieldView _townInput;
        private StringInputFieldView _streetInput;
        private StringInputFieldView _postIndexInput;
        private StringInputFieldView _emailInput;
        private StringInputFieldView _websiteUrlInput;
        private IntInputFieldView _contactsAmount;
        private DateInputFieldView _enterDateInput;

        private Contact _contact = new Contact(new ContactType("name", "note"), "description", "information", new DateTime(2000, 1, 1), new DateTime(2000, 2, 2));

        private const string _bossName = "bossName";
        private const string _officialBossName = "officialBossName";
        private const string _phoneNumber = "phoneNumber";

        private List<IInputFieldViewBase> _inputFields = new List<IInputFieldViewBase>();

        private InputFieldViewFactory _inputFactory;
        public InputFirmValidator(InputFieldViewFactory inputFactory)
        {
            _inputFactory = inputFactory;

            _inputFields.Add(_nameInput = _inputFactory.Create(FieldViewType.String, "Name") as StringInputFieldView);
            _inputFields.Add(_countryInput = _inputFactory.Create(FieldViewType.String, "Country") as StringInputFieldView);
            _inputFields.Add(_regionInput = _inputFactory.Create(FieldViewType.String, "Region") as StringInputFieldView);
            _inputFields.Add(_townInput = _inputFactory.Create(FieldViewType.String, "Town") as StringInputFieldView);
            _inputFields.Add(_streetInput = _inputFactory.Create(FieldViewType.String, "Street") as StringInputFieldView);
            _inputFields.Add(_postIndexInput = _inputFactory.Create(FieldViewType.String, "Post index") as StringInputFieldView);
            _inputFields.Add(_emailInput = _inputFactory.Create(FieldViewType.String, "email") as StringInputFieldView);
            _inputFields.Add(_websiteUrlInput = _inputFactory.Create(FieldViewType.String, "Website URL") as StringInputFieldView);
            _inputFields.Add(_contactsAmount = _inputFactory.Create(FieldViewType.Int, "Contacts amount") as IntInputFieldView);
            _inputFields.Add(_enterDateInput = _inputFactory.Create(FieldViewType.DateTime, "Enter date") as DateInputFieldView);
        }

        public void Display(TableLayoutPanel layoutPanel)
        {
            foreach (var input in _inputFields)
            {
                input.Display(layoutPanel);
            }
        }

        public bool Validate()
        {
            bool result = true;
            foreach (var input in _inputFields)
            {
                result = result && input.Validate();
            }
            return result;
        }
        public void Reset()
        {
            foreach (var input in _inputFields)
            {
                input.ResetMessage();
            }
        }
        public Firm CreateFirm()
        {
            string name = _nameInput.Value;
            string country = _countryInput.Value;
            string region = _regionInput.Value;
            string town = _townInput.Value;
            string street = _streetInput.Value;
            string postIndex = _postIndexInput.Value;
            string email = _emailInput.Value;
            string websiteUrl = _websiteUrlInput.Value;
            DateTime enterDate = _enterDateInput.Value;

            Firm firm = FirmFactory.Instance.Create(
            name, country, region, town, street, postIndex, 
            email, websiteUrl, enterDate, _bossName, _officialBossName, _phoneNumber);

            for (int i = 0; i < _contactsAmount.Value; i++)
            {
                firm.AddContact(_contact);
            }

            return firm;
        }
    }
}
