using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ContactTypeCollectionTests
    {
        [TestMethod()]
        public void ExistsTest()
        {
            ContactTypeCollection collection = new ContactTypeCollection();
            ContactType type1 = new ContactType("test", "test");
            ContactType type2 = new ContactType("test", "test");

        }
    }
}
