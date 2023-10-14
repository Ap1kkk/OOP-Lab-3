using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Firm
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }
        public string Town { get; private set; }
        public string Street { get; private set; }
        public string PostIndex { get; private set; }
        public string Email { get; private set; }
        public string WebsiteUrl { get; private set; }
        public DateTime EnterDate { get; private set; }

        public SubFirm Main { get; private set; }

        private List<SubFirm> _subFirms = new List<SubFirm>();
        private readonly Dictionary<string, string> _userFields = new Dictionary<string, string>();

        public Firm(string name, string country, string region,
            string town, string street, string postIndex, string email,
            string websiteUrl, DateTime enterDate,
            string bossName, string officialBossName, string phoneNumber)
        {
            Name = name;
            Country = country;
            Region = region;
            Town = town;
            Street = street;
            PostIndex = postIndex;
            Email = email;
            WebsiteUrl = websiteUrl;
            EnterDate = enterDate;

            Main = new SubFirm(new SubFirmType(true, name), name, bossName, officialBossName, phoneNumber, email);
        }

        public Contact AddContact(ContactType contactType, string description,
            string information, DateTime beginDate, DateTime endDate)
        {
            return Main.AddContact(contactType, description, information, beginDate, endDate);
        }
        public Contact AddContact(Contact contact)
        {
            return Main.AddContact(contact);
        }
        public Contact AddContactToSubFirm(SubFirmType subFirmType, ContactType contactType, string description,
            string information, DateTime beginDate, DateTime endDate)
        {
            Contact contact = new Contact(contactType, description, information, beginDate, endDate);
            return AddContactToSubFirm(subFirmType, contact);
        }
        public Contact AddContactToSubFirm(SubFirmType subFirmType, Contact contact)
        {
            SubFirm subFirm = _subFirms.FirstOrDefault(current => current.Type == subFirmType);
            if (subFirm == null)
            {
                throw new ArgumentException("Sub firm with given type does't exists");
            }
            return subFirm.AddContact(contact);
        }
        public Contact GetContact(Contact contact)
        {
            return Main.GetContact(contact);
        }
        public Contact GetSubFirmContact(SubFirmType subFirmType, Contact contact)
        {
            SubFirm subFirm = _subFirms.FirstOrDefault(current => current.Type == subFirmType);
            if (subFirm == null)
            {
                throw new ArgumentException("Sub firm with given type does't exists");
            }
            return subFirm.GetContact(contact);
        }
        public bool IsContactExists(Contact contact)
        {
            SubFirm subFirm = _subFirms.FirstOrDefault(current => current.IsContactExists(contact));

            return Main.IsContactExists(contact) || subFirm != null;
        }

        public SubFirm AddSubFirm(SubFirmType subFirmType, string name, string bossName,
            string officialBossName, string phoneNumber, string email)
        {
            SubFirm subFirm = _subFirms.FirstOrDefault(current => current.IsEqualType(subFirmType));
            if (subFirm != null)
            {
                return subFirm;
            }
            subFirm = new SubFirm(subFirmType, name, bossName, officialBossName, phoneNumber, email);
            _subFirms.Add(subFirm);
            return subFirm;
        }

        public void AddField(string fieldName)
        {
            if(_userFields.ContainsKey(fieldName))
            {
                Console.WriteLine($"Field {fieldName} already exists!");
                return;
            }

            _userFields.Add(fieldName, "");
        }

        public string GetField(string fieldName)
        {
            if (!_userFields.ContainsKey(fieldName))
            {
                throw new ArgumentException($"Field {fieldName} does not exist!");
            }
            return _userFields[fieldName];
        }

        public void SetField(string fieldName, string value)
        {
            if (!_userFields.ContainsKey(fieldName))
            {
                throw new ArgumentException($"Field {fieldName} does not exist!");
            }

            _userFields[fieldName] = value;
        }

        public void RenameField(string oldFieldName, string newFieldName)
        {
            if (!_userFields.ContainsKey(oldFieldName))
            {
                throw new ArgumentException($"Field {oldFieldName} does not exist!");
            }
            if (_userFields.ContainsKey(newFieldName))
            {
                throw new ArgumentException($"Field {newFieldName} already exists exists!");
            }

            string value = _userFields[oldFieldName];
            _userFields.Remove(oldFieldName);
            _userFields.Add(newFieldName, value);
        }
    }
}
