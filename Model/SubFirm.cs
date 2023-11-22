using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SubFirm
    {
        public SubFirmType Type { get; private set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _name = value;
            }
        }
        public string BossName
        {
            get
            {
                return _bossName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _bossName = value;
            }
        }
        public string OfficialBossName
        {
            get
            {
                return _officialBossName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _officialBossName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _email = value;
            }
        }
        public int ContactsAmount => _contacts.Count;

        private string _name;
        private string _bossName;
        private string _officialBossName;
        private string _phoneNumber;
        private string _email;

        public List<Contact> Contacts => _contacts;
        private List<Contact> _contacts = new List<Contact>();

        public SubFirm(SubFirmType subFirmType, string name, string bossName, 
            string officialBossName, string phoneNumber, string email)
        {
            Type = subFirmType;
            Name = name;
            BossName = bossName;
            OfficialBossName = officialBossName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact AddContact(ContactType contactType, string description, 
            string information, DateTime beginDate, DateTime endDate)
        {
            Contact contact = new Contact(contactType, description, information, beginDate, endDate);
            return AddContact(contact);
        }

        public Contact AddContact(Contact contact)
        {
            Contact addedContact = contact.Clone();
            _contacts.Add(addedContact);
            //if (!IsContactExists(contact))
            //{
            //    _contacts.Add(addedContact);
            //    addedContact = contact.Clone();
            //}
            return addedContact;
        }
        public Contact GetContact(Contact contact)
        {
            return _contacts.FirstOrDefault(current => current == contact);
        }

        public bool IsContactExists(Contact contact)
        { 
            return GetContact(contact) != null as object;
        }

        public bool IsEqualType(SubFirmType subFirmType)
        {
            return Type == subFirmType;
        }
    }
}
