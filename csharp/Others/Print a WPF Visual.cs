Print a WPF Visual

<Window x:Class="WpfApplication1.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Title="Window1">
  <Grid>
    <Grid x:Name="VisualRoot">
      <Ellipse Fill="Aqua" Height="360" Width="660" HorizontalAlignment="Center" VerticalAlignment="Center"/>
      <TextBlock Text="A Printed Visual" HorizontalAlignment="Center" VerticalAlignment="Center"/>
    </Grid>
    <Button Click="btnPrintVisual_Click" Content="Print" VerticalAlignment="Bottom"/>
  </Grid>
</Window>
//File:Window.xaml.cs
using System;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Xps;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void btnPrintVisual_Click(object sender, RoutedEventArgs e)
        {
            Visual visual = new Grid();
            
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() != true)
            {
                return;
            }
            PrintQueue pq = printDialog.PrintQueue;
            Visual scaledVisual = ScaleVisual(visual, pq);
            
            XpsDocumentWriter xpsdw = PrintQueue.CreateXpsDocumentWriter(pq);

            xpsdw.Write(scaledVisual);
        }
        private Visual ScaleVisual(Visual v, PrintQueue pq)
        {
            ContainerVisual root = new ContainerVisual();
            const double inch = 96;

            double xMargin = 180;
            double yMargin = 200;

            PrintTicket pt = pq.UserPrintTicket;
            double printableWidth = pt.PageMediaSize.Width.Value;
            double printableHeight = pt.PageMediaSize.Height.Value;
            Console.WriteLine(printableWidth);
            Console.WriteLine(printableHeight);
            
            double xScale = 2;
            double yScale = 3;

            root.Children.Add(v);
            root.Transform = new MatrixTransform(xScale, 0, 0, yScale, xMargin, yMargin);

            return root;
        }
    }
}

