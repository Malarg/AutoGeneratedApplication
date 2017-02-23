﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;

namespace AutoGeneratedApplication
{
    public partial class TableDataUserControl : UserControl
    {
        private delegate void CellValidation(object sender, EventArgs e);
        public TableDataUserControl()
        {
            InitializeComponent();
        }

        public TableDataUserControl(TableStructureItem tableStructure, IEnumerable<DataItem> dataItems)
        {
            foreach (var property in tableStructure.Properties)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                var column = new DataGridViewColumn(cell)
                {
                    HeaderText = property.Key,
                };
                DataTable.Columns.Add(column);
            }
        }
    }
}