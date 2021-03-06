Anchor Two Buttons

using System;
using System.Drawing;
using System.Windows.Forms;
   
class TwoButtonsAnchor: Form
{
     public static void Main()
     {
          Application.Run(new TwoButtonsAnchor());
     }
     public TwoButtonsAnchor()
     {
          ResizeRedraw = true;
   
          int cxBtn = 5 * Font.Height;
          int cyBtn = 2 * Font.Height;
          int dxBtn =     Font.Height;
   
          Button btn = new Button();
          btn.Parent   = this;
          btn.Text     = "&Larger";
          btn.Location = new Point(dxBtn, dxBtn);
          btn.Size     = new Size(cxBtn, cyBtn);
          btn.Click   += new EventHandler(ButtonLargerOnClick);
          
          btn = new Button();
          btn.Parent   = this;
          btn.Text     = "&Smaller";
          btn.Location = new Point(ClientSize.Width  - cxBtn - dxBtn,
                                   ClientSize.Height - cyBtn - dxBtn);
          btn.Size     = new Size(cxBtn, cyBtn);
          btn.Anchor   = AnchorStyles.Right | AnchorStyles.Bottom;
          btn.Click   += new EventHandler(ButtonSmallerOnClick);
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

