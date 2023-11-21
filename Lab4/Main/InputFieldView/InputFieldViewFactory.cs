using Lab4.Main.FilterFieldVIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.InputFieldView
{
    public class InputFieldViewFactory
    {
        public IInputFieldViewBase Create(FieldViewType viewType, string label)
        {
            switch (viewType)
            {
                case FieldViewType.String:
                    return new StringInputFieldView(label);
                case FieldViewType.DateTime:
                    return new DateInputFieldView(label);
                case FieldViewType.Int:
                    return new IntInputFieldView(label);
                default:
                    return null;
            }
        }
    }
}
