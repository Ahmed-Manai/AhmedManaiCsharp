Dynamic Resource

<Window x:Class="Resources.DynamicResource"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Resources" Height="250" Width="400"
    >
  <Window.Resources>
    <ImageBrush x:Key="TileBrush" x:Name="DynamicBrush" TileMode="Tile"
                ViewportUnits="Absolute" Viewport="0 0 32 32"
                ImageSource="c:\image.jpg"></ImageBrush>
  </Window.Resources>
  <StackPanel Margin="5">
    <Button Background="{DynamicResource TileBrush}" >Button</Button>
    <Button Click="cmdChange_Click" >Change the Brush</Button>
  </StackPanel>
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

namespace Resources
{
    public partial class DynamicResource : System.Windows.Window
    {
        public DynamicResource()
        {
            InitializeComponent();
        }

        private void cmdChange_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["TileBrush"] = new SolidColorBrush(Colors.LightBlue);
            
            ImageBrush brush = (ImageBrush)this.Resources["TileBrush"];
            brush.Viewport = new Rect(0, 0, 8, 8);            
        }
    }
}

