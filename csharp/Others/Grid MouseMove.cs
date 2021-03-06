Grid MouseMove

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Card Dealer" Height="700" Width="900">

    <Grid Name="contentGrid"
    MouseLeftButtonDown="Grid_MouseLeftButtonDown"
    MouseLeftButtonUp="Grid_MouseLeftButtonUp" 
    MouseMove="Grid_MouseMove">
        <Grid.Background>
            <LinearGradientBrush EndPoint="0,0.1" StartPoint="0.5,1">
                <GradientStop Color="Blue" Offset="0"/>
                <GradientStop Color="Black" Offset="1"/>
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("left button down");
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("left button up");
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("moving");
        }

    }
}

