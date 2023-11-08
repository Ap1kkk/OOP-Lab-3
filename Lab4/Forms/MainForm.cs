using Lab_3;
using Lab4.Forms.FieldSelectForms;
using Lab4.Forms.FilterForms;
using Lab4.Main;
using Lab4.Main.Fields;
using Lab4.Main.Pools;
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

        private ContactFieldSelectForm _contactFieldSelectForm;
        private ContactFieldPool _contactFieldPool;

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

            _firmFieldPool = new FirmFieldPool();

            _firmFilterForm = new FirmFilterForm(_mainController);
            _firmFieldSelectForm = new FirmFieldSelectForm(_mainController, _firmFieldPool);
            //_firmFieldSelectForm.FormClosed += _firmFieldSelectForm_FormClosed;
            _addFirmForm = new AddFirmForm(_firmFieldPool);

            _contactFieldPool = new ContactFieldPool();
            _contactFieldSelectForm = new ContactFieldSelectForm(_mainController, _contactFieldPool);

            _mainController.DisplayFirmColumns(FirmsGridView);
            _mainController.DisplayAllData();
        }

        private void _firmFieldSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainController.DisplayFirmColumns(FirmsGridView);
        }

        private void addFirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addFirmForm.ShowDialog();
        }

        private void firmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFilterForm.ShowDialog();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void firmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _firmFieldSelectForm.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _contactFieldSelectForm.ShowDialog();
        }
    }
}
