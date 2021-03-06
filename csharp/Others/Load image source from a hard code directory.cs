Load image source from a hard code directory

<Window x:Class="AssemblyResources.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="AssemblyResources" Height="400" Width="600">
    <StackPanel>      
      <Button Click="cmdPlay_Click" Padding="5">Play</Button>
      <Image Name="img" Source="c:\image.jpg"></Image>
      <MediaElement Name="Sound" Source="c:\sound.wav" LoadedBehavior="Manual"></MediaElement>
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
using System.Reflection;
using System.Resources;
using System.IO;
using System.Globalization;
using System.Windows.Resources;

namespace AssemblyResources
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void cmdPlay_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("file:///c:/image.jpg", UriKind.Relative));
            Sound.Stop();
            Sound.Play();
        }
    }
}

