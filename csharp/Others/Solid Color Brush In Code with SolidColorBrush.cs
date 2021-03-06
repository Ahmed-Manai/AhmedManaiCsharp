Solid Color Brush In Code with SolidColorBrush

<Window x:Class="WPFBrushes.SolidColorBrushInCode"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPFBrushes" Height="360" Width="500"
    >
    <Grid>
        
    </Grid>
</Window>
//File:Window.xaml.cs
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFBrushes
{
  public partial class SolidColorBrushInCode : System.Windows.Window
  {
    public SolidColorBrushInCode()
    {
      InitializeComponent();
      this.Width = 600;

      StackPanel sp = new StackPanel();
      sp.Margin = new Thickness(4.0);
      sp.HorizontalAlignment = HorizontalAlignment.Left;
      sp.Orientation = Orientation.Vertical;

      TextBlock tb1 = new TextBlock(new Run(@"Brush from Predefined Color [ .Fill = new SolidColorBrush(Colors.Green); ]"));
      Rectangle rect1 = new Rectangle();
      rect1.HorizontalAlignment = HorizontalAlignment.Left;
      rect1.Width = 80;
      rect1.Height = 25;
      rect1.Fill = new SolidColorBrush(Colors.Green);

      sp.Children.Add(tb1);
      sp.Children.Add(rect1);

      this.Content = sp;

    }

  }
}

