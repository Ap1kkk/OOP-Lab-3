using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab_3.Tests
{
    [TestClass()]
    public class FirmFactoryTests
    {
        private FirmFactory _firmFactory = new FirmFactory();
        [TestMethod()]
        public void CreateTest()
        {
            const string country = "country";
            const string region = "region";
            const string town = "town";
            const string street = "street";
            const string postIndex= "postIndex";
            const string email = "email";
            const string websiteUrl= "websiteUrl";
            DateTime enterDate = new DateTime(2004, 4, 7);
            const string bossName = "bossName";
            const string officialBossName = "officialBossName";
            const string phoneNumber = "phoneNumber";

            Firm createdFirm = _firmFactory.Create(country, region, town, street, postIndex, email, websiteUrl,
                enterDate, bossName, officialBossName, phoneNumber);


            Assert.IsTrue(createdFirm.Country == country);
            Assert.IsTrue(createdFirm.Region == region);
            Assert.IsTrue(createdFirm.Town == town);
            Assert.IsTrue(createdFirm.Street == street);
            Assert.IsTrue(createdFirm.PostIndex == postIndex);
            Assert.IsTrue(createdFirm.Email == email);
            Assert.IsTrue(createdFirm.WebsiteUrl == websiteUrl);
            Assert.IsTrue(createdFirm.EnterDate == enterDate);
            Assert.IsTrue(createdFirm.Main.BossName == bossName);
            Assert.IsTrue(createdFirm.Main.OfficialBossName == officialBossName);
            Assert.IsTrue(createdFirm.Main.PhoneNumber == phoneNumber);

            foreach (var userField in _firmFactory.UserFields)
            {
                string fieldValue = null;

                Assert.ThrowsException<ArgumentException>( () =>
                {
                    fieldValue = createdFirm.GetField(userField.Key);
                });
                Assert.IsNotNull(fieldValue);
            }

            Assert.IsNotNull(createdFirm.Main);
            Assert.IsTrue(createdFirm.Main.Type.IsMain);
        }
    }
}