Copying to the Clipboard

  using System;
  using System.Drawing;
  using System.Collections;
  using System.ComponentModel;
  using System.Data;
  using System.Windows.Forms;
  
  public class MainClass
  {
    public static void Main(string[] args)
    {
        Clipboard.SetDataObject("data");
    }
  }

