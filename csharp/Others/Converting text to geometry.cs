Converting text to geometry

<Window x:Class="GlyphExamples.GlyphClipping"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Glyph Clipping" Height="400" Width="360">
    <Grid HorizontalAlignment="Center" VerticalAlignment="Center" Width="80">
      <Grid.LayoutTransform>
        <ScaleTransform ScaleX="3" ScaleY="3" />
      </Grid.LayoutTransform>
      <Button x:Name="button1" Content="Click" />
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
using System.Threading;

namespace GlyphExamples
{
    public partial class GlyphClipping : System.Windows.Window
    {
        public GlyphClipping()
        {
            InitializeComponent();
            FormattedText text = new FormattedText("CLIP!",
                Thread.CurrentThread.CurrentUICulture,
                FlowDirection.LeftToRight,
                new Typeface("Gill Sans Ultra Bold"),
                20,
                Brushes.Black);

            Geometry textGeometry = text.BuildGeometry(new Point(0, 0));
            button1.Clip = textGeometry;
        }
    }
}

