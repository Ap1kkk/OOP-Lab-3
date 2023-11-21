using Lab_3;
using Lab4.Main.Fields;
using Lab4.Main.Rules;
using Lab4.Main.Rules.FirmRules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main
{
    public class MainController
    {
        public event Action<List<Firm>> OnDataChanged;
        public event Action<List<IFieldBase>> OnFieldsChanged;

        private FirmPool _firmPool;
        private FirmView _firmView;

        private FilterSelector _filterSelector;

        public MainController()
        {
            _firmPool = FirmPool.Instance;
            _firmView = new FirmView();
            _filterSelector = new FilterSelector(_firmPool, _firmView);
        }

        public void DisplayAllData()
        {
            OnDataChanged?.Invoke(_firmPool.Firms);
        }
        public void ApplyFirmFilter(List<IFirmFilterRule> filterRules)
        {
            OnDataChanged?.Invoke(_filterSelector.SelectFirms(filterRules));
        }

        public void ApplyDisplayingFirmFields(List<IFieldBase> fields)
        {
            ClearFirmFields();
            foreach (IFieldBase field in fields)
            {
                AddFirmField(field);
            }
            OnFieldsChanged?.Invoke(fields);
        }
        private void ClearFirmFields()
        {
            _firmView.ClearFields();
        }
        private void AddFirmField(IFieldBase field)
        {
            _firmView.AddField(field);
        }
    }
}
