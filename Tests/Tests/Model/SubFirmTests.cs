using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SubFirmTests
    {
        [TestMethod()]
        public void IsEqualTypeTest()
        {
            SubFirmType subFirmType1 = new SubFirmType(false, "type");
            SubFirmType subFirmType2 = new SubFirmType(false, "type");

            SubFirm subFirm = new SubFirm(subFirmType1, "", "", "", "", "");
            bool isSameType = subFirm.IsEqualType(subFirmType2);

            Assert.IsTrue(isSameType);
        }
    }
}
