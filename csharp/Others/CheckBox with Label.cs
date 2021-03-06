CheckBox with Label

using System;
using System.Drawing;
using System.Windows.Forms;
   
class CheckBoxWithLabel: Form
{
     Label label;
     FontStyle   fs   = 0;
     FontStyle[] afs  = { FontStyle.Bold,FontStyle.Italic, FontStyle.Underline, FontStyle.Strikeout };
   
     public static void Main()
     {
          Application.Run(new CheckBoxWithLabel());
     }
     public CheckBoxWithLabel()
     {
          int      cyText   = Font.Height;
          int      cxText   = cyText / 2;
          string[] astrText = {"Bold", "Italic", "Underline", "Strikeout"};
   
          label = new Label();
          label.Parent   = this;
          label.Text     = "Sample Text";
          label.AutoSize = true;
   
          for (int j = 0; j < 4; j++)
          {
               CheckBox chkbox = new CheckBox();
               chkbox.Parent = this;
               chkbox.Text = astrText[j];
               chkbox.Location = new Point(2 * cxText, (4 + 3 * j) * cyText / 2);
               chkbox.Size = new Size(12 * cxText, cyText);
               chkbox.CheckedChanged += new EventHandler(CheckBoxOnCheckedChanged);
          }
     }
     void CheckBoxOnCheckedChanged(object obj, EventArgs ea)
     {
          for (int j = 0; j < 4; j++)
               if (((CheckBox) Controls[j + 1]).Checked)
                    fs |= afs[j];
   
          label.Font = new Font(label.Font, fs);
     }
}

