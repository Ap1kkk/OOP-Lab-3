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

        private Dictionary<Firm, FirmView> _firms = new Dictionary<Firm, FirmView>();
        public List<Firm> Firms => _firms.Keys.ToList();
        public List<FirmView> FirmViews => _firms.Values.ToList();

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
            _firms.Add(firm, new FirmView(firm));
        }

        private void Add(Firm firm, FirmView firmView) 
        { 
            _firms.Add(firm, firmView);
        }
    }
}
