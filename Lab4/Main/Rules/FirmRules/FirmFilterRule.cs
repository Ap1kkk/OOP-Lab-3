using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
using Lab4.Main.Rules.FirmRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public abstract class FirmFilterRule<T> : IFirmFilterRule where T : IComparable
    {
        public bool IsFilterActive => _isFilterActive;
        protected T ComparingValue => _comparingValue;
        protected ILogicalExpression<T> LogicalExpression => _logicalExpression;

        private bool _isFilterActive = false;
        private T _comparingValue = default(T);
        private ILogicalExpression<T> _logicalExpression;

        //public FirmFilterRule(bool isFilterActive, T comparingValue, ILogicalExpression<T> logicalExpression)
        //{
        //    IsFilterActive = isFilterActive;
        //    ComparingValue = comparingValue;
        //    LogicalExpression = logicalExpression;
        //}

        public abstract bool FirmRespond(Firm firm);

        public void BindFilterView(IFieldFilterViewBase filterView)
        {
            IFieldFilterView<T> fieldFilterView = filterView as IFieldFilterView<T>;
            _isFilterActive = fieldFilterView.IsFilterActive;
            _comparingValue = fieldFilterView.FilteringValue;
            _logicalExpression = fieldFilterView.LogicalExpression;
        }
    }
}
