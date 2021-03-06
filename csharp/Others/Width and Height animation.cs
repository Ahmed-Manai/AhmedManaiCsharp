Width and Height animation

<Window x:Class="_360Timer.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Concentric Rings" Width="800" Height="500">
  <Canvas Name="MainCanvas" Background="#FF44CC"/>
</Window>
//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace _360Timer
{

    public partial class Window1 : Window
    {
         public Window1()
        {
            InitializeComponent();

            this.Show();

            for (int i = 0; i < 24; ++i)
            {
                Ellipse e = new Ellipse();
                e.Stroke = new SolidColorBrush(Color.FromArgb(4 2, 240, 240));
                e.StrokeThickness = 20;
                e.Width = 16.0;
                e.Height = 32.0;

                this.MainCanvas.Children.Add(e);                

                e.SetValue(Canvas.LeftProperty, 300);
                e.SetValue(Canvas.TopProperty, 400);

                double duration = 6.0 ;
                double delay = 1.0 ;

                DoubleAnimation sizeAnimation = new DoubleAnimation(0.0, 512.0, new Duration(TimeSpan.FromSeconds(duration)));
                sizeAnimation.RepeatBehavior = RepeatBehavior.Forever;
                sizeAnimation.BeginTime = TimeSpan.FromSeconds(delay);
                e.BeginAnimation(Ellipse.WidthProperty, sizeAnimation);
                e.BeginAnimation(Ellipse.HeightProperty, sizeAnimation);


            }
        }
    }
}

