Throw Unhandled Exception

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Window1" Height="150" Width="400">
  <StackPanel>
    <Button x:Name="btnThrowUnhandledException" Click="btnThrowUnhandledException_Click" Content="Throw Unhandled Exception" Margin="10,5,10,5"/>
  </StackPanel>
</Window>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.ComponentModel;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void btnThrowUnhandledException_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}

