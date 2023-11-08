using Lab_3;
using Lab4.Main.Rules;
using Lab4.Main.Rules.ContactRules;
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
        public List<Contact> SelectedContacts => GetSelectedContacts();

        private List<Firm> _filteredFirms = new List<Firm>();
        private List<Contact> _filteredContacts = new List<Contact>();

        private FirmPool _firmPool;

        private IView _firmView;
        private IView _contactView;

        public FilterSelector(FirmPool firmPool, IView firmView, IView contactView)
        {
            _firmPool = firmPool;
            _firmView = firmView;
            _contactView = contactView;
        }

        public List<Firm> GetSelectedFirms()
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

        public List<Contact> GetSelectedContacts()
        {
            var fields = _contactView.Fields;
            List<IContactFilterRule> filterRules = new List<IContactFilterRule>();
            foreach (var field in fields)
            {
                filterRules.Add(field.CreateRule() as IContactFilterRule);
            }

            //TODO можно немного оптимизировать

            _filteredContacts = _firmPool.Contacts.Where(current =>
            {
                bool result = true;
                foreach (var rule in filterRules)
                {
                    if (rule.IsFilterActive)
                    {
                        result = result && rule.ContactRespond(current);
                    }
                }
                return result;
            }).ToList();
            return _filteredContacts;
        }
    }
}
