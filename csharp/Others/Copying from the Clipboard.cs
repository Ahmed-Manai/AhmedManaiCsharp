Copying from the Clipboard

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
public class MainClass {


    public static void Main(string[] args) {

        IDataObject iData = Clipboard.GetDataObject();

        if (iData.GetDataPresent(DataFormats.Text)) {
            Console.WriteLine((String)iData.GetData(DataFormats.Text));
        }
        if (iData.GetDataPresent(DataFormats.Bitmap)) {
            Image img = (Bitmap)iData.GetData(DataFormats.Bitmap);

        }
    }
}

