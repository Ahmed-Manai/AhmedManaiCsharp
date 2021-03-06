Print Custom Page

<Window x:Class="Printing.PrintCustomPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="PrintCustomPage" Height="360" Width="550">
    <StackPanel>
      <TextBox Name="txtContent" Margin="4" TextWrapping="Wrap" VerticalScrollBarVisibility="Visible">
        this is a test
      </TextBox>
      <Button Grid.Row="1" Margin="3" Padding="5" Click="cmdPrint_Click" VerticalAlignment="Top">Print</Button>
    </StackPanel>
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
using System.Globalization;

namespace Printing
{
    public partial class PrintCustomPage : System.Windows.Window
    {
        public PrintCustomPage()
        {
            InitializeComponent();
        }
        private void cmdPrint_Click(object sender, RoutedEventArgs e)
        {           
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                DrawingVisual visual = new DrawingVisual();
                using (DrawingContext dc = visual.RenderOpen())
                {
                    FormattedText text = new FormattedText(txtContent.Text,
                        CultureInfo.CurrentCulture, FlowDirection.LeftToRight,
                        new Typeface("Calibri"), 20, Brushes.Black);

                    text.MaxTextWidth = printDialog.PrintableAreaWidth / 2;
                    Point point = new Point(80,80);

                    dc.DrawText(text, point);

                    dc.DrawRectangle(null, new Pen(Brushes.Black, 1),
                        new Rect(180, 180, 60,60));
                }

                printDialog.PrintVisual(visual, "A Printed Page");
            }
        }
    }
}

