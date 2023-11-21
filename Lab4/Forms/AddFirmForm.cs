using Lab4.Main;
using Lab4.Main.InputFieldView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AddFirmForm : Form
    {
        private FirmFieldPool _fieldPool;
        private List<IInputFieldViewBase> _inputFields = new List<IInputFieldViewBase>();
        private InputFieldViewFactory _inputFieldViewFactory;

        public AddFirmForm(FirmFieldPool fieldPool)
        {
            InitializeComponent();
            _fieldPool = fieldPool;
            _inputFieldViewFactory = new InputFieldViewFactory();

            CreateInputFields();
            DisplayInputFields();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private bool ValidateInputFirm()
        {
            return false;
        }

        private void CreateInputFields()
        {
            _inputFields.Clear();
            foreach (var field in _fieldPool.Fields)
            {
                _inputFields.Add(_inputFieldViewFactory.Create(field.Type, field.DisplayingName));
            }
        }

        private void DisplayInputFields()
        {
            foreach (var inputField in _inputFields)
            {
                inputField.Display(InputLayoutPanel);
            }
        }
    }
}
