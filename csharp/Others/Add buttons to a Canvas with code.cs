Add buttons to a Canvas with code

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Window1" Height="400" Width="400" Loaded="Window_Loaded">
    <Canvas Name="canvas1">
    </Canvas>
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
        Button button1 = null;
        Button button2 = null;
        Button button3 = null;

        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button1 = new Button { Content = "Button", Width = 80, Height = 24 };
            Canvas.SetLeft(button1, 120);
            Canvas.SetTop(button1, 25);
            canvas1.Children.Add(button1);
            button2 = new Button { Content = "Wider" };
            Canvas.SetLeft(button2, 45);
            Canvas.SetTop(button2, 68);
            canvas1.Children.Add(button2);
            button3 = new Button { Content = "Button" };
            Canvas.SetLeft(button3, 78);
            Canvas.SetTop(button3, 120);
            button3.Padding = new Thickness(9, 2, 9, 2);
            canvas1.Children.Add(button3);
        }
    }
}

