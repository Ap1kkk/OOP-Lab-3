using Lab_3;
using Lab4.Main.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.FirmRules
{
    public interface IFirmFilterRule : IFilterRule
    {
        bool FirmRespond(Firm firm);
        void AddDependency<T>(bool isFilterActive, T comparingValue, ILogicalExpression<T> logicalExpression) where T: IComparable;
    }
}
