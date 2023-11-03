using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.View
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
        public string UserField1 => _firm.UserFields[FirmFactory.FieldName1];
        public string UserField2 => _firm.UserFields[FirmFactory.FieldName2];
        public string UserField3 => _firm.UserFields[FirmFactory.FieldName3];
        public string UserField4 => _firm.UserFields[FirmFactory.FieldName4];
        public string UserField5 => _firm.UserFields[FirmFactory.FieldName5];

        private Firm _firm;
        public FirmViewElement(Firm relatedFirm)
        {
            _firm = relatedFirm;
        }
    }
}
