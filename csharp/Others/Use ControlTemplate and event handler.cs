Use ControlTemplate and event handler

<Window x:Class="ControlTemplate.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="ControlTemplate" Height="360" Width="500">
  <Window.Resources>
    <ControlTemplate x:Key="customizeButton" TargetType="{x:Type Button}">
      <Grid>
        <Ellipse Width="120" Height="120" Fill="Cyan" 
          Stroke="Red" StrokeThickness="2"/>
        <ContentPresenter VerticalAlignment="Center"
          HorizontalAlignment="Center"></ContentPresenter>
      </Grid>
    </ControlTemplate>
  </Window.Resources>
  <Grid HorizontalAlignment="Center" VerticalAlignment="Center">
    <Button Name="button1" Template="{StaticResource customizeButton}"  
      Foreground="White" Click="button1_Click">Press Me!</Button>
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


namespace ControlTemplate
{
  public partial class Window1 : System.Windows.Window
  {

    public Window1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("I Love Clementine");
    }

  }
}

