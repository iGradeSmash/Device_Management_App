﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Managament_App.Forms.Issue
{
    public partial class LoanRequestForm : Form
    {
        public LoanRequestForm()
        {
            InitializeComponent();
        }

        private void newMDIChildView_Click(object sender, EventArgs e)
        {
            RequestForm request = new RequestForm();
            request.MdiParent = this;
            request.Show();
        }

        private void LoanRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void newMDIViewHistory_Click(object sender, EventArgs e)
        {
            ViewHistoryForm viewHistoryForm = new ViewHistoryForm();
            viewHistoryForm.MdiParent = this;
            viewHistoryForm.Show();
        }
    }
}
