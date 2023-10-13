using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class ContactType
    {
        public string Name { get; private set; }
        public string Note { get; private set; }

        public ContactType(string name, string note)
        {
            Name = name;
            Note = note;
        }
    }
}
