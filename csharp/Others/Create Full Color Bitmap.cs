Create Full Color Bitmap

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

    public class CreateFullColorBitmap : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new CreateFullColorBitmap());
        }
        public CreateFullColorBitmap()
        {
            int[] array = new int[256 * 256];

            for (int x = 0; x < 256; x++)
            for (int j = 0; j < 256; j++)
            {
                int b = x;
                int g = 0;
                int r = j;

                array[256 * j + x] = b | (g << 8) | (r << 16);
            }
            BitmapSource bitmap=  BitmapSource.Create(256, 256, 96, 96, PixelFormats.Bgr32,
                                    null, array, 256 * 4);

            Image img = new Image();
            img.Source = bitmap;

            Content = img;
        }
    }

