Button Click event handler

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ButtonClick" Height="250" Width="250">
    <Grid HorizontalAlignment="Center" VerticalAlignment="Center">
      
      <Button Click="ButtonClicked">Button</Button>
      
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


namespace WpfApplication1
{
    public partial class Window1 : System.Windows.Window
    {

        public Window1()
        {
            InitializeComponent();
        }
        void ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked");
        }
    }
}

