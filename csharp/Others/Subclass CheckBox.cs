Subclass CheckBox

using System;
using System.Drawing;
using System.Windows.Forms;
   
class CustomCheckBox: Form
{
     public static void Main()
     {
          Application.Run(new CustomCheckBox());
     }
     public CustomCheckBox()
     {
          int      cyText = Font.Height;
          int      cxText = cyText / 2;
          FontStyle[] afs = { FontStyle.Bold,      FontStyle.Italic, 
                              FontStyle.Underline, FontStyle.Strikeout };
   
          Label label    = new Label();
          label.Parent   = this;
          label.Text     = "I Love Clementine";
          label.AutoSize = true;
   
          for (int j = 0; j < 4; j++)
          {
               FontStyleCheckBox chkbox = new FontStyleCheckBox();
               chkbox.Parent = this;
               chkbox.Text = afs[j].ToString();
               chkbox.fontstyle = afs[j];
               chkbox.Location = new Point(2 * cxText, 
                                               (4 + 3 * j) * cyText / 2);
               chkbox.Size = new Size(12 * cxText, cyText);
               chkbox.CheckedChanged += new EventHandler(CheckBoxOnCheckedChanged);
          }
     }
     void CheckBoxOnCheckedChanged(object obj, EventArgs ea)
     {
          FontStyle fs = 0;
          Label     label = null;
   
          for (int j = 0; j < Controls.Count; j++)
          {
               Control ctrl = Controls[j];
   
               if (ctrl.GetType() == typeof(Label))
                    label = (Label) ctrl;
               else if (ctrl.GetType() == typeof(FontStyleCheckBox))
                    if (((FontStyleCheckBox) ctrl).Checked)
                         fs |= ((FontStyleCheckBox) ctrl).fontstyle;
          }
          label.Font = new Font(label.Font, fs);
     }
}
class FontStyleCheckBox: CheckBox
{
     public FontStyle fontstyle;
}

