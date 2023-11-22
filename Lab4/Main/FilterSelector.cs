using Lab_3;
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
    public class FilterSelector
    {
        public List<Firm> SelectedFirms => GetSelectedFirms();

        private List<Firm> _filteredFirms = new List<Firm>();
        private FirmPool _firmPool;
        private FirmView _firmView;

        public FilterSelector(FirmPool firmPool, FirmView firmView)
        {
            _firmPool = firmPool;
            _firmView = firmView;
        }

        public List<Firm> SelectFirms(List<IFirmFilterRule> filterRules)
        {
            _filteredFirms = _firmPool.Firms.Where(current =>
            {
                bool result = true;
                foreach (var rule in filterRules)
                {
                    if (rule.IsFilterActive)
                    {
                        result = result && rule.FirmRespond(current);
                    }
                }
                return result;
            }).ToList();
            return _filteredFirms;
        }

        private List<Firm> GetSelectedFirms()
        {
            var fields = _firmView.Fields;
            List<IFirmFilterRule> filterRules = new List<IFirmFilterRule>();
            foreach (var field in fields)
            {
                filterRules.Add(field.CreateRule() as IFirmFilterRule);
            }

            _filteredFirms = _firmPool.Firms.Where(current =>
            {
                bool result = true;
                foreach (var rule in filterRules)
                {
                    if(rule.IsFilterActive)
                    {
                        result = result && rule.FirmRespond(current);
                    }
                }
                return result;
            }).ToList();
            return _filteredFirms;
        }
    }
}
