Window On Mouse up event

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="MouseInput" Height="400" Width="400">
    <Grid>
      <Ellipse Fill="Red" x:Name="myEllipse" />
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
using System.Diagnostics;


namespace WpfApplication1
{
    public partial class Window1 : System.Windows.Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void StartSlowWork()
        {
            Mouse.OverrideCursor = Cursors.AppStarting;
        }

        private void SlowWorkCompleted()
        {
            Mouse.OverrideCursor = null;
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Source != myEllipse)
            {
                StartSlowWork();
            }
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);
            SlowWorkCompleted();
        }

    }
}

