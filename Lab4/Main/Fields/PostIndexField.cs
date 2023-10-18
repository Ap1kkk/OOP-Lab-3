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
    public class PostIndexField : Field<string>
    {
        public PostIndexField(Firm relatedFirm) : base(relatedFirm)
        {
        }

        public override string Value
        {
            get { return Firm.PostIndex; }
            set { Firm.PostIndex = value; }
        }

        public override Field<string> Clone()
        {
            return new PostIndexField(Firm);
        }
    }
}
