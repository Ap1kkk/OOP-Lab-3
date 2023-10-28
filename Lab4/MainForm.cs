using Lab_3;
using Lab4.Main;
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
        private FilterForm _filterForm;
        public MainForm()
        {
            InitializeComponent();

            AddFirmColumns();

            for (int i = 0; i < 20; i++)
            {
                Firm firm = FirmFactory.Instance.Create($"name{i}", $"country{i}", $"region{i}", $"town{i}", $"street{i}",
                    $"postIndex{i}", $"email{i}", $"websiteUrl{i}", new DateTime(2000, 10, 10), $"bossName{i}", $"officialBossName{i}", $"phoneNumber{i}");

                firm.AddContact(new Contact(new ContactType($"name{i}", $"note{i}"), $"description{i}", $"information{i}", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2)));
                firm.SetField("field1", $"value{i}");
                firm.SetField("field2", $"value{i}");
                firm.SetField("field3", $"value{i}");
                firm.SetField("field4", $"value{i}");
                firm.SetField("field5", $"value{i}");

            }

            _mainController = new MainController(FirmsGridView, firmBindingSource1, dataGridView2, subFirmBindingSource, dataGridView3, contactBindingSource);
            _filterForm = new FilterForm(_mainController);

            _mainController.DisplayAllData();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filterForm.ShowDialog();   
        }

        private void AddFirmColumns()
        {
            int index = 1;
            foreach (var userField in FirmFactory.Instance.UserFields.Keys)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = $"UserField{index}";
                column.HeaderText = $"UserField{index}";
                index++;
                FirmsGridView.Columns.Add(column);
            }
        }
    }
}
