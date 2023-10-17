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
        
        public MainForm()
        {
            InitializeComponent();
            Firm firm = FirmFactory.Instance.Create("country", "region", "town", "street",
                "postIndex", "email", "websiteUrl", new DateTime(2000, 10, 10), "bossName", "officialBossName", "phoneNumber");

            firm.AddContact(new Contact(new ContactType("name", "note"), "description", "information", new DateTime(1990, 2, 2), new DateTime(2000, 2, 2)));
            firm.SetField("field1", "vallues");

            FirmView firmView = new FirmView(firm);
            firmView.DisplayFirm(FirmTableLayout);
            firmView.DisplaySubFirms(SubFirmsTableLayout);
            firmView.DisplayContacts(ContactsTableLayout);

            for (int i = 0; i < 5; i++)
            {
                firmView.DisplayFirm(FirmTableLayout);
                firmView.DisplaySubFirms(SubFirmsTableLayout);
            }

            for (int i = 0; i < 15; i++)
            {
                firmView.DisplaySubFirms(SubFirmsTableLayout);
                firmView.DisplayContacts(ContactsTableLayout);
            }
        }
    }
}
