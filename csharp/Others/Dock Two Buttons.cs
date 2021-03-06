Dock Two Buttons

using System;
using System.Drawing;
using System.Windows.Forms;
   
class TwoButtonsDock: Form
{
     public static void Main()
     {
          Application.Run(new TwoButtonsDock());
     }
     public TwoButtonsDock()
     {
          ResizeRedraw = true;
   
          Button btn = new Button();
          btn.Parent = this;
          btn.Text   = "&Larger";
          btn.Height = 2 * Font.Height;
          btn.Dock   = DockStyle.Top;
          btn.Click += new EventHandler(ButtonLargerOnClick);
          
          btn = new Button();
          btn.Parent = this;
          btn.Text   = "&Smaller";
          btn.Height = 2 * Font.Height;
          btn.Dock   = DockStyle.Bottom;
          btn.Click += new EventHandler(ButtonSmallerOnClick);
     }
     void ButtonLargerOnClick(object obj, EventArgs ea)
     {
          Console.WriteLine("large");
     }
     void ButtonSmallerOnClick(object obj, EventArgs ea)
     {
          Console.WriteLine("small");
     }
}

