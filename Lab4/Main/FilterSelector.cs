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
        private FieldFilterView<NameRule> _nameRuleView = new FieldFilterView<NameRule>(FilterRuleType.String, "Name");

        private FirmPool _firmPool;

        public FilterSelector(FirmPool firmPool)
        {
            _firmPool = firmPool;
        }

        public void Display(TableLayoutPanel layoutPanel)
        {
            _nameRuleView.Display(layoutPanel);
        }

        public List<FirmView> GetSelectedFirms()
        {
            var firms = _firmPool.FirmViews;
            var selected = firms;

            NameRule nameRule = _nameRuleView.GetFilterRule();

            selected = selected.Where(current =>
            {
                bool result = true;
                result = nameRule == null ? result && true : result && nameRule.FirmRespond(current.NameField);
                return result;
            }).ToList();
            return selected;
        }
    }
}
