using Lab_3;
using Lab4.Main.Rules;
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
        public List<FirmView> FilteredFirmViews => GetSelectedFirmViews();
        public List<FirmViewElement> FilteredFirms => GetSelectedFirmViews().ConvertAll(new Converter<FirmView, FirmViewElement>(Converter.ConvertFirm));

        private FieldFilterView<NameRule> _nameRuleView = new FieldFilterView<NameRule>(FilterRuleType.String, "Name");
        private FieldFilterView<EnterDateRule> _enterDateRuleView = new FieldFilterView<EnterDateRule>(FilterRuleType.DateTime, "Date enter");

        private FirmPool _firmPool;
        private List<FirmView> _filteredFirmViews = new List<FirmView>();

        public FilterSelector(FirmPool firmPool)
        {
            _firmPool = firmPool;
        }

        public void Display(TableLayoutPanel layoutPanel)
        {
            _nameRuleView.Display(layoutPanel);
            _enterDateRuleView.Display(layoutPanel);
        }

        public List<FirmView> GetSelectedFirmViews()
        {
            var firms = _firmPool.FirmViews;
            _filteredFirmViews = firms;

            NameRule nameRule = _nameRuleView.GetFilterRule();

            _filteredFirmViews = _filteredFirmViews.Where(current =>
            {
                bool result = true;
                result = nameRule == null ? result && true : result && nameRule.FirmRespond(current.NameField);
                return result;
            }).ToList();
            return _filteredFirmViews;
        }
    }
}
