﻿using Airport.StaticClasses;
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

namespace Airport.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePlanes.xaml
    /// </summary>
    public partial class PagePlanes : Page
    {
        public PagePlanes()
        {
            InitializeComponent();
            dgPlane.ItemsSource = BaseConnect.baseModel.Plane.ToList();
        }

        private void btnSaveChange_Click(object sender, RoutedEventArgs e)
        {
            BaseConnect.baseModel.SaveChanges();
        }
    }
}
