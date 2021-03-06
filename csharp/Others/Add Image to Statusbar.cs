Add Image to Statusbar

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="StatusBarSimple.Window1"
    Title ="StatusBar">
  <Window.Resources>
    <Style x:Key="StatusBarSeparatorStyle" TargetType="Separator">
      <Setter Property="Background" Value="LightBlue" />
      <Setter Property="Control.Width" Value="1"/>
      <Setter Property="Control.Height" Value="20"/>
    </Style>    
  </Window.Resources>
        <StatusBar Name="sbar" Grid.Column="0" Grid.Row="2" Grid.ColumnSpan="2" 
                   VerticalAlignment="Bottom" Background="Beige" > 
             <StatusBarItem>
                <Button Content="click" Click="MakeProgressBar"/>
             </StatusBarItem>
             <StatusBarItem>
               <Separator Style="{StaticResource StatusBarSeparatorStyle}"/>
             </StatusBarItem>
        </StatusBar>
</Window>
//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StatusBarSimple
{
    public partial class Window1 : Window
    {
        private void MakeProgressBar(object sender, RoutedEventArgs e)
        {
            sbar.Items.Clear();
            DockPanel dpanel = new DockPanel();
            TextBlock txtb = new TextBlock();
            txtb.Text = "Printing  ";
            dpanel.Children.Add(txtb);
            Image printImage = new Image();
            printImage.Width = 20;
            printImage.Height = 20;
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"pack://application:,,,/images/print.bmp");
            bi.EndInit();
            printImage.Source = bi;
            dpanel.Children.Add(printImage);
            TextBlock txtb2 = new TextBlock();
            txtb2.Text = "  5pgs";
            dpanel.Children.Add(txtb2);
            StatusBarItem sbi = new StatusBarItem();
            sbi.Content = dpanel;
            sbi.HorizontalAlignment = HorizontalAlignment.Right;
            ToolTip ttp = new ToolTip();
            ttp.Content = "Sent to printer.";
            sbi.ToolTip = (ttp);
            sbar.Items.Add(sbi);
        }
    }
}
