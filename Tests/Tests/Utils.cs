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
            return FirmFactory.Create("country", "region", "town", "street", 
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");
        }
        public static SubFirm DefaultSubFirm()
        {
            return new SubFirm(new SubFirmType(false, "name"), "name", "bossName", "officialBossName", "phoneNumber", "email");
        }
    }
}
