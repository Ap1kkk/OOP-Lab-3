using Lab_3;
using Lab4.Main;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules.FirmRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Forms.FilterForms
{
    struct FilterElement
    {
        public IFieldBase Field;
        public IFieldFilterViewBase FilterView;

        public FilterElement(IFieldBase field, IFieldFilterViewBase filterView)
        {
            Field = field;
            FilterView = filterView;
        }
    }

    public class FirmFilterForm : FilterForm
    {
        private List<FilterElement> _filterElements = new List<FilterElement>();

        private FilterFieldViewFactory _filterFieldViewFactory;

        public FirmFilterForm(MainController mainController) : base(mainController)
        {
            _filterFieldViewFactory = new FilterFieldViewFactory(FilterLayout);
            MainController.OnFieldsChanged += MainController_OnFieldsChanged;
        }
        ~FirmFilterForm()
        {
            MainController.OnFieldsChanged -= MainController_OnFieldsChanged;
        }

        private void MainController_OnFieldsChanged(List<IFieldBase> fields)
        {
            ConvertFields(fields);
        }

        protected override void Initialize()
        {
            
        }

        protected override void ApplyButton_Click(object sender, EventArgs e)
        {
            MainController.ApplyFirmFilter(GetRules());
            Close();
        }

        private void ConvertFields(List<IFieldBase> fields)
        {
            ClearFields();
            foreach (IFieldBase field in fields)
            {
                _filterElements.Add(
                    new FilterElement(field, 
                    _filterFieldViewFactory.Create(field.Type, field.DisplayingName))
                    );
            }
            DisplayFields();
        }

        private void DisplayFields()
        {
            foreach (var filterElement in _filterElements)
            {
                filterElement.FilterView.Display();
            }
        }

        private void ClearFields()
        {
            _filterElements.Clear();
            FilterLayout.Controls.Clear();
        }

        private List<IFirmFilterRule> GetRules()
        {
            List<IFirmFilterRule> filterRules = new List<IFirmFilterRule>();
            foreach (var filterElement in _filterElements)
            {
                IFirmFilterRule rule = filterElement.Field.CreateRule() as IFirmFilterRule;
                IFieldFilterViewBase filterView = filterElement.FilterView;
                rule.BindFilterView(filterView);
                filterRules.Add(rule);
            }

            return filterRules;
        }
    }
}
