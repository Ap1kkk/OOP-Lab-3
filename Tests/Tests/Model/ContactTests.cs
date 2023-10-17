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
    public class ContactTests
    {
        [TestMethod()]
        public void ContactTest()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Contact contact = new Contact(new ContactType("name", "note"), "description", "information", new DateTime(2000, 2, 2), new DateTime(1900, 2, 2));
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Contact contact = new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1900, 2, 2), new DateTime(2000, 2, 2));
                contact.EndDate = new DateTime(1800, 2, 2);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Contact contact = new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1900, 2, 2), new DateTime(2000, 2, 2));
                contact.BeginDate = new DateTime(2200, 2, 2);
            });
        }
    }
}