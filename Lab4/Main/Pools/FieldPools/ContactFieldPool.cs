using Lab4.Main.Fields;
using Lab4.Main.Fields.ContactFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Pools
{
    public class ContactFieldPool : IFieldPool
    {
        public List<IFieldBase> Fields => _fields;
        private List<IFieldBase> _fields = new List<IFieldBase>();

        private NameField _nameField = new NameField();
        private NoteField _noteField = new NoteField();
        private DescriptionField _decriptionField = new DescriptionField();
        private InformationField _informationField = new InformationField();
        private BeginDateField _beginDateField = new BeginDateField();
        private EndDateField _endDateField = new EndDateField();


        public ContactFieldPool()
        {
            _fields.Add(_nameField);
            _fields.Add(_noteField);
            _fields.Add(_decriptionField);
            _fields.Add(_informationField);
            _fields.Add(_beginDateField);
            _fields.Add(_endDateField);
        }
    }
}
