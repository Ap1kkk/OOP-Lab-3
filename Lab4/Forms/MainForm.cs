using Lab_3;
using Lab4.Forms.FieldSelectForms;
using Lab4.Forms.FilterForms;
using Lab4.Main;
using Lab4.Main.Fields;
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
        private FilterForm _firmFilterForm;
        private FieldSelectForm _firmFieldSelectForm;
        private AddFirmForm _addFirmForm;
        private FirmFieldPool _fieldPool;
        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Firm firm = FirmFactory.Instance.Create("name", "country", "region", "town", "street",
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");

                firm.AddContact(new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2)));
                firm.SetField("field1", "vallues");
                firm.SetField("field2", "vallues");
                firm.SetField("field3", "vallues");
                firm.SetField("field4", "vallues"); 
                firm.SetField("field5", "vallues"); 
            }


            _mainController = new MainController(firmBindingSource1, subFirmBindingSource, 
                contactBindingSource);
            _fieldPool = new FirmFieldPool();
            _firmFilterForm = new FirmFilterForm(_mainController);
            _firmFieldSelectForm = new FirmFieldSelectForm(_mainController, _fieldPool);
            _firmFieldSelectForm.FormClosed += _firmFieldSelectForm_FormClosed;
            _addFirmForm = new AddFirmForm(_fieldPool);

            _mainController.DisplayFirmColumns(FirmsGridView);
            _mainController.DisplayAllData();
        }

        private void _firmFieldSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainController.DisplayFirmColumns(FirmsGridView);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFilterForm.ShowDialog();   
        }

        private void selectFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFieldSelectForm.ShowDialog();
        }

        private void addFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addFirmForm.ShowDialog();
        }
    }
}
