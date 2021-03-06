Draw Graphics On Bitmap

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

    public class DrawGraphicsOnBitmap : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new DrawGraphicsOnBitmap());
        }
        public DrawGraphicsOnBitmap()
        {
            Background = Brushes.Khaki;
            RenderTargetBitmap renderbitmap = new RenderTargetBitmap(80, 80, 60, 60, PixelFormats.Default);
            DrawingVisual drawvis = new DrawingVisual();
            DrawingContext dc = drawvis.RenderOpen();
            dc.DrawRoundedRectangle(Brushes.Blue, new Pen(Brushes.Red, 10),new Rect(20, 20, 60, 60), 10, 10);
            dc.Close();
            renderbitmap.Render(drawvis);
            Image img = new Image();
            img.Source = renderbitmap;

            Content = img;
        }
    }

