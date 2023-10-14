using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SubFirmTypeCollection : IEnumerator<SubFirmType>, IEnumerable
    {
        public int Count => _subFirmTypes.Count;

        public SubFirmType Current
        {
            get
            {
                if (_index < 0) throw new InvalidOperationException("Enumerator ended");
                return _subFirmTypes[_index];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                if (_index < 0) throw new InvalidOperationException("Enumerator ended");
                return _subFirmTypes[_index];
            }
        }

        private int _index = -1;

        private readonly List<SubFirmType> _subFirmTypes = new List<SubFirmType>();

        public SubFirmTypeCollection()
        {

        }
        public IEnumerator GetEnumerator() => _subFirmTypes.GetEnumerator();

        public void Dispose()
        {
            _index = -1;
        }

        public bool MoveNext()
        {
            _index++;
            return _index > 0 && _index < _subFirmTypes.Count;
        }

        public void Reset()
        {
            _index = 0;   
        }
        public SubFirmType Add(bool isMain, string name)
        {
            SubFirmType temp = new SubFirmType(isMain, name);
            SubFirmType type = FirstOrDefault(temp);

            if (type as object == null)
            {
                type = temp;
                _subFirmTypes.Add(type);
            }
            return type;
        }
        public SubFirmType Add(SubFirmType type)
        {
            return Add(type.IsMain, type.Name);
        }

        public void Clear()
        {
            _subFirmTypes.Clear();
        }

        private SubFirmType FirstOrDefault(SubFirmType type)
        {
            return _subFirmTypes
                .FirstOrDefault(current => current.Name == type.Name && current.IsMain == type.IsMain);
        }
    }
}
