using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SubFirm
    {
        public string Name { get; private set; }
        public string BossName { get; private set; }
        public string OfficialBossName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public SubFirmType Type { get; private set; }
        public int CountContacts => _contacts.Count;

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
            Contact addedContact = contact;
            if (!IsContactExists(contact))
            {
                addedContact = contact.Clone();
                _contacts.Add(addedContact);
            }
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
