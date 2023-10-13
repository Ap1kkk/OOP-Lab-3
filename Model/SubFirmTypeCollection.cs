using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SubFirmTypeCollection : IEnumerable
    {
        public int Count => _subFirmTypes.Count;

        private static SubFirmTypeCollection _instance = null;
        private readonly List<SubFirmType> _subFirmTypes = new List<SubFirmType>();

        public SubFirmTypeCollection()
        {
            if(_instance == null)
            {
                _instance = this;
            }
        }
        public static SubFirmType Get(bool isMain, string name)
        {
            SubFirmType temp = new SubFirmType(isMain, name);
            SubFirmType type = FirstOrDefault(temp);

            if (type == null)
            {
                type = temp;
                _instance._subFirmTypes.Add(type);
            }
            return type;
        }
        public static SubFirmType Get(SubFirmType type)
        {
            return Get(type.IsMain, type.Name);
        }

        public static void Clear()
        {
            _instance._subFirmTypes.Clear();
        }
        public IEnumerator GetEnumerator() => _subFirmTypes.GetEnumerator();

        private static SubFirmType FirstOrDefault(SubFirmType type)
        {
            return _instance._subFirmTypes
                .FirstOrDefault(current => current.Name == type.Name && current.IsMain == type.IsMain);
        }

    }
}
