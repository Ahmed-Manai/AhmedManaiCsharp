TextBox KeyUp

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF " Height="320" Width="400">
    <DockPanel LastChildFill="True">
        <TextBox DockPanel.Dock="Top" KeyUp="TextBox_KeyEvent" />
        <TextBox Name="txtLog" HorizontalAlignment="Stretch" 
                 IsReadOnly="True" VerticalScrollBarVisibility="Visible"/>
    </DockPanel>
</Window>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_KeyEvent(object sender, KeyEventArgs e)
        {
            String msg = String.Format("{0} - {1}\n",e.RoutedEvent.Name, e.Key);

            txtLog.Text += msg;
            txtLog.ScrollToEnd();
        }
    }
}

