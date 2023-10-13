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
        private static ContactTypeCollection _instance = null;
        private List<ContactType> _contactTypes = new List<ContactType>();

        public ContactTypeCollection()
        {
            if( _instance == null )
            {
                _instance = this;
            }
        }

        public static ContactType Get(string name, string note)
        {
            ContactType temp = new ContactType(name, note);
            ContactType type = FirstOrDefault(temp);

            if(type == null)
            {
                type = temp;
                _instance._contactTypes.Add(type);
            }
            return type;
        }
        public static ContactType Get(ContactType type)
        {
            return Get(type.Name, type.Note);
        }

        public static void Clear()
        {
            _instance._contactTypes.Clear();
        }

        private static ContactType FirstOrDefault(ContactType type)
        {
            return _instance._contactTypes
                .FirstOrDefault(current => current.Name == type.Name && current.Note == type.Note);
        }
    }
}
