Add child control

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="ElemCollMethods.Pane1"
    WindowTitle="UI Element Collection Methods Example">
 <StackPanel>
    <TextBlock Name="txt" FontSize="18">UI Element Collection - Methods</TextBlock>

    <TabControl>
        <TabItem MouseLeftButtonUp="AddButton">
            <TabItem.Header>Add Control</TabItem.Header>
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

    void AddButton(object sender, MouseButtonEventArgs e)
    {
      sp1.Children.Clear();
      btn = new Button();
      btn.Content = "New Button";
      sp1.Children.Add(btn);
    }
  }
}

