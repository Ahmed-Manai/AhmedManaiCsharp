Insert Button to a Panel

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="ElemCollMethods.Pane1"
    WindowTitle="UI Element Collection Methods Sample">
 <StackPanel>
    <TextBlock Name="txt" FontSize="18">UI Element Collection - Methods</TextBlock>

    <TabControl>
    
        <TabItem MouseLeftButtonUp="InsertButton">
            <TabItem.Header>Insert Control</TabItem.Header>
        </TabItem>
    </TabControl>
    <StackPanel Name="sp1"></StackPanel>

 </StackPanel>
</Page>


//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Windows.Input;

namespace ElemCollMethods
{

  public partial class Pane1 : Page
  {
    System.Windows.Controls.Button btn, btn1, btn2, btn3;

    void InsertButton(object sender, MouseButtonEventArgs e)
    {
            sp1.Children.Clear();
            btn = new Button();
      btn.Content = "Click to insert button";
            sp1.Children.Add(btn);
            btn.Click += (InsertControls);
      btn1 = new Button();
      btn1.Content = "Click to insert button";
            sp1.Children.Add(btn1);
            btn1.Click += (InsertControls);
    }
    void InsertControls(object sender, RoutedEventArgs e)
    {
      btn2 = new Button();
      btn2.Content = "Inserted Button";
            sp1.Children.Insert(1, btn2);
        }
  }
}

