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
        private FilterForm _filterForm = new FilterForm();
        public MainForm()
        {
            InitializeComponent();

            AddFirmColumns();

            Firm firm = FirmFactory.Instance.Create("name", "country", "region", "town", "street",
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");

            firm.AddContact(new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2)));
            firm.SetField("field1", "vallues");
            firm.SetField("field2", "vallues");
            firm.SetField("field3", "vallues");
            firm.SetField("field4", "vallues");



            FirmView firmView = new FirmView(firm);
            firmBindingSource1.DataSource = firmView.DisplayElement;
            //subFirmBindingSource.DataSource = firmView.DisplaySubFirmsElements;
            var t = new SubFirmViewElement(firm.Main);
            subFirmBindingSource.DataSource = t;
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
                dataGridView1.Columns.Add(column);
            }
        }
    }
}
