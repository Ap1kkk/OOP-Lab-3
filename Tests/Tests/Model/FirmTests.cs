using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class FirmTests
    {
        FirmFactory _firmFactory = FirmFactory.Instance;

        #region FieldsForContacts
        private Contact _contact_c_1 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Contact _contact_c_2 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Contact _contact_c_3 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        #endregion


        #region Contacts
        [TestMethod()]
        public void IsContactExistsTestFalse()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");
            bool isExists = firm.IsContactExists(_contact_c_1);
            Assert.IsFalse(isExists);
        }
        [TestMethod()]
        public void IsContactExistsTestMain()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

            firm.AddContact(_contact_c_2.Type, _contact_c_2.Description, _contact_c_2.Information, _contact_c_2.BeginDate, _contact_c_2.EndDate);
            bool isExists = firm.IsContactExists(_contact_c_2);
            Assert.IsTrue(isExists);
        }
        [TestMethod()]
        public void AddContactTestMain()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

            Contact addedContact = firm.AddContact(_contact_c_2.Type, _contact_c_2.Description, _contact_c_2.Information, _contact_c_2.BeginDate, _contact_c_2.EndDate);
            Assert.AreNotSame(_contact_c_2, addedContact);
            Assert.IsTrue(firm.IsContactExists(addedContact));
            Assert.IsNotNull(firm.GetContact(_contact_c_2));

            Assert.IsTrue(addedContact == _contact_c_2);
            
        }
        [TestMethod()]
        public void IsContactExistsTestNotMain()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");
            SubFirm subFirm = new SubFirm(new SubFirmType(false, ""), "", "", "", "", "");

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
                Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

                firm.GetField("test");
            }));
        }

        [TestMethod()]
        public void SetFieldTest()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");
            const string value = "value";
            firm.SetField(_firmFactory.FieldName1, value);
            string getValue = firm.GetField(_firmFactory.FieldName1);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void SetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>((Action)(() =>
            {
                Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");
                const string fieldName = "test";
                const string value = "value";
                firm.SetField(fieldName, value);
            }));
        }


        [TestMethod()]
        public void RenameFieldTest()
        {
            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

            const string newFieldName = "testNew";
            const string value = "value";
            firm.SetField(_firmFactory.FieldName1, value);

            firm.RenameField(_firmFactory.FieldName1, newFieldName);

            string getValue = firm.GetField(newFieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void RenameFieldTestOldNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

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
                Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");

                firm.RenameField(_firmFactory.FieldName1, _firmFactory.FieldName2);
            });
        }
        #endregion

        [TestMethod()]
        public void AddSubFirmTest()
        {
            SubFirm subFirm = new SubFirm(new SubFirmType(false, ""), "", "", "", "", "");

            Firm firm = _firmFactory.Create("", "", "", "", "", "", "", new DateTime(), "", "", "");
            SubFirm createdSubFirm = firm.AddSubFirm(subFirm.Type, subFirm.Name, subFirm.BossName, subFirm.OfficialBossName, subFirm.PhoneNumber, subFirm.Email);
            Assert.IsNotNull(createdSubFirm);
        }
    }
}
