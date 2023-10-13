using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Contact
    {
        public ContactType Type { get; private set; }
        public string Description { get; private set; }
        public string Information { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Contact(ContactType contactType, string description, 
            string information, DateTime beginDate, DateTime endDate)
        {
            Type = contactType;
            Description = description;
            Information = information;
            BeginDate = beginDate;
            EndDate = endDate;
        }

        public Contact Clone()
        {
            return new Contact(Type, Description, Information, BeginDate, EndDate);
        }

        public override bool Equals(object obj)
        {
            return this == obj as Contact;
        }

        public static bool operator == (Contact left, Contact right)
        {
            return
                left.Type == right.Type
                && left.Description == right.Description
                && left.Information == right.Information
                && left.BeginDate == right.BeginDate
                && left.EndDate == right.EndDate;
        }
        public static bool operator != (Contact left, Contact right)
        {
            return !(left == right);
        }
    }
}
