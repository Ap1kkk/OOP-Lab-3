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

namespace Lab4.Main
{
    public struct FirmViewElement
    {
        public string Name => _firm.Name;
        public string Country => _firm.Country;
        public string Region => _firm.Region;
        public string Town => _firm.Town;
        public string Street => _firm.Street;
        public string PostIndex => _firm.PostIndex;
        public string Email => _firm.Email;
        public string WebsiteUrl => _firm.WebsiteUrl;
        public DateTime EnterDate => _firm.EnterDate;
        public int ContactsAmount => _firm.ContactsAmount;
        public string UserField1 => _firm.UserFields[FirmFactory.Instance.FieldName1];
        public string UserField2 => _firm.UserFields[FirmFactory.Instance.FieldName2];
        public string UserField3 => _firm.UserFields[FirmFactory.Instance.FieldName3];
        public string UserField4 => _firm.UserFields[FirmFactory.Instance.FieldName4];
        public string UserField5 => _firm.UserFields[FirmFactory.Instance.FieldName5];

        private Firm _firm;
        public FirmViewElement(Firm relatedFirm)
        {
            _firm = relatedFirm;
        }
    }

    public struct SubFirmViewElement
    {
        public string IsMain => _subFirm.Type.IsMain.ToString();
        public string Name => _subFirm.Name;
        public string BossName => _subFirm.BossName;
        public string OfficialBossName => _subFirm.OfficialBossName;
        public string PhoneNumber => _subFirm.PhoneNumber;
        public string Email => _subFirm.Email;
        public int ContactsAmount => _subFirm.ContactsAmount;

        private SubFirm _subFirm;
        public SubFirmViewElement(SubFirm relatedSubFirm)
        {
            _subFirm = relatedSubFirm;
        }
    }

    public class FirmView
    {
        public NameField NameField { get; private set; }
        public CountryField CountryField { get; private set; }
        public RegionField RegionField { get; private set; }
        public TownField TownField { get; private set; }
        public StreetField StreetField { get; private set; }
        public PostIndexField PostIndexField { get; private set; }
        public EnterDateField EnterDateField { get; private set; }
        public WebsiteUrlField WebsiteUrlField { get; private set; }
        public ContactsAmountField ContactsAmountField { get; private set; }
        public readonly Dictionary<string, UserField> UserFields = new Dictionary<string, UserField>();

        public FirmViewElement DisplayElement => new FirmViewElement(_relatedFirm);
        public SubFirmViewElement DisplayElementMain => new SubFirmViewElement(_relatedFirm.Main);
        public List<SubFirmViewElement> DisplaySubFirmsElements =>
            new List<SubFirmViewElement>(_relatedFirm.SubFirms.ConvertAll(new Converter<SubFirm, SubFirmViewElement>(ConvertSubFirm)))
            { ConvertSubFirm(_relatedFirm.Main)};

        public static SubFirmViewElement ConvertSubFirm(SubFirm subFirm)
        {
             return new SubFirmViewElement(subFirm);
        }

        private Firm _relatedFirm;

        public FirmView(Firm relatedFirm)
        {
            _relatedFirm = relatedFirm;

            NameField = new NameField(_relatedFirm);
            CountryField = new CountryField(_relatedFirm);
            RegionField = new RegionField(_relatedFirm);
            TownField = new TownField(_relatedFirm);
            StreetField = new StreetField(_relatedFirm);
            PostIndexField = new PostIndexField(_relatedFirm);
            WebsiteUrlField = new WebsiteUrlField(_relatedFirm);
            EnterDateField = new EnterDateField(_relatedFirm);
            ContactsAmountField = new ContactsAmountField(_relatedFirm);

            foreach (var userFieldName in _relatedFirm.UserFields.Keys)
            {
                UserFields.Add(userFieldName, new UserField(relatedFirm, userFieldName));
            }
        }

        public void DisplayFirm(TableLayoutPanel tableLayout)
        {
            tableLayout.RowCount += 1;

            tableLayout.Controls.Add(CreateTextBox(NameField.Value));
            tableLayout.Controls.Add(CreateTextBox(CountryField.Value));
            tableLayout.Controls.Add(CreateTextBox(RegionField.Value));
            tableLayout.Controls.Add(CreateTextBox(TownField.Value));
            tableLayout.Controls.Add(CreateTextBox(StreetField.Value));
            tableLayout.Controls.Add(CreateTextBox(PostIndexField.Value));
            tableLayout.Controls.Add(CreateTextBox(WebsiteUrlField.Value));
            tableLayout.Controls.Add(CreateTextBox(EnterDateField.Value.ToString()));
            tableLayout.Controls.Add(CreateUserFieldsView());
            tableLayout.Controls.Add(CreateTextBox(ContactsAmountField.Value.ToString()));

        }

        public void DisplaySubFirms(TableLayoutPanel tableLayout)
        {
            DisplaySubFirm(tableLayout, _relatedFirm.Main);
            foreach (var subFirm in _relatedFirm.SubFirms)
            {
                DisplaySubFirm(tableLayout, subFirm);
            }
        }
        private void DisplaySubFirm(TableLayoutPanel tableLayout, SubFirm subFirm)
        {
            tableLayout.RowCount += 1;
            tableLayout.Controls.Add(CreateTextBox(NameField.Value));
            tableLayout.Controls.Add(CreateTextBox(subFirm.Name));
            tableLayout.Controls.Add(CreateTextBox(subFirm.Type.IsMain.ToString()));
            tableLayout.Controls.Add(CreateTextBox(subFirm.BossName));
            tableLayout.Controls.Add(CreateTextBox(subFirm.OfficialBossName));
            tableLayout.Controls.Add(CreateTextBox(subFirm.PhoneNumber));
            tableLayout.Controls.Add(CreateTextBox(subFirm.Email));
            tableLayout.Controls.Add(CreateTextBox(subFirm.ContactsAmount.ToString()));

        }

        public void DisplayContacts(TableLayoutPanel tableLayout)
        {
            DisplayContact(tableLayout, _relatedFirm.Main);
        }
        private void DisplayContact(TableLayoutPanel tableLayout, SubFirm subFirm)
        {
            foreach (var contact in subFirm.Contacts)
            {
                tableLayout.RowCount += 1;
                tableLayout.Controls.Add(CreateTextBox(NameField.Value));
                tableLayout.Controls.Add(CreateTextBox(subFirm.Name));
                tableLayout.Controls.Add(CreateTextBox(contact.Type.Name));
                tableLayout.Controls.Add(CreateTextBox(contact.Type.Note));
                tableLayout.Controls.Add(CreateTextBox(contact.Description));
                tableLayout.Controls.Add(CreateTextBox(contact.Information));
                tableLayout.Controls.Add(CreateTextBox(contact.BeginDate.ToString()));
                tableLayout.Controls.Add(CreateTextBox(contact.EndDate.ToString()));
            }
        }


        private TextBox CreateTextBox(string textValue)
        {
            Font font = new Font("Microsoft Sans Serif", 14);
            return new TextBox() { Text = textValue, Dock = DockStyle.Fill, TextAlign = HorizontalAlignment.Center, Font = font};

        }
        private TableLayoutPanel CreateUserFieldsView()
        {
            TableLayoutPanel layoutPanel = new TableLayoutPanel() { Dock = DockStyle.Fill,  AutoScroll = true };
            layoutPanel.ColumnCount = 2;

            foreach (var field in UserFields)
            {
                layoutPanel.Controls.Add(CreateTextBox(field.Key));
                layoutPanel.Controls.Add(CreateTextBox(field.Value.Value));
            }
            return layoutPanel;
        }
    }
}
