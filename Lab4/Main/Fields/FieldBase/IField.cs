using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Fields
{
    public interface IField<T> : IFieldBase where T : IComparable
    {

    }
}
