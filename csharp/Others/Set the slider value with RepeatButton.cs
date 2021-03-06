Set the slider value with RepeatButton

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="120" Width="240">
    <StackPanel>
        <Slider Name="slider" Maximum="100" Minimum="0" Value="60" />
        <StackPanel Orientation="Horizontal">
            <RepeatButton Click="SliderLeft_Click" Content="Click Me" 
                          Height="24" Margin="8" Width="80" 
                          ToolTip="Click to move slider left" />
            <RepeatButton Click="SliderRight_Click" ClickMode="Hover" 
                          Content="Touch Me" Height="24" Margin="8" 
                          ToolTip="Hover to move slider right" Width="70" />
        </StackPanel>
    </StackPanel>
</Window>
//File:Window.xaml.cs
using System.Windows;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void SliderLeft_Click(object sender, RoutedEventArgs e)
        {
            slider.Value -= 1;
        }

        private void SliderRight_Click(object sender, RoutedEventArgs e)
        {
            slider.Value += 1;
        }
    }
}

