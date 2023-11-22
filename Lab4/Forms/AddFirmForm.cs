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
        private InputFieldViewFactory _inputFieldViewFactory;
        private InputFirmValidator _firmValidator;
        public AddFirmForm()
        {
            InitializeComponent();
            _inputFieldViewFactory = new InputFieldViewFactory();
            _firmValidator = new InputFirmValidator(_inputFieldViewFactory);
            DisplayInputFields();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ResetMessages();
            if(ValidateInputFirm())
            {
                var firm = _firmValidator.CreateFirm();
                Close();
                return;
            }

        }

        private bool ValidateInputFirm()
        {
            return _firmValidator.Validate();
        }

        private void ResetMessages()
        {
            _firmValidator.Reset();
        }

        private void DisplayInputFields()
        {
            _firmValidator.Display(InputLayoutPanel);
        }
    }
}
