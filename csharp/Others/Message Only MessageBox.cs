Message Only MessageBox

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="250" Width="440">
    <StackPanel>
        <Button Click="btnMessageOnly_Click" Content="Message Only" Margin="4" Name="btnMessageOnly" />
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

        private void btnMessageOnly_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A MessageBox.");
        }

    }
}

