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
        private Firm _firm_1 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_2 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_3 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_4 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_5 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");
        private Firm _firm_6 = new Firm("", "", "", "", "", "", "", "", new DateTime(), "", "", "");

        [TestMethod()]
        public void GetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _firm_1.GetField("test");
            });
        }
        [TestMethod()]
        public void GetFieldTestAdd()
        {
            const string fieldName = "test";
            _firm_2.AddField(fieldName);
            string value = _firm_2.GetField(fieldName);
            Assert.AreEqual("", "");
        }


        [TestMethod()]
        public void SetFieldTest()
        {
            const string fieldName = "test";
            const string value = "value";
            _firm_3.AddField(fieldName);
            _firm_3.SetField(fieldName, value);
            string getValue = _firm_3.GetField(fieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void SetFieldTestException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string fieldName = "test";
                const string value = "value";
                _firm_3.SetField(fieldName, value);
            });
        }


        [TestMethod()]
        public void RenameFieldTest()
        {
            const string oldFieldName = "test";
            const string newFieldName = "testNew";
            const string value = "value";
            _firm_4.AddField(oldFieldName);
            _firm_4.SetField(oldFieldName, value);

            _firm_4.RenameField(oldFieldName, newFieldName);

            string getValue = _firm_4.GetField(newFieldName);
            Assert.AreEqual(value, getValue);
        }
        [TestMethod()]
        public void RenameFieldTestOldNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string oldFieldName = "test";
                const string newFieldName = "testNew";

                _firm_5.RenameField(oldFieldName, newFieldName);
            });
        }
        [TestMethod()]
        public void RenameFieldTestNewNameException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                const string oldFieldName = "test";
                const string newFieldName = "testNew";

                _firm_6.AddField(oldFieldName);
                _firm_6.AddField(newFieldName);

                _firm_6.RenameField(oldFieldName, newFieldName);
            });
        }
    }
}
