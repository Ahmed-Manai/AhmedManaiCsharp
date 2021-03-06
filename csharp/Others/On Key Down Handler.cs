On Key Down Handler

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="KeyDown Sample" Height="360" Width="660">
  <StackPanel>
    <TextBlock Width="330" Height="25">
      Type some text into the TextBox and press the Enter key.
    </TextBlock>
    <TextBox Width="330" Height="40" Name="textBox1"
             KeyDown="OnKeyDownHandler"/>
    <TextBlock Width="330" Height="90" Name="textBlock1"/>
  </StackPanel>
</Window>

//File:Window.xaml.cs

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace WpfApplication1
{
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                textBlock1.Text = "You Entered: " + textBox1.Text;
            }
        }
    }
}

