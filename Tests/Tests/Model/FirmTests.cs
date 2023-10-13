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
        #region FieldsForContacts
        private Firm _firm_c_1 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Contact _contact_c_1 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Firm _firm_c_2 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Contact _contact_c_2 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        private Firm _firm_c_3 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private SubFirm _subFirm_c_3 = new SubFirm(new SubFirmType(false, ""), "", "", "", "", "");
        private Contact _contact_c_3 = new Contact(new ContactType("", ""), "", "", new DateTime(), new DateTime());
        #endregion

        #region FieldsForFields
        private Firm _firm_f_1 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_f_2 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_f_3 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_f_4 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_f_5 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_f_6 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        #endregion

        #region Contacts
        [TestMethod()]
        public void IsContactExistsTestFalse()
        {
            bool isExists = _firm_c_1.IsContactExists(_contact_c_1);
            Assert.IsFalse(isExists);
        }
        [TestMethod()]
        public void IsContactExistsTestMain()
        {
            _firm_c_2.AddContact(_contact_c_2.Type, _contact_c_2.Description, _contact_c_2.Information, _contact_c_2.BeginDate, _contact_c_2.EndDate);
            bool isExists = _firm_c_2.IsContactExists(_contact_c_2);
            Assert.IsTrue(isExists);
        }
        [TestMethod()]
        public void IsContactExistsTestNotMain()
        {
            _firm_c_3.AddSubFirm(_subFirm_c_3.Type, _subFirm_c_3.Name, _subFirm_c_3.BossName, _subFirm_c_3.OfficialBossName, _subFirm_c_3.PhoneNumber, _subFirm_c_3.Email);
            _firm_c_3.AddContactToSubFirm(_subFirm_c_3.Type, _contact_c_3.Type, _contact_c_3.Description, _contact_c_3.Information, _contact_c_3.BeginDate, _contact_c_3.EndDate);

            bool isExists = _firm_c_3.IsContactExists(_contact_c_3);
            Assert.IsTrue(isExists);
        }
        #endregion

        #region Fields
        [TestMethod()]
        public void GetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _firm_f_1.GetField("test");
            });
        }
        [TestMethod()]
        public void GetFieldTestAdd()
        {
            const string fieldName = "test";
            _firm_f_2.AddField(fieldName);
            string value = _firm_f_2.GetField(fieldName);
            Assert.AreEqual("", "");
        }


        [TestMethod()]
        public void SetFieldTest()
        {
            const string fieldName = "test";
            const string value = "value";
            _firm_f_3.AddField(fieldName);
            _firm_f_3.SetField(fieldName, value);
            string getValue = _firm_f_3.GetField(fieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void SetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string fieldName = "test";
                const string value = "value";
                _firm_f_3.SetField(fieldName, value);
            });
        }


        [TestMethod()]
        public void RenameFieldTest()
        {
            const string oldFieldName = "test";
            const string newFieldName = "testNew";
            const string value = "value";
            _firm_f_4.AddField(oldFieldName);
            _firm_f_4.SetField(oldFieldName, value);

            _firm_f_4.RenameField(oldFieldName, newFieldName);

            string getValue = _firm_f_4.GetField(newFieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void RenameFieldTestOldNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string oldFieldName = "test";
                const string newFieldName = "testNew";

                _firm_f_5.RenameField(oldFieldName, newFieldName);
            });
        }
        [TestMethod()]
        public void RenameFieldTestNewNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string oldFieldName = "test";
                const string newFieldName = "testNew";

                _firm_f_6.AddField(oldFieldName);
                _firm_f_6.AddField(newFieldName);

                _firm_f_6.RenameField(oldFieldName, newFieldName);
            });
        }
        #endregion
    }
}
