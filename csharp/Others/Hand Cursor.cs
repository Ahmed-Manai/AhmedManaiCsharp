Hand Cursor

using System.Drawing;
using System.Windows.Forms;
   
class FormProperties
{
     public static void Main()
     {
          Form form = new Form();
   
          form.Text            = "Form Properties";
          form.Cursor          = Cursors.Hand;
   
          Application.Run(form);
     }
}

