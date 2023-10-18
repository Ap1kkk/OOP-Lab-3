using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Lab_3.Tests
{
    [TestClass()]
    public class FirmTests
    {
        #region FieldsForContacts
        private Contact _contact_c_1 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Contact _contact_c_2 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Contact _contact_c_3 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        #endregion


        #region Contacts
        [TestMethod()]
        public void IsContactExistsTestFalse()
        {
            Firm firm = Utils.DefaultFirm();
            bool isExists = firm.IsContactExists(_contact_c_1);
            Assert.IsFalse(isExists);
        }
        [TestMethod()]
        public void IsContactExistsTestMain()
        {
            Firm firm = Utils.DefaultFirm();

            firm.AddContact(_contact_c_2.Type, _contact_c_2.Description, _contact_c_2.Information, _contact_c_2.BeginDate, _contact_c_2.EndDate);
            bool isExists = firm.IsContactExists(_contact_c_2);
            Assert.IsTrue(isExists);
        }
        [TestMethod()]
        public void AddContactTestMain()
        {
            Firm firm = Utils.DefaultFirm();

            Contact addedContact = firm.AddContact(_contact_c_2.Type, _contact_c_2.Description, _contact_c_2.Information, _contact_c_2.BeginDate, _contact_c_2.EndDate);
            Assert.AreNotSame(_contact_c_2, addedContact);
            Assert.IsTrue(firm.IsContactExists(addedContact));
            Assert.IsNotNull(firm.GetContact(_contact_c_2));

            Assert.IsTrue(addedContact == _contact_c_2);

        }
        [TestMethod()]
        public void IsContactExistsTestNotMain()
        {
            Firm firm = Utils.DefaultFirm();
            SubFirm subFirm = Utils.DefaultSubFirm();

            firm.AddSubFirm(subFirm.Type, subFirm.Name, subFirm.BossName, subFirm.OfficialBossName, subFirm.PhoneNumber, subFirm.Email);
            firm.AddContactToSubFirm(subFirm.Type, _contact_c_3.Type, _contact_c_3.Description, _contact_c_3.Information, _contact_c_3.BeginDate, _contact_c_3.EndDate);

            bool isExists = firm.IsContactExists(_contact_c_3);
            Assert.IsTrue(isExists);
        }
        #endregion

        #region Fields
        [TestMethod()]
        public void GetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>((Action)(() =>
            {
                Firm firm = Utils.DefaultFirm();

                firm.GetField("test");
            }));
        }

        [TestMethod()]
        public void SetFieldTest()
        {
            Firm firm = Utils.DefaultFirm();
            const string value = "value";
            firm.SetField(Utils.FirmFactory.FieldName1, value);
            string getValue = firm.GetField(Utils.FirmFactory.FieldName1);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void SetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>((Action)(() =>
            {
                Firm firm = Utils.DefaultFirm();
                const string fieldName = "test";
                const string value = "value";
                firm.SetField(fieldName, value);
            }));
        }


        [TestMethod()]
        public void RenameFieldTest()
        {
            Firm firm = Utils.DefaultFirm();

            const string newFieldName = "testNew";
            const string value = "value";
            firm.SetField(Utils.FirmFactory.FieldName1, value);

            firm.RenameField(Utils.FirmFactory.FieldName1, newFieldName);

            string getValue = firm.GetField(newFieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void RenameFieldTestOldNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Firm firm = Utils.DefaultFirm();

                const string oldFieldName = "test";
                const string newFieldName = "testNew";

                firm.RenameField(oldFieldName, newFieldName);
            });
        }
        [TestMethod()]
        public void RenameFieldTestNewNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Firm firm = Utils.DefaultFirm();

                firm.RenameField(Utils.FirmFactory.FieldName1, Utils.FirmFactory.FieldName2);
            });
        }
        #endregion

        [TestMethod()]
        public void AddSubFirmTest()
        {
            SubFirm subFirm = Utils.DefaultSubFirm();

            Firm firm = Utils.DefaultFirm();
            SubFirm createdSubFirm = firm.AddSubFirm(subFirm.Type, subFirm.Name, subFirm.BossName, subFirm.OfficialBossName, subFirm.PhoneNumber, subFirm.Email);
            Assert.IsNotNull(createdSubFirm);
        }
        [TestMethod()]
        public void AddContactTest()
        {
            Firm firm = Utils.DefaultFirm();
            Contact contact = Utils.DefaultContact();
            Contact addedContact = firm.AddContact(contact);
            Assert.IsNotNull(addedContact);
            Assert.AreNotSame(contact, addedContact);
            Assert.IsTrue(firm.Main.IsContactExists(contact));

        }

        [TestMethod()]
        public void AddContactToSubFirmTest()
        {
            Firm firm = Utils.DefaultFirm();
            SubFirm subFirm = Utils.DefaultSubFirm();
            Contact contact = Utils.DefaultContact();

            firm.AddSubFirm(subFirm.Type, subFirm.Name, subFirm.BossName, subFirm.OfficialBossName, subFirm.PhoneNumber, subFirm.Email);
            Contact addedContact = firm.AddContactToSubFirm(subFirm.Type, contact);
            Assert.IsNotNull(addedContact);
            Assert.AreNotSame(contact, addedContact);
            SubFirm addedSubFirm = firm.GetSubFirm(subFirm.Type);
            Assert.IsNotNull(addedSubFirm);
            Assert.IsTrue(addedSubFirm.IsContactExists(contact));
            Assert.IsNotNull(firm.GetSubFirmContact(subFirm.Type, contact));
        }
    }
}
