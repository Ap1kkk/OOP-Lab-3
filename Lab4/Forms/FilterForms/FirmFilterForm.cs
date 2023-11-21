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
    public class FirmFilterForm : FilterForm
    {
        private List<IFieldBase> _fields = new List<IFieldBase>();
        private List<IFieldFilterViewBase> _fieldViews = new List<IFieldFilterViewBase>();

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
            _fields = fields;
            ApplyFields();
        }

        protected override void Initialize()
        {
            
        }

        protected override void ApplyButton_Click(object sender, EventArgs e)
        {
            MainController.ApplyFirmFilter(GetRules());
            Close();
        }

        private void ApplyFields()
        {
            ClearFields();
            foreach (IFieldBase field in _fields)
            {
                _fieldViews.Add(_filterFieldViewFactory.Create(field.Type, field.DisplayingName));
            }
            DisplayFields();
        }

        private void DisplayFields()
        {
            foreach (var fieldView in _fieldViews)
            {
                fieldView.Display();
            }
        }

        private void ClearFields()
        {
            _fieldViews.Clear();
            FilterLayout.Controls.Clear();
        }

        private List<IFirmFilterRule> GetRules()
        {
            foreach (var item in _fields)
            {
                
            }
        }
    }
}
