Replease mouse with Mouse.Capture(null)

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="MouseInput" Height="360" Width="450">
    <Grid>
      <Ellipse Fill="Aqua" x:Name="myEllipse" />
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
using System.Diagnostics;


namespace WpfApplication1
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();

           myEllipse.MouseUp += myEllipse_MouseUp;

        }

        void myEllipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
        }


    }
}

