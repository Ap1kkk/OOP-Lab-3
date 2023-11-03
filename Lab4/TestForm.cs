using Lab_3;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            Firm firm = FirmFactory.Instance.Create();
            firm.SetField(FirmFactory.FieldName1, "value 1");
            firm.SetField(FirmFactory.FieldName2, "value 2");
            firm.SetField(FirmFactory.FieldName3, "value 3");
            firm.SetField(FirmFactory.FieldName4, "value 4");
            firm.SetField(FirmFactory.FieldName5, "value 5");

            int index = 1;
            foreach (var userField in FirmFactory.Instance.UserFields.Keys)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = $"UserField{index}";
                column.HeaderText = $"UserField{index}";
                index++;
                dataGridView1.Columns.Add(column);
            }

            firmBindingSource.DataSource = new
            {
                firm.Name,
                firm.Country,
                firm.Region,
                firm.Town,
                firm.Street,
                firm.PostIndex,
                firm.Email,
                firm.WebsiteUrl,
                firm.EnterDate,
                firm.ContactsAmount,
                UserField1 = firm.UserFields[FirmFactory.FieldName1],
                UserField2 = firm.UserFields[FirmFactory.FieldName2],
                UserField3 = firm.UserFields[FirmFactory.FieldName3],
                UserField4 = firm.UserFields[FirmFactory.FieldName4],
                UserField5 = firm.UserFields[FirmFactory.FieldName5],
            };
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = firmBindingSource;
        }
    }
}
