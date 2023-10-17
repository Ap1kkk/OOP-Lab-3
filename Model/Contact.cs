using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Contact
    {
        public ContactType Type { get; }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if(value == null)
                    throw new ArgumentNullException("value");
                _description = value;
            }
        }
        public string Information
        {
            get
            {
                return _information;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _information = value;
            }
        }
        public DateTime BeginDate
        {
            get
            {
                return _beginDate;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                if (value > EndDate)
                    throw new ArgumentException("Begin date cannot be greater than End date");
                _beginDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                if (value < BeginDate)
                    throw new ArgumentException("End date cannot be less than Begin date");
                _endDate = value;
            }
        }

        private string _description = null;
        private string _information = null;
        private DateTime _beginDate = DateTime.MinValue;
        private DateTime _endDate = DateTime.MaxValue;

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
