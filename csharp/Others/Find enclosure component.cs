Find enclosure component

<Window x:Class="VisualTree.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="VisualTree" Height="250" Width="400">
  <Grid>      
      <Button Click="MyClickEvent" Name="btnGo">
        <TextBox Width="180" Height="30" Name="txt">
        </TextBox>        
      </Button>      
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

namespace VisualTree
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        void MyClickEvent(object sender, RoutedEventArgs e)
        {
            object desiredNode = btnGo.FindName("txt");
            if (desiredNode is TextBox)
            {
                TextBox desiredChild = desiredNode as TextBox;
                desiredChild.Background = Brushes.Green;
            }
        }

    }
}

