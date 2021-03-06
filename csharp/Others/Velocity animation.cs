Velocity animation

<Page x:Class="Microsoft.Samples.PerFrameAnimations.FrameIndependentFollowExample"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

  <Canvas x:Name="containerCanvas" Background="Transparent">
    <Rectangle x:Name="followRectangle" Canvas.Left="0" Canvas.Top="0" 
      Fill="blue" Width="60" Height="60" />
  </Canvas>
</Page>
//File:Window.xaml.cs


using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace Microsoft.Samples.PerFrameAnimations
{
    public partial class FrameIndependentFollowExample : Page
    {
        private Vector _rectangleVelocity = new Vector(0, 0);
        private Point _lastMousePosition = new Point(450, 450);

        private TimeSpan _lastRender;

        public FrameIndependentFollowExample(): base()
        {
            _lastRender = TimeSpan.FromTicks(DateTime.Now.Ticks);
            CompositionTarget.Rendering += UpdateRectangle;
        }

        private void UpdateRectangle(object sender, EventArgs e)
        {
            RenderingEventArgs renderArgs = (RenderingEventArgs)e;
            Double deltaTime = (renderArgs.RenderingTime - _lastRender).TotalSeconds;
            _lastRender = renderArgs.RenderingTime;

            Point location = new Point(0,0);

            Vector toMouse = _lastMousePosition - location;

            double followForce = 1.00;
            _rectangleVelocity += toMouse * followForce;

            double drag = 0.9;
            _rectangleVelocity *= drag;

            location += _rectangleVelocity * deltaTime;

            Canvas.SetLeft(followRectangle, location.X);
            Canvas.SetTop(followRectangle, location.Y);
        }
    }
}

