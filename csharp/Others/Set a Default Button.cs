Set a Default Button

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="120" Width="460">
    <DockPanel>
        <TextBox DockPanel.Dock="Top" Margin="4">Button three is the default button.</TextBox>
        <StackPanel HorizontalAlignment="Center" DockPanel.Dock="Bottom" Orientation="Horizontal">
            <Button Click="SharedButtonClickHandler" Content="Button One" Name="btnOne" Width="80" />
            <Button Click="SharedButtonClickHandler" Content="Button Two" Name="btnTwo" Width="80" />
            <Button Click="SharedButtonClickHandler" Content="Button Three" IsDefault="True" Margin="4" Name="btnThree" />
        </StackPanel>
    </DockPanel>
</Window>
//File:Window.xaml.cs
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SharedButtonClickHandler(object sender,RoutedEventArgs e)
        {
            Button source = e.OriginalSource as Button;

            if (source != null)
            {
                MessageBox.Show("You pressed " + source.Name, Title);
            }
        }
    }
}

