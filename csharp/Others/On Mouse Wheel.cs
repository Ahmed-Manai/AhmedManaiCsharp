On Mouse Wheel

using System;
using System.Drawing;
using System.Windows.Forms;
   
class PoePoem: Form
{
     public static void Main()
     {
          if (!SystemInformation.MouseWheelPresent)
          {
               Console.WriteLine("needs a mouse with a mouse wheel!");
               return;
          }
          Application.Run(new PoePoem());
     }
     public PoePoem()
     {

     }
     protected override void OnMouseWheel(MouseEventArgs mea)
     {
          Console.WriteLine(mea.Delta);
   
     }
}

