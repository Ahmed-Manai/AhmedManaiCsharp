WPF Threading

<Window x:Class="WPFThreading.BlockThread"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="UI Thread Blocker" Height="400" Width="300">
    <StackPanel>
      <Button Name="button1" Click="button1_click">Go to sleep</Button>
      <Button Name="button2" Click="button2_click">Try Me</Button>
      <TextBox Name="textbox1"/>
      <Label Name="UIThreadLabel"/>
      <Label Name="BackgroundThreadLabel"/>
    </StackPanel>
</Window>

//File:Window.xaml.cs

using System.Windows;

namespace WPFThreading
{
  public partial class BlockThread : System.Windows.Window
  {
    public BlockThread()
    {
      InitializeComponent();

      this.UIThreadLabel.Content = this.Dispatcher.Thread.ManagedThreadId;
      this.BackgroundThreadLabel.Content = "N/A";
    }

    private void button1_click(object sender, RoutedEventArgs e)
    {
      System.Threading.Thread.Sleep(5000);
      this.textbox1.Text = "Done Sleeping...";
    }

    private void button2_click(object sender, RoutedEventArgs e)
    {
      this.textbox1.Text = "I Love Clementine";
    }

  }
}

