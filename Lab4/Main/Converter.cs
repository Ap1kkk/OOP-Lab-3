using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public static class Converter
    {
        public static FirmViewElement ConvertFirm(FirmView firmVIew)
        {
            return new FirmViewElement(firmVIew.RelatedFirm);
        }
        public static FirmViewElement ConvertFirm(Firm firm)
        {
            return new FirmViewElement(firm);
        }
        public static SubFirmViewElement ConvertSubFirm(SubFirm subFirm)
        {
            return new SubFirmViewElement(subFirm);
        }
        public static ContactViewElement ConvertContact(Contact contact)
        {
            return new ContactViewElement(contact);
        }
    }
}
