ListBox with Image item

<Window x:Class="ClassicControls.ImageList"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ImageList" Height="360" Width="450">
  <ListBox Margin="4" SelectionMode="Multiple" Name="lst"  SelectionChanged="lst_SelectionChanged">
    <StackPanel Orientation="Horizontal">
      <Image Source="c:\image.jpg"  Width="25" Height="25"></Image>
      <Label VerticalContentAlignment="Center">A happy face</Label>
    </StackPanel>

  </ListBox>
</Window>
//File:Window.xaml.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClassicControls
{
    public partial class ImageList : System.Windows.Window
    {
        public ImageList()
        {
            InitializeComponent();
        }
        private void lst_SelectionChanged(object sender, RoutedEventArgs e)
        {
        }
    }
}

