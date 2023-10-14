using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3
{
    public class ContactTypeCollection
    {
        public int Count => _contactTypes.Count;
        private List<ContactType> _contactTypes = new List<ContactType>();

        public ContactTypeCollection()
        {
        }

        public ContactType Add(string name, string note)
        {
            ContactType temp = new ContactType(name, note);
            ContactType type = FirstOrDefault(temp);

            if(type == null)
            {
                type = temp;
                _contactTypes.Add(type);
            }
            return type;
        }
        public ContactType Add(ContactType type)
        {
            return Add(type.Name, type.Note);
        }

        public void Clear()
        {
            _contactTypes.Clear();
        }

        private ContactType FirstOrDefault(ContactType type)
        {
            return _contactTypes
                .FirstOrDefault(current => current.Name == type.Name && current.Note == type.Note);
        }
    }
}
