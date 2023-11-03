using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Rules
{
    public interface IFilterRule
    {
        bool FirmRespond(Firm firm);

    }
}
