Insert Row

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="WpfApplication1.Window1"
    Title="ColumnDefinitions Sample">
    <Border BorderBrush="Blue" Background="White" BorderThickness="2">
  <DockPanel Margin="10,0,0,0">
    <TextBlock FontSize="18" FontWeight="Bold" DockPanel.Dock="Top">Grid Column and Row Collections</TextBlock>
        <Grid DockPanel.Dock="Top" HorizontalAlignment="Left" Name="grid1" ShowGridLines="true" Width="700" Height="360">
          <Grid.ColumnDefinitions>
            <ColumnDefinition/>
            <ColumnDefinition/>
            <ColumnDefinition/>
          </Grid.ColumnDefinitions>
          <Grid.RowDefinitions>
          <RowDefinition/>
            <RowDefinition/>
            <RowDefinition/>
          </Grid.RowDefinitions>
        </Grid>

        <StackPanel HorizontalAlignment="Left" Orientation="Horizontal" Width="600" DockPanel.Dock="Top">
            <Button Width="140" Click="insertRowAt">Insert Row</Button>
        </StackPanel>    

  </DockPanel>
  </Border>  
</Window>

//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        RowDefinition rowDef1;
        ColumnDefinition colDef1;


        private void insertRowAt(object sender, RoutedEventArgs e)
        {
            rowDef1 = new RowDefinition();
            grid1.RowDefinitions.Insert(grid1.RowDefinitions.Count, rowDef1);
            Console.WriteLine(grid1.RowDefinitions.IndexOf(rowDef1).ToString());
        }
    }
}

