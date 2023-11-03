using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main
{
    public class FirmPool
    {
        public static FirmPool Instance { get; private set; } = null;

        public List<Firm> Firms => _firms;
        private List<Firm> _firms = new List<Firm>();

        public FirmPool()
        {
            if(Instance != null)
            {
                throw new InvalidOperationException("Only single instance possible");
            }
            Instance = this;
            FirmFactory.Instance.OnFirmCreated += OnFirmCreated;
        }

        private void OnFirmCreated(Firm firm)
        {
            _firms.Add(firm);
        }

        private List<SubFirm> GetAllSubFirms()
        {
            List<SubFirm> result = new List<SubFirm>();
            foreach (var firm in Firms)
            {
                result.Add(firm.Main);
                result.AddRange(firm.SubFirms);
            }
            return result;
        }

        private List<Contact> GetAllContacts()
        {
            List<Contact> result = new List<Contact>();
            foreach (var firm in Firms)
            {
                result.AddRange(firm.Main.Contacts);
                foreach (var subFirm in firm.SubFirms)
                {
                    result.AddRange(subFirm.Contacts);
                }
            }
            return result;
        }
    }
}
