using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class SubFirmTypeCollection : IEnumerable<SubFirmType>
    {
        public int Count => _subFirmTypes.Count;

        private readonly List<SubFirmType> _subFirmTypes = new List<SubFirmType>();

        public SubFirmTypeCollection()
        {
            
        }

        public IEnumerator<SubFirmType> GetEnumerator()
        {
            
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
