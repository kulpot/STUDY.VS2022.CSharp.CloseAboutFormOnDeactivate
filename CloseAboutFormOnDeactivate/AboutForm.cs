﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloseAboutFormOnDeactivate
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            //this.Close();
            this.Dispose();
        }
    }
}
