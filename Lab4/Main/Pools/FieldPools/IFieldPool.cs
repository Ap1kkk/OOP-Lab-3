using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main
{
    public interface IFieldPool
    {
        List<IFieldBase> Fields { get; }
    }
}
