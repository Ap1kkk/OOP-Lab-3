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

    public struct ContactViewElement
    {
        public string Name => contact.Type.Name;
        public string Note => contact.Type.Note;
        public string Description => contact.Description;
        public string Information => contact.Information;
        public DateTime BeginDate => contact.BeginDate;
        public DateTime EndDate => contact.EndDate;

        private Contact contact;
        public ContactViewElement(Contact relatedContact)
        {
            contact = relatedContact;
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

        public FirmViewElement DisplayElement => new FirmViewElement(RelatedFirm);
        public List<SubFirmViewElement> DisplaySubFirmsElements =>
            new List<SubFirmViewElement>(RelatedFirm.SubFirms.ConvertAll(new Converter<SubFirm, SubFirmViewElement>(Converter.ConvertSubFirm)))
            { Converter.ConvertSubFirm(RelatedFirm.Main)};
        public List<ContactViewElement> DisplayContactsElements =>
            new List<ContactViewElement>(GetAllContacts().ConvertAll(new Converter<Contact, ContactViewElement>(Converter.ConvertContact)));

        public Firm RelatedFirm { get; private set; }

        private Dictionary<Type, List<object>> _fields = new Dictionary<Type, List<object>>();

        public void AddField<T>(Field<T> fieldToAdd) where T : IComparable
        {
            Type type = typeof(T);
            if(_fields.ContainsKey(type))
            {
                _fields[type].Add(fieldToAdd);
                return;
            }
            

            _fields.Add(typeof(T), new List<object> { fieldToAdd });
        }

        private List<Contact> GetAllContacts()
        {
            List<Contact> result = new List<Contact>();
            result.AddRange(RelatedFirm.Main.Contacts);
            foreach (var subFirm in RelatedFirm.SubFirms)
            {
                result.AddRange(subFirm.Contacts);
            }
            return result;
        }


        public FirmView(Firm relatedFirm)
        {
            RelatedFirm = relatedFirm;

            NameField = new NameField(RelatedFirm);
            CountryField = new CountryField(RelatedFirm);
            RegionField = new RegionField(RelatedFirm);
            TownField = new TownField(RelatedFirm);
            StreetField = new StreetField(RelatedFirm);
            PostIndexField = new PostIndexField(RelatedFirm);
            WebsiteUrlField = new WebsiteUrlField(RelatedFirm);
            EnterDateField = new EnterDateField(RelatedFirm);
            ContactsAmountField = new ContactsAmountField(RelatedFirm);

            foreach (var userFieldName in RelatedFirm.UserFields.Keys)
            {
                UserFields.Add(userFieldName, new UserField(relatedFirm, userFieldName));
            }
        }

    }
}
