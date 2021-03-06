Create RoutedCommand from InputGestureCollection

<Window x:Class="Commands.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Commands">
<Grid>
    <Button VerticalAlignment="Top" 
      HorizontalAlignment="Stretch" 
      Height="30" 
      Click="ExecuteCommandClickEvent" 
      Name="BtnExecuteCommand">Execute Command
  </Button>
  
  </Grid>
</Window>

//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Commands
{
    public partial class Window1 : Window
    {
       
        RoutedCommand myCmd;

        Window1()
        {
            InputGestureCollection myInputs = new InputGestureCollection();
            myInputs.Add(new KeyGesture(Key.G,ModifierKeys.Control | ModifierKeys.Shift));
            myCmd = new RoutedCommand("Go", typeof(Window1), myInputs);
        }

        private void ExecuteCommandClickEvent(object sender, RoutedEventArgs e)
        {
            myCmd.Execute(sender,null);
        }
    }
}

