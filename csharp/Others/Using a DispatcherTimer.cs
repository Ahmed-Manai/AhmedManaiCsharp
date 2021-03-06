Using a DispatcherTimer

<Window x:Class="DispatcherExamples2.MyWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="DispatcherTimer" Height="360" Width="360">
    <Grid>
        
    </Grid>
</Window>
//File:Window.xaml.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DispatcherExamples2
{
    partial class MyWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        public MyWindow()
        {
            InitializeComponent();
            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromSeconds(2);
            dt.Start();
        }
        void dt_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] vals = new byte[3];
            rnd.NextBytes(vals);
            Color c = Color.FromRgb(vals[0], vals[1], vals[2]);
            this.Background = new SolidColorBrush(c);
        }
    }
}

