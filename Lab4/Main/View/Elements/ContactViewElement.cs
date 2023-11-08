using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.View
{
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
}
