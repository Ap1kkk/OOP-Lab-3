﻿using Lab4.Main;
using Lab4.Main.Rules;
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

    public partial class FilterForm : Form
    {
        private MaInController _mainController;
        public FilterForm(MaInController maInController)
        {
            InitializeComponent();
            _mainController = maInController;
            _mainController.DisplayFilters(FilterTableLayout);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _mainController.ApplyFilter();
        }
    }
}