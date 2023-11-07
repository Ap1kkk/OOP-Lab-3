using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules.ContactRules
{
    public interface IContactFilterRule : IFilterRule
    {
        bool ContactRespond(Contact contact);
    }
}
