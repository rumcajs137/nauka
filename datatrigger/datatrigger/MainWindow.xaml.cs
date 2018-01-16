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

namespace datatrigger
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<MyImages> images = new List<MyImages>();
            images.Add(new MyImages("logo-videokurspl.png","Logo"));
            images.Add(new MyImages("logo-videokurspl.png", "Logo2"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            images.Add(new MyImages("asffas.png", "Logo3"));
            this.DataContext = images;
        }
    }
}
