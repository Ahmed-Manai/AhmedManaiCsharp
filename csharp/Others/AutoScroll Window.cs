AutoScroll Window

  using System;
  using System.Drawing;
  using System.Collections;
  using System.ComponentModel;
  using System.Windows.Forms;
  using System.Data;

  public class Form1 : System.Windows.Forms.Form
  {
    private Button myButton; 

    public Form1()
    {
      this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
      this.ClientSize = new System.Drawing.Size(240, 280);
        
            this.AutoScroll=true;

      myButton = new Button();
      myButton.Text = "Superman";
      myButton.Location = new System.Drawing.Point(66, 36);
      myButton.Size = new System.Drawing.Size(160, 75);
 
      Controls.Add(myButton);
    }

    static void Main() 
    {
      Application.Run(new Form1());
    }
  }

