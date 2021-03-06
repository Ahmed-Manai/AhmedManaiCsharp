Query Left / Right Shift key

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="200" Width="240">
    <StackPanel HorizontalAlignment="Center">
        <UniformGrid Columns="2">
            <UniformGrid.Resources>
                <Style TargetType="{x:Type CheckBox}">
                    <Setter Property="IsHitTestVisible" Value="False" />
                    <Setter Property="Margin" Value="5" />
                </Style>
            </UniformGrid.Resources>

        </UniformGrid>
        <Button Content="Check Keyboard" Margin="10" Click="Button_Click"/>
    </StackPanel>
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
            CheckKeyboardState();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckKeyboardState();
        }
        private void CheckKeyboardState()
        {
            Console.WriteLine(Keyboard.IsKeyDown(Key.LeftShift));
            Console.WriteLine(Keyboard.IsKeyDown(Key.RightShift));
        }
    }
}

