Create Button from Xaml string

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="DynamicXAML" Height="250" Width="250">
  <Grid Name="grid1" HorizontalAlignment="Center" VerticalAlignment="Center"/>
</Window>
//File:Window.xaml.cs

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Markup;
using System.Xml;
using System.IO;

namespace WpfApplication1
{

  public partial class Window1 : System.Windows.Window
  {

    public Window1()
    {
      InitializeComponent();

      StringReader sr = new StringReader(@"<Button xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
        Foreground='BurlyWood' FontSize='20pt'>Click Me!</Button>");

      XmlReader reader = XmlReader.Create(sr);

      Button dynamicButton = (Button)XamlReader.Load(reader);

      this.grid1.Children.Add(dynamicButton);

      dynamicButton.Click += button1_Click;
   
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Dynamic Button Loaded From XAML String");
    }

  }
}

