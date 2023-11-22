using Lab_3;
using Lab4.Forms.FieldSelectForms;
using Lab4.Forms.FilterForms;
using Lab4.Main;
using Lab4.Main.Fields;
using Lab4.Main.FilterFieldVIew;
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
    public partial class MainForm : Form
    {
        private MainController _mainController;

        private FirmFilterForm _firmFilterForm;
        private FirmFieldSelectForm _firmFieldSelectForm;
        private AddFirmForm _addFirmForm;
        private FirmFieldPool _firmFieldPool;

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Firm firm = FirmFactory.Instance.Create($"name{i}", "country", "region", "town", "street",
                "postIndex", "email", "websiteUrl", new DateTime(2000 + i, 10, 10), "bossName", "officialBossName", "phoneNumber");

                for (int j = 0; j < i; j++)
                {
                    firm.AddContact(new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2)));
                }
                firm.SetField(FirmFactory.FieldName1, "vallues");
                firm.SetField(FirmFactory.FieldName2, "vallues");
                firm.SetField(FirmFactory.FieldName3, "vallues");
                firm.SetField(FirmFactory.FieldName4, "vallues"); 
                firm.SetField(FirmFactory.FieldName5, "vallues"); 
            }

            //firmBindingSource1, subFirmBindingSource, 
            //    contactBindingSource

            _mainController = new MainController();

            _mainController.OnDataChanged += _mainController_OnDataChanged;
            _mainController.OnFieldsChanged += _mainController_OnFieldsChanged;

            _firmFieldPool = new FirmFieldPool();

            _firmFilterForm = new FirmFilterForm(_mainController);
            _firmFieldSelectForm = new FirmFieldSelectForm(_mainController, _firmFieldPool);
            //_firmFieldSelectForm.FormClosed += _firmFieldSelectForm_FormClosed;
            _addFirmForm = new AddFirmForm();

            _mainController.DisplayAllData();
        }

        private void _mainController_OnFieldsChanged(List<IFieldBase> fields)
        {
            FirmsGridView.Columns.Clear();
            foreach (IFieldBase field in fields)
            {
                var column = new DataGridViewTextBoxColumn() { 
                    HeaderText = field.DisplayingName,
                    DataPropertyName = field.Name,
                };
                FirmsGridView.Columns.Add(column);
            }
        }

        private void _mainController_OnDataChanged(List<Firm> firms)
        {
            firmBindingSource1.DataSource = Converter.ConvertFirms(firms);
        }

        private void addFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addFirmForm.ShowDialog();
        }

        private void firmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFilterForm.ShowDialog();
        }

        private void firmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFieldSelectForm.ShowDialog();
        }
    }
}
