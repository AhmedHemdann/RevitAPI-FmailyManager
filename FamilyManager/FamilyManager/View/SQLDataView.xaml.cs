﻿using FamilyManager.ViewModel;
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
using System.Windows.Shapes;

namespace FamilyManager.View
{
    /// <summary>
    /// Interaction logic for SQLDataView.xaml
    /// </summary>
    public partial class SQLDataView : Window
    {

        #region Constructor 
        public SQLDataView()
        {
            InitializeComponent();
            DataContext = new SQLDataViewModel();
        }
        #endregion

    }
}
