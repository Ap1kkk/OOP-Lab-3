using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class FirmFactory
    {
        public static FirmFactory Instance { get; private set; } = null;

        private List<string> _userFields = new List<string>() { "field1", "field2", "field3", "field4", "field5", };
        private const string MainFirmName = "Main Firm";

        public FirmFactory()
        {
            if(Instance != null)
            {
                throw new InvalidOperationException("Only one instance of FirmFactory possible");
            }

            Instance = this;
        }

        public Firm Create(string country, string region,
            string town, string street, string postIndex, string email,
            string websiteUrl, DateTime enterDate,
            string bossName, string officialBossName, string phoneNumber)
        {
            Firm firm = new Firm(MainFirmName, country, region, town, street,
                postIndex, email, websiteUrl, enterDate, bossName,
                officialBossName, phoneNumber);

            FillUserFields(firm);
            return firm;
        }

        public void FillUserFields(Firm firm)
        {
            int userFieldsAmount = int.Parse(ConfigurationManager.AppSettings["userFieldsAmount"]);
            for (int i = 1; i <= userFieldsAmount; i++)
            {
                string fieldName = ConfigurationManager.AppSettings[$"userFieldName{i}"];
                if(fieldName == null)
                {
                    throw new InvalidOperationException($"User field 'userFieldName{i}' does not exists in config");
                }
                
                firm.AddField(fieldName);
            }
        }
    }
}
