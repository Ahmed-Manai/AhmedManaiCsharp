Create a ProgressBar

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="ProgBar.Window1"
    Title ="ProgressBar"
    Width="640">

  <StackPanel>
    <Button Content="One" Click="MakeOne"/>
    <StatusBar Name="sbar" Grid.Column="0" Grid.Row="5" VerticalAlignment="Bottom" Background="Beige" >
      <StatusBarItem>
        <TextBlock>StatusBar</TextBlock>
      </StatusBarItem>
    </StatusBar>
  </StackPanel>
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



namespace ProgBar
{

    public partial class Window1 : Window
    {
        
        private void MakeOne(object sender, RoutedEventArgs e)
        {
           sbar.Items.Clear();
           Label lbl = new Label();
           lbl.Background = new LinearGradientBrush(Colors.LightBlue, Colors.SlateBlue, 90);
           lbl.Content = "ProgressBar with one iteration.";
           sbar.Items.Add(lbl);

           ProgressBar progbar = new ProgressBar();
           progbar.IsIndeterminate = false;
           progbar.Orientation = Orientation.Horizontal;
           progbar.Width = 180;
           progbar.Height = 20;
           Duration duration = new Duration(TimeSpan.FromSeconds(10));
           DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
           progbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);

           sbar.Items.Add(progbar);
          } 

     }
}

