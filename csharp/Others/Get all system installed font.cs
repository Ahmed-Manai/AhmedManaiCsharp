Get all system installed font

  using System;
  using System.Drawing;
  using System.Drawing.Text;
  using System.Collections;
  using System.ComponentModel;
  using System.Windows.Forms;
  using System.Data;


  public class Test{
    static void Main() 
    {
      InstalledFontCollection fonts = new InstalledFontCollection();
      for(int j = 0; j < fonts.Families.Length; j++)
      {
        Console.WriteLine(fonts.Families[j].Name);
      }
    }
  }

