Use Popup to display a hyperlink

<Window x:Class="ClassicControls.PopupTest"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="PopupTest" Height="360" Width="400">
    <Grid Margin="10">
      <TextBlock TextWrapping="Wrap">text 
         <Run TextDecorations="Underline" MouseEnter="run_MouseEnter">link</Run>
      </TextBlock>
      <Popup Name="popLink" StaysOpen="False" Placement="Mouse" MaxWidth="240" PopupAnimation="Slide" AllowsTransparency = "True">
        <Border BorderBrush="Beige" BorderThickness="2" Background="White">
          <TextBlock Margin="10"  TextWrapping="Wrap" >
            check out
            <Hyperlink NavigateUri="http://happycodings.com" Click="lnk_Click">happycodings.com</Hyperlink>
          </TextBlock>
        </Border>
      </Popup>
    </Grid>
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
using System.Diagnostics;

namespace ClassicControls
{
    public partial class PopupTest : System.Windows.Window
    {

        public PopupTest()
        {
            InitializeComponent();
        }

        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}

