﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webKitBrowser1.Navigate("http://www.google.com");
        }
    }
}
