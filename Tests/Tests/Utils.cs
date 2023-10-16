using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Utils
    {
        private static FirmFactory _firmFactory = new FirmFactory();
        public static Firm DefaultFirm()
        {
            return _firmFactory.Create("country", "region", "town", "street", 
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");
        }
    }
}
