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
    public class PostIndexField : Field<string>
    {
        public PostIndexField() : base(new StringFieldFilterView("Post index"))
        {
        }

        public override string Value
        {
            get { return Firm.PostIndex; }
            set { Firm.PostIndex = value; }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            AddDisplayingColumn(gridView, "Post index", nameof(FirmViewElement.PostIndex)); 
        }

        public override Field<string> Clone()
        {
            return new PostIndexField();
        }

        public override IFilterRule CreateRule()
        {
            return new PostIndexRule(FilterView.IsFilterActive, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
