using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class FirmFactory
    {
        public static FirmFactory Instance { get; private set; } = null;

        private List<string> _userFields = new List<string>() { "field1", "field2", "field3", "field4", "field5", };
        private const string MainFirmName = "Main Firm";

        public FirmFactory()
        {
            if(Instance != null)
            {
                throw new InvalidOperationException("Only one instance of FirmFactory possible");
            }

            Instance = this;
            FillUserFields();
        }

        //public Firm Create()
        //{

        //    //return new Firm();
        //}

        public void FillUserFields()
        {

        }
    }
}
