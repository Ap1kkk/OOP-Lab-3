using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Lab_3;

namespace UnitTests
{
    [TestClass]
    public class ContactTests
    {
        [TestMethod]
        public void TestEquals()
        {
            ContactType type1 = new ContactType("Contact 1", "Test");
            ContactType type2 = new ContactType("Contact 2", "Test");

            Contact contact1 = new Contact(type1, "Test", "Test", new DateTime(), new DateTime());
            Contact contact2 = new Contact(type1, "Test", "Test", new DateTime(), new DateTime());
        
            bool testEquals = contact1 == contact2;
            bool expected = true;

            Assert.AreEqual(expected, testEquals);
        }
    }
}
