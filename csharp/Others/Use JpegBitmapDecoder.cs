Use JpegBitmapDecoder

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using System.IO;

    class UseBitmapCodecs
    {
        static string GetCamera(string myJpegPath)
        {
            JpegBitmapDecoder decoder = new JpegBitmapDecoder(new Uri(myJpegPath),BitmapCreateOptions.None, BitmapCacheOption.None);
            BitmapMetadata bmpData = (BitmapMetadata) decoder.Frames[0].Metadata;
            return bmpData.CameraModel;
        }
    }

