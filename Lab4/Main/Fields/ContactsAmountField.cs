using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules;
using Lab4.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.Fields
{
    public class ContactsAmountField : Field<int>
    {
        public override string Name => _name;
        private const string _name = "ContactsAmount";

        public ContactsAmountField() : base(new IntFieldFilterView(_name))
        {
        }

        public override int Value
        {
            get { return Firm.Main.ContactsAmount; }
            set { throw new InvalidOperationException("Cannot change Contacts Amount value"); }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(FirmViewElement.ContactsAmount));
        }

        public override Field<int> Clone()
        {
            return new ContactsAmountField();
        }

        public override IFilterRule CreateRule()
        {
            return new ContactsAmountRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
