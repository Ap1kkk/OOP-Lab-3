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
    public class UserField : Field<string>
    {
        private readonly string _fieldName;
        public UserField(Firm relatedFirm, string fieldName) : base(relatedFirm)
        {
            _fieldName = fieldName;
        }

        public override IFilterRule<ILogicalExpression<string>, Field<string>, string> FilterRule =>
            new UserFieldRule(this) as IFilterRule<ILogicalExpression<string>, Field<string>, string>;

        public override string Value => Firm.GetField(_fieldName);

        public override Field<string> Clone()
        {
            return new UserField(Firm, _fieldName);
        }
    }
}
