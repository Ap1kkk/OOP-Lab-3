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
    public class UserField : Field<string>
    {
        private readonly string _fieldName;
        public UserField(string fieldName) : base(new StringFieldFilterView(fieldName))
        {
            _fieldName = fieldName;
        }
        public override string Value
        {
            get { return Firm.GetField(_fieldName); }
            set { Firm.SetField(_fieldName, value); }
        }

        public override void AddDisplayingColumn(DataGridView gridView)
        {
            switch (_fieldName)
            {
                case FirmFactory.FieldName1:
                    AddDisplayingColumn(gridView, _fieldName, nameof(FirmViewElement.UserField1));
                    break;
                case FirmFactory.FieldName2:
                    AddDisplayingColumn(gridView, _fieldName, nameof(FirmViewElement.UserField2));
                    break;
                case FirmFactory.FieldName3:
                    AddDisplayingColumn(gridView, _fieldName, nameof(FirmViewElement.UserField3));
                    break;
                case FirmFactory.FieldName4:
                    AddDisplayingColumn(gridView, _fieldName, nameof(FirmViewElement.UserField4));
                    break;
                case FirmFactory.FieldName5:
                    AddDisplayingColumn(gridView, _fieldName, nameof(FirmViewElement.UserField5));
                    break;
                default:
                    break;
            }
        }

        public override Field<string> Clone()
        {
            return new UserField(_fieldName);
        }

        public override IFilterRule CreateRule()
        {
            return new UserFieldRule(_fieldName, FilterView.FilteringValue, FilterView.LogicalExpression);
        }
    }
}
