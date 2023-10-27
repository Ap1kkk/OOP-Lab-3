using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class Utils
    {
        public static FirmFactory FirmFactory { get; } = new FirmFactory();
        public static Firm DefaultFirm()
        {
            return FirmFactory.Create("name", "country", "region", "town", "street", 
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");
        }
        public static SubFirm DefaultSubFirm()
        {
            return new SubFirm(new SubFirmType(false, "name"), "name", "bossName", "officialBossName", "phoneNumber", "email");
        }
        public static ContactType ContactType()
        {
            return new ContactType("name", "note");
        }
        public static Contact DefaultContact()
        {
            return new Contact(ContactType(), "description", "information", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2));
        }
    }
}
