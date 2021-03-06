Use LengthConverter

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="Canvas_Positioning_Properties.Window1"
    Title="Canvas Positioning Properties">
  <StackPanel>
    <Canvas Name="canvas1" Height="360">
        <TextBlock Name="text1" FontWeight="Bold" Canvas.Left="0" Canvas.Right="0" Canvas.Top="0" Canvas.Bottom="0">I Love Clementine</TextBlock>
  </Canvas>
    <ListBox Grid.Column="3" Grid.Row="1" VerticalAlignment="Top" Width="60" Margin="10,0,0,0" SelectionChanged="ChangeLeft">

      <ListBoxItem>Auto</ListBoxItem>      
      <ListBoxItem>a</ListBoxItem>
      <ListBoxItem>b</ListBoxItem>
      <ListBoxItem>c</ListBoxItem>
      <ListBoxItem>d</ListBoxItem>
      <ListBoxItem>e</ListBoxItem>
      <ListBoxItem>f</ListBoxItem>
      <ListBoxItem>g</ListBoxItem>
      <ListBoxItem>h</ListBoxItem>
      <ListBoxItem>i</ListBoxItem>
      <ListBoxItem>j</ListBoxItem>      
    </ListBox>
  </StackPanel>        
</Window>
//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace Canvas_Positioning_Properties
{

  public partial class Window1 : Window
  {
    public void ChangeLeft(object sender, SelectionChangedEventArgs args)
    {
      ListBoxItem li = ((sender as ListBox).SelectedItem as ListBoxItem);
      LengthConverter myLengthConverter = new LengthConverter();
      Double db1 = (Double)myLengthConverter.ConvertFromString(li.Content.ToString());
      Canvas.SetLeft(text1, db1);
      Console.WriteLine(myLengthConverter.ConvertToString(Canvas.GetLeft(text1)));
    }


  }
}

