using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Main.FilterFieldVIew
{

    public class FilterFieldViewFactory
    {
        private TableLayoutPanel _layoutPanel;

        public FilterFieldViewFactory(TableLayoutPanel tableLayoutPanel)
        {
            _layoutPanel = tableLayoutPanel;
        }

        public T Create<T>(string label) where T : IFieldFilterViewBase
        {
            return (T)Activator.CreateInstance(typeof(T), label, _layoutPanel);
        }

        public IFieldFilterViewBase Create(FieldViewType viewType, string label)
        {
            switch (viewType)
            {
                case FieldViewType.String:
                    return new StringFieldFilterView(label, _layoutPanel);
                case FieldViewType.DateTime:
                    return new DateFieldFilterView(label, _layoutPanel);
                case FieldViewType.Int:
                    return new IntFieldFilterView(label, _layoutPanel);
                default:
                    return null;
            }
        }
    }
}
