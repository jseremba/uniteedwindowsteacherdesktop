﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniteEDTeacher.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            //this.ControlBox=false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


        }
    }
}
