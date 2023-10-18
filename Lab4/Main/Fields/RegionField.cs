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
    public class RegionField : Field<string>
    {
        public RegionField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override string Value
        {
            get { return Firm.Region; }
            set { Firm.Region = value; }
        }

        public override Field<string> Clone()
        {
            return new RegionField(Firm);
        }
    }
}
