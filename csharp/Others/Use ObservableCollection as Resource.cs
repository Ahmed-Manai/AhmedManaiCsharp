Use ObservableCollection as Resource

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:src="clr-namespace:ListBoxEvent"  x:Class="ListBoxEvent.Pane1">
  <Canvas.Resources>
    <src:myColors x:Key="Colors"/>
  </Canvas.Resources>

  <StackPanel>
      <TextBox Name="tb" Width="150" Height="30"></TextBox>
      <ListBox Name="lb" Width="120" Height="60" SelectionChanged="PrintText" SelectionMode="Single">
        <ListBoxItem>Item 1</ListBoxItem>
        <ListBoxItem>Item 2</ListBoxItem>
        <ListBoxItem>Item 3</ListBoxItem>
        <ListBoxItem>Item 4</ListBoxItem>
        <ListBoxItem>Item 5</ListBoxItem>
        <ListBoxItem>Item 6</ListBoxItem>
        <ListBoxItem>Item 7</ListBoxItem>
        <ListBoxItem>Item 8</ListBoxItem>
        <ListBoxItem>Item 9</ListBoxItem>
        <ListBoxItem>Item 10</ListBoxItem>
      </ListBox>
  </StackPanel>

</Canvas>
//File:Window.xaml.cs

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace ListBoxEvent
{
    public class myColors : ObservableCollection<string>
    {
        public myColors()
        {
            Add("A");
            Add("B");
            Add("C");
            Add("D");
            Add("E");
            Add("F");
        }
    }
    public partial class Pane1 : Canvas
    {

        public Pane1() : base(){
            InitializeComponent();
        }
        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            tb.Text = "   You selected " + lbi.Content.ToString() + ".";
        }
    }
}

