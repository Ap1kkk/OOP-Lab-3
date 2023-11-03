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
        public ContactsAmountField() : base(new IntFieldFilterView("Contacts amount"))
        {
        }

        public override int Value
        {
            get { return Firm.Main.ContactsAmount; }
            set { throw new InvalidOperationException("Cannot change Contacts Amount value"); }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Contacts Amount", nameof(FirmViewElement.ContactsAmount));
        }

        public override Field<int> Clone()
        {
            return new ContactsAmountField();
        }

        public override IFilterRule CreateRule()
        {
            return new ContactsAmountRule(FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
