using Lab_3;
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
        public override string Value => _relatedFirm.Name;
        private Firm _relatedFirm = null;
        public NameField(Firm firm)
        {
            _relatedFirm= firm;
        }
        public override Field<string> Clone()
        {
            throw new NotImplementedException();
        }

        public override void CreateRule()
        {
            throw new NotImplementedException();
        }
    }
}
