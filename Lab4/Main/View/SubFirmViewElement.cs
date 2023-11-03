using Lab_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.View
{
    public struct SubFirmViewElement
    {
        public string IsMain => _subFirm.Type.IsMain.ToString();
        public string Name => _subFirm.Name;
        public string BossName => _subFirm.BossName;
        public string OfficialBossName => _subFirm.OfficialBossName;
        public string PhoneNumber => _subFirm.PhoneNumber;
        public string Email => _subFirm.Email;
        public int ContactsAmount => _subFirm.ContactsAmount;

        private SubFirm _subFirm;
        public SubFirmViewElement(SubFirm relatedSubFirm)
        {
            _subFirm = relatedSubFirm;
        }
    }
}
