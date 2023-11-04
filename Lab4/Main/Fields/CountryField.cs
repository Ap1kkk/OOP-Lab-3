﻿using Lab_3;
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
    public class CountryField : Field<string>
    {
        public override string Name => _name;
        private const string _name = "Country";
        public CountryField() : base(new StringFieldFilterView(_name))
        {
        }

        public override string Value
        {
            get { return Firm.Country; }
            set { Firm.Country = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, _name, nameof(FirmViewElement.Country));
        }

        public override Field<string> Clone()
        {
            return new CountryField();
        }

        public override IFilterRule CreateRule()
        {
            return new CountryRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
