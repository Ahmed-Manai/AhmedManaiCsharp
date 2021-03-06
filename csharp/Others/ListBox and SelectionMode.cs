ListBox and SelectionMode

<Window x:Class="ControlDemos.listbox"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ControlDemos" Height="360" Width="500" >
    <Grid Background="Cyan">
      <ListBox BorderThickness="1" 
               VerticalAlignment="Stretch" 
               HorizontalAlignment="Stretch" 
               Grid.Column="0" Grid.ColumnSpan="1" 
               Grid.Row="0" Grid.RowSpan="1" 
               Name="listBox1" BorderBrush="Blue"
               SelectionMode="Single"
               SelectionChanged="listBox1_SelectionChanged">
        <ListBoxItem>Item 1</ListBoxItem>
        <ListBoxItem>Item 2</ListBoxItem>
        <ListBoxItem>Item 3</ListBoxItem>
        <ListBoxItem>Item 4</ListBoxItem>
        <ListBoxItem>Item 5</ListBoxItem>
        <ListBoxItem>Item 6</ListBoxItem>
        <ListBoxItem>Item 7</ListBoxItem>
        <ListBoxItem>Item 8</ListBoxItem>
        
      </ListBox>
    </Grid>
</Window>
//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlDemos
{
    public partial class listbox : Window
    {
        public listbox()
        {
            InitializeComponent();
        }
        public void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            int nCount = listBox1.SelectedItems.Count;
            for (int lp = 0; lp < nCount; lp++)
                Console.WriteLine(listBox1.SelectedItems[lp].ToString());
        }
    }
}

