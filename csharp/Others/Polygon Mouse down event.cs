Polygon Mouse down event

<Window x:Class="WpfApplication1.ShapesWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ShapesWindow" Height="200" Width="550">
    <StackPanel Orientation="Horizontal">
        <Polygon Fill="Aqua" Canvas.Left = "90" Canvas.Top="25" Points="23 0 25 23 0 40" MouseDown="Polygon_MouseDown"/>
    </StackPanel>
</Window>


//File:Window.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class ShapesWindow : Window
    {
        public ShapesWindow()
        {
            InitializeComponent();
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("happycodings.com");
        }
    }
}

