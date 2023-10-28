using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab_3
{
    public class FirmFactory
    {
        public static FirmFactory Instance { get; private set; } = null;

        public event Action<Firm> OnFirmCreated;

        public readonly string FieldName1 = "field1";
        public readonly string FieldName2 = "field2";
        public readonly string FieldName3 = "field3";
        public readonly string FieldName4 = "field4";
        public readonly string FieldName5 = "field5";
        public readonly Dictionary<string, string> UserFields = new Dictionary<string, string>();
        private const string MainFirmName = "Main Firm";

        public FirmFactory()
        {
            if(Instance != null)
            {
                throw new InvalidOperationException("Only one instance of FirmFactory possible");
            }

            Instance = this;
            UserFields.Add(FieldName1, "");
            UserFields.Add(FieldName2, "");
            UserFields.Add(FieldName3, "");
            UserFields.Add(FieldName4, "");
            UserFields.Add(FieldName5, "");
        }
        public Firm Create()
        {
            return Create(MainFirmName, "country", "region", "town", "street",
                "postIndex", "email", "websiteUrl", new DateTime(2000, 4, 4), "bossName",
                "officialBossName", "phoneNumber");
        }
        public Firm Create(string name, string country, string region,
            string town, string street, string postIndex, string email,
            string websiteUrl, DateTime enterDate,
            string bossName, string officialBossName, string phoneNumber)
        {
            Firm firm = new Firm(name, country, region, town, street,
                postIndex, email, websiteUrl, enterDate, bossName,
                officialBossName, phoneNumber);

            FillUserFields(firm);
            OnFirmCreated?.Invoke(firm);
            return firm;
        }

        public void FillUserFields(Firm firm)
        {
            foreach (var pair in UserFields)
            {
                firm.AddField(pair.Key);
                firm.SetField(pair.Key, pair.Value);
            }
        }
    }
}
