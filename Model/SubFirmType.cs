using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SubFirmType
    {
        public bool IsMain { get; private set; }
        public string Name { get; private set; }

        public SubFirmType(bool isMain, string name)
        {
            IsMain = isMain;
            Name = name;
        }

        public static bool operator == (SubFirmType left, SubFirmType right)
        {
            return left.IsMain == right.IsMain && left.Name == right.Name;
        }
        public static bool operator != (SubFirmType left, SubFirmType right)
        {
            return left.IsMain == right.IsMain && left.Name == right.Name;
        }
    }
}
