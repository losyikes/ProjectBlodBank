﻿using System;
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
using ProjektBlodbank.Business;
//nedenstående er temp using statements
using ProjektBlodbank.Data;

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for RulesContent.xaml
    /// </summary>
    public partial class RulesContent : UserControl
    {
        //temp
        private BloodbankDataContext db;
        public RulesContent()
        {
            InitializeComponent();
            db = new BloodbankDataContext();
        }
    }
}
