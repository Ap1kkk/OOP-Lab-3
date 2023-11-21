using Lab_3;
using Lab4.Main.Fields;
using Lab4.Main.View;
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
        public static FirmViewElement ConvertFirm(Firm firm)
        {
            return new FirmViewElement(firm);
        }
        public static List<FirmViewElement> ConvertFirms(List<Firm> firms)
        {
            return firms.ConvertAll(new Converter<Firm, FirmViewElement>(ConvertFirm));
        }
        public static SubFirmViewElement ConvertSubFirm(SubFirm subFirm)
        {
            return new SubFirmViewElement(subFirm);
        }
        public static List<SubFirmViewElement> ConvertSubFirms(List<SubFirm> subFirms)
        {
            return subFirms.ConvertAll(new Converter<SubFirm, SubFirmViewElement>(ConvertSubFirm));
        }
        public static ContactViewElement ConvertContact(Contact contact)
        {
            return new ContactViewElement(contact);
        }
        public static List<ContactViewElement> ConvertContacts(List<Contact> contacts)
        {
            return contacts.ConvertAll(new Converter<Contact, ContactViewElement>(ConvertContact));
        }
        public static List<SubFirmViewElement> ConvertFirmsToSubFirms(List<Firm> firms)
        {
            List<SubFirmViewElement> converted = new List<SubFirmViewElement>();
            foreach (var firm in firms)
            {
                converted.Add(ConvertSubFirm(firm.Main));
                converted.AddRange(ConvertSubFirms(firm.SubFirms));
            }
            return converted;
        }
        public static List<ContactViewElement> ConvertFirmsToContacts(List<Firm> firms) 
        {
            List<ContactViewElement> converted = new List<ContactViewElement>();
            foreach (var firm in firms)
            {
                converted.AddRange(ConvertContacts(firm.Contacts));
            }
            return converted;
        }
        public static List<string> ConvertFields(List<IFieldBase> fields) 
        {
            return fields.ConvertAll(new Converter<IFieldBase, string>(ConvertField));
        }
        public static string ConvertField(IFieldBase field)
        {
            return field.Name;
        }
    }
}
