Mouse Enter and leave a Border

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="mouseEnterLeave" Height="500" Width="750">

  <StackPanel>
    <Border MouseEnter="OnMouseEnterHandler"
            MouseLeave="OnMouseLeaveHandler"
            Name="border1" Margin="8"
            BorderThickness="1"
            BorderBrush="Black"
            VerticalAlignment="Center"
            Width="400" Height="500">
      <Label Margin="8" FontSize="25"
             HorizontalAlignment="Center">Move Cursor Over Me</Label>
    </Border>
  </StackPanel>
</Window>


//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            border1.Background = Brushes.Red;
        }
        void OnMouseLeaveHandler(object sender, MouseEventArgs e)
        {
            border1.Background = Brushes.White;
        }
    }
 
}

