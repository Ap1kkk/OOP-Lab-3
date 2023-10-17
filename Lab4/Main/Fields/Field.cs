using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab4.Main
{
    public abstract class Field<T> where T : IComparable
    {
        public abstract T Value { get; set; }
        protected readonly Dictionary<Type, ILogicalExpression<T>> FilterExpressions = new Dictionary<Type, ILogicalExpression<T>>();

        protected abstract IFilterRule<ILogicalExpression<T>, Field<T>, T> FilterRule { get; }
        protected Firm Firm;

        public Field(Firm relatedFirm)
        {
            if (relatedFirm == null)
                throw new ArgumentNullException(nameof(relatedFirm));
            Firm = relatedFirm;
        }

        public abstract Field<T> Clone();

        public void AddRule(ILogicalExpression<T> filterExpression)
        {
            if(filterExpression == null)
                throw new ArgumentNullException(nameof(filterExpression));

            if (FilterExpressions.ContainsKey(filterExpression.GetType()))
                return;

            FilterExpressions.Add(filterExpression.GetType(), filterExpression);
        }
        public void ClearRules()
        {
            FilterExpressions.Clear();
        }
        public void RemoveRule(ILogicalExpression<T> filterExpression)
        {
            if (filterExpression == null)
                throw new ArgumentNullException(nameof(filterExpression));

            if(!FilterExpressions.ContainsKey(filterExpression.GetType()))
                throw new ArgumentException(nameof(filterExpression));

            FilterExpressions.Remove(filterExpression.GetType());
        }

        public bool GetFilterResult(Field<T> comparable)
        {
            bool result = true;
            foreach (var filterExpression in FilterExpressions.Values)
            {
                result = result && filterExpression.Compare(this, comparable);
            }
            return result;
        }
    }
}
