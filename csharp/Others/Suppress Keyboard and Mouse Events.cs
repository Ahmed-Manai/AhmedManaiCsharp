Suppress Keyboard and Mouse Events

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF " Height="120" Width="250">
    <StackPanel Orientation="Horizontal">
        <StackPanel Orientation="Horizontal" PreviewMouseDown="StackPanel_PreviewMouseDown">
            <Button Content="Blocked" Click="Button_Click" Height="24" Margin="8" Width="80"/>
        </StackPanel>
        <Button Content="Not Blocked" Click="Button_Click" Height="24" Margin="8" Width="80"/>
    </StackPanel>
</Window>
//File:Window.xaml.cs
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked", "Button");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}

