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
    public class StreetField : Field<string>
    {
        public StreetField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override string Value
        {
            get { return Firm.Street; }
            set { Firm.Street = value; }
        }

        public override Field<string> Clone()
        {
            return new StreetField(Firm);
        }
    }
}
