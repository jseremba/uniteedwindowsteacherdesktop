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

    public partial class MyCourses : BaseForm
    {
      
        public MyCourses(String url)
        {
            InitializeComponent();
            MyCoursewebBrowser.Navigate(url);
            
        }
    }
}