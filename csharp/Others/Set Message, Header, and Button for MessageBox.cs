Set Message, Header, and Button for MessageBox

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="180" Width="400">
    <StackPanel>
        <Button Click="btnMessageHeaderButton_Click" Content="Message, Header, and Button" Margin="4" Name="btnMessageHeaderButton" />
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


        private void btnMessageHeaderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A MessageBox with a title and buttons.",  "WPF", MessageBoxButton.YesNoCancel);
        }

    }
}

