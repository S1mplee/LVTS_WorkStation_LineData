﻿using MyUI.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyUI.views
{
    /// <summary>
    /// Interaction logic for DataBaseBuild.xaml
    /// </summary>
    public partial class DataBaseBuild : UserControl
    {
        public DataBaseBuild()
        {
            var vm = new DataBaseBuildVM();
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
