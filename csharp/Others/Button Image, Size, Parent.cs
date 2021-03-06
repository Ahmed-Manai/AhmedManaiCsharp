Button Image, Size, Parent

using System;
using System.Drawing;
using System.Windows.Forms;
   
class BitmapButtons: Form
{
     int    cxBtn, cyBtn, dxBtn;
     Button btnLarger, btnSmaller;
   
     public static void Main()
     {
          Application.Run(new BitmapButtons());
     }
     public BitmapButtons()
     {
          ResizeRedraw = true;
   
          dxBtn = Font.Height;
          btnLarger = new Button();
          btnLarger.Parent = this;
          btnLarger.Image  = new Bitmap(GetType(), "LargerButton.bmp") ;
   
          cxBtn = btnLarger.Image.Width  + 8;
          cyBtn = btnLarger.Image.Height + 8;
   
          btnLarger.Size   = new Size(cxBtn, cyBtn);
          btnLarger.Click += new EventHandler(ButtonLargerOnClick);
   
          btnSmaller = new Button();
          btnSmaller.Parent = this;
          btnSmaller.Image  = new Bitmap(GetType(), "SmallerButton.bmp");
          btnSmaller.Size   = new Size(cxBtn, cyBtn);
          btnSmaller.Click += new EventHandler(ButtonSmallerOnClick);
   
          OnResize(EventArgs.Empty);
     }
     protected override void OnResize(EventArgs ea)
     {
          base.OnResize(ea);
   
          btnLarger.Location = new Point(ClientSize.Width / 2 - cxBtn - dxBtn / 2,
                                  (ClientSize.Height - cyBtn) / 2);
          btnSmaller.Location = new Point(ClientSize.Width / 2 + dxBtn / 2,
                                  (ClientSize.Height - cyBtn) / 2);
     }
     void ButtonLargerOnClick(object obj, EventArgs ea)
     {
          Left   = 40;
          Top    = 40;
          Width  = 40;
          Height = 40;
     }
     void ButtonSmallerOnClick(object obj, EventArgs ea)
     {
          Left   = 240;
          Top    = 240;
          Width  = 25;
          Height = 25;
     }
}

