using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public class UserFieldRule : FirmFilterRule<string>
    {
        private string _userFieldKey;
        public UserFieldRule(string userFieldKey)
        {
            _userFieldKey = userFieldKey;
        }
        //public UserFieldRule(bool isFilterActive, string userFieldKey, string comparingValue, ILogicalExpression<string> logicalExpression) 
        //    : base(isFilterActive, comparingValue, logicalExpression)
        //{
        //    _userFieldKey = userFieldKey;
        //}
        public override bool FirmRespond(Firm firm)
        {
            return LogicalExpression.Compare(ComparingValue, firm.UserFields[_userFieldKey]);
        }
    }
}
