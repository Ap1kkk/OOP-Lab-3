using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.FirmRules
{
    public class XFieldRule : FirmFilterRule<string>
    {
        public override bool FirmRespond(Firm firm)
        {
            return LogicalExpression.Compare(ComparingValue, $"{firm.Country} | {firm.EnterDate}");
        }
    }
}
