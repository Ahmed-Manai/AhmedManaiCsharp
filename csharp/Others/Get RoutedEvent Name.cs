Get RoutedEvent Name

<Window
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="WpfApplication1.Window1"
    Title="Routed Events" Height="360" Width="750">
  
    <Grid Name="contentGrid" Background="Red">
        <Rectangle Name="clickMeRectangle" 
                   Height="90" 
                   Width="90" 
                   Stroke="Black" 
                   Fill="CadetBlue" />
        <Button Name="clickMeButton" 
                Height="24" 
                HorizontalAlignment="Right" 
                VerticalAlignment="Top" 
                Width="70" 
                PreviewMouseDown="Generic_MouseDown" 
                Click="clickMeButton_Click">Click Me</Button>
        <TextBlock Name="outputText" />
    </Grid>
</Window>

//File:Window.xaml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        private void Generic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(outputText.Text);
            Console.WriteLine(e.RoutedEvent.Name);
            Console.WriteLine(sender.ToString());
            Console.WriteLine(((FrameworkElement)e.Source).Name);
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            outputText.Text = outputText.Text;
        }

        private void clickMeButton_Click(object sender, RoutedEventArgs e)
        {
            outputText.Text = "Button clicked:" + outputText.Text;
        }
    }
}

