using Lab_3;
using Lab4.Main.Expressions;
using Lab4.Main.Rules;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Fields
{
    public class NameField : Field<string>
    {
        public NameField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override string Value
        {
            get { return Firm.Name; }
            set { Firm.Name = value; }
        }

        public override Field<string> Clone()
        {
            return new NameField(Firm);
        }
    }
}
