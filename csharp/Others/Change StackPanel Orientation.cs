Change StackPanel Orientation

<Window x:Class="LayoutPanels.SimpleStack"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="SimpleStack" Height="240" Width="360" MinWidth="50">
  <StackPanel Margin="4" Name="stackPanel1">
    <Label Margin="3" HorizontalAlignment="Center">
      A Button Stack
    </Label>
    <Button Margin="3" MaxWidth="240" MinWidth="80">Button 1</Button>
    <Button Margin="3" MaxWidth="240" MinWidth="80">Button 2</Button>
    <Button Margin="3" MaxWidth="240" MinWidth="80">Button 3</Button>
    <Button Margin="3" MaxWidth="240" MinWidth="80">Button 4</Button>

    <CheckBox Name="chkVertical" Margin="10" HorizontalAlignment="Center"
     Checked="chkVertical_Checked" Unchecked="chkVertical_Unchecked">
      Use Vertical Orientation</CheckBox>            
  </StackPanel>
</Window>



//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LayoutPanels
{
    public partial class SimpleStack : Window
    {

        public SimpleStack()
        {
            InitializeComponent();
        }

        private void chkVertical_Checked(object sender, RoutedEventArgs e)
        {
            stackPanel1.Orientation = Orientation.Horizontal;
        }

        private void chkVertical_Unchecked(object sender, RoutedEventArgs e)
        {
            stackPanel1.Orientation = Orientation.Vertical;
        }
    }
}

