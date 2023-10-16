using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Fields
{
    public class WebsiteUrlField : Field<string>
    {
        public WebsiteUrlField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override IFilterRule<ILogicalExpression<string>, Field<string>, string> FilterRule =>
            new WebsiteUrlRule(this) as IFilterRule<ILogicalExpression<string>, Field<string>, string>;

        public override string Value => Firm.WebsiteUrl;

        public override Field<string> Clone()
        {
            return new WebsiteUrlField(Firm);
        }
    }
}
