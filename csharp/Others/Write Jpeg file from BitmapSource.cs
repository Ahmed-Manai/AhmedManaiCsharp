Write Jpeg file from BitmapSource

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using System.IO;

    class UseBitmapCodecs
    {
        static void WriteJpeg(string fileName, int quality, BitmapSource bmp)
        {

            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            BitmapFrame outputFrame = BitmapFrame.Create(bmp);
            encoder.Frames.Add(outputFrame);
            encoder.QualityLevel = quality;

            using (FileStream file = File.OpenWrite(fileName))
            {
                encoder.Save(file);
            }
        }
    }

