Code Animation Accelerate Decelerate

<Window x:Class="SimpleCodeAnimation.AccelerateDecelerate"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Acceleration and Deceleration" Height="400" Width="400">
    <Grid>
      <Ellipse Name="myEllipse" Fill="Red" Height="80" Width="12" />
    </Grid>
</Window>
//File:Window.xaml.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace SimpleCodeAnimation
{
    public partial class AccelerateDecelerate : System.Windows.Window
    {
        public AccelerateDecelerate()
        {
            InitializeComponent();
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            DoubleAnimation animate = new DoubleAnimation();
            animate.By = 100;
            animate.Duration = new Duration(TimeSpan.FromSeconds(3));

            animate.AccelerationRatio = 0.2;
            animate.DecelerationRatio = 0.1;

            myEllipse.BeginAnimation(Ellipse.WidthProperty, animate);
        }
    }
}

