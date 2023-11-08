using Lab_3;
using Lab4.Main;
using Lab4.Main.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public abstract partial class FieldSelectForm : Form
    {
        protected MainController MainController;
        protected IFieldPool FieldPool;

        protected List<IFieldBase> Fields => _fields;
        private List<IFieldBase> _fields;
        private List<FieldCheckBox> _checkBoxes = new List<FieldCheckBox>();

        public FieldSelectForm(MainController mainController, IFieldPool fieldPool)
        {
            InitializeComponent();

            MainController = mainController;
            FieldPool = fieldPool;
            _fields = new List<IFieldBase>(FieldPool.Fields);

            foreach (var field in _fields)
            {
                var fieldCheckBox = new FieldCheckBox(field.Name, field);
                fieldCheckBox.CheckBox.Checked = true;
                fieldCheckBox.CheckChanged += FieldCheckBox_CheckChanged;
                FieldSelectPanel.Controls.Add(fieldCheckBox.CheckBox);
                _checkBoxes.Add(fieldCheckBox);
            }
            MainController.ApplyDisplayingFirmFields(_fields);
        }
        ~FieldSelectForm()
        {
            foreach (var item in _checkBoxes)
            {
                item.CheckChanged -= FieldCheckBox_CheckChanged;
            }
        }

        private void FieldCheckBox_CheckChanged(bool isChecked, IFieldBase field)
        {
            if(isChecked)
            {
                _fields.Add(field);
            }
            else
            {
                _fields.Remove(field);
            }
        }

        protected abstract void ApplyButton_Click(object sender, EventArgs e);
        //{
        //    _mainController.ApplyDisplayingFields(_fields);
        //    Close();
        //}

    }
}
