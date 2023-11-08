using Lab4.Main.Fields;
using Lab4.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Forms.FieldSelectForms
{
    public class ContactFieldSelectForm : FieldSelectForm
    {
        public ContactFieldSelectForm(MainController mainController, IFieldPool fieldPool) : base(mainController, fieldPool)
        {
        }

        protected override void Initialize()
        {
            MainController.ApplyDisplayingContactFields(Fields);
        }

        protected override void ApplyButton_Click(object sender, EventArgs e)
        {
            MainController.ApplyDisplayingContactFields(Fields);
            Close();
        }
    }
}
