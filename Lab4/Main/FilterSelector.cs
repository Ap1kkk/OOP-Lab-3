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
        private FieldFilterView<ContactsAmountRule> _contactsAmountRuleView = new FieldFilterView<ContactsAmountRule>(FilterRuleType.Int, "Contacts amount");
        private FieldFilterView<CountryRule> _countryRuleView = new FieldFilterView<CountryRule>(FilterRuleType.String, "Country");
        private FieldFilterView<PostIndexRule> _postIndexRuleView = new FieldFilterView<PostIndexRule>(FilterRuleType.String, "Post index");
        private FieldFilterView<StreetRule> _streetRuleView = new FieldFilterView<StreetRule>(FilterRuleType.String, "Street");
        private FieldFilterView<RegionRule> _regionRuleView = new FieldFilterView<RegionRule>(FilterRuleType.String, "Region");
        private FieldFilterView<TownRule> _townRuleView = new FieldFilterView<TownRule>(FilterRuleType.String, "Town");
        private FieldFilterView<UserFieldRule> _userFieldRuleView = new FieldFilterView<UserFieldRule>(FilterRuleType.String, "User field");
        private FieldFilterView<WebsiteUrlRule> _websiteUrlRuleView = new FieldFilterView<WebsiteUrlRule>(FilterRuleType.String, "Website url");

        private List<FieldFilterViewBase> _filterViews = new List<FieldFilterViewBase>();

        private FirmPool _firmPool;
        private List<FirmView> _filteredFirmViews = new List<FirmView>();

        public FilterSelector(FirmPool firmPool)
        {
            _firmPool = firmPool;

            _filterViews.Add(_nameRuleView);
            _filterViews.Add(_enterDateRuleView);
            _filterViews.Add(_contactsAmountRuleView);
            _filterViews.Add(_countryRuleView);
            _filterViews.Add(_postIndexRuleView);
            _filterViews.Add(_streetRuleView);
            _filterViews.Add(_regionRuleView);
            _filterViews.Add(_townRuleView);
            _filterViews.Add(_userFieldRuleView);
            _filterViews.Add(_websiteUrlRuleView);
        }

        public void Display(TableLayoutPanel layoutPanel)
        {
            _townRuleView.Display(layoutPanel);
            foreach (var filterView in _filterViews)
            {
                filterView.Display(layoutPanel);
            }
        }

        public List<FirmView> GetSelectedFirmViews()
        {
            var firms = _firmPool.FirmViews;
            _filteredFirmViews = firms;

            NameRule nameRule = _nameRuleView.GetFilterRule();
            EnterDateRule enterDateRule = _enterDateRuleView.GetFilterRule();

            _filteredFirmViews = _filteredFirmViews.Where(current =>
            {
                bool result = true;
                result = nameRule == null ? result && true : result && nameRule.FirmRespond(current.NameField);
                result = enterDateRule == null ? result && true : result && enterDateRule.FirmRespond(current.EnterDateField);

                return result;
            }).ToList();
            return _filteredFirmViews;
        }
    }
}
