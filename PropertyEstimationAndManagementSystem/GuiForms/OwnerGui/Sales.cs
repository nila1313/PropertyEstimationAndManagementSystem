﻿using PropertyEstimationAndManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    public partial class Sales : Form
    {
        DataAccess da;
        public Sales()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            showSaleTomorrow();
        }

        public void showSaleTomorrow()
        {
            string prob=@"""Transaction""";
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            string sql = @"select count(*) from " +prob + $" where Trade like'{"Sold".ToUpper()}' and convert(varchar, TransactionDateTime,101)='{today}'";
            DataTable dt = da.Execute(sql);
            MessageBox.Show(dt.Rows[0][0].ToString());
        }
    }
}
