Non-resizable form

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
      this.ClientSize = new System.Drawing.Size(301, 188);
        
            this.MaximumSize=new Size(240,240);
            this.MinimumSize=new Size(240,240);

      myButton = new Button();
      myButton.Text = "www.happycodings.com";
      myButton.Location = new System.Drawing.Point(69, 36);
      myButton.Size = new System.Drawing.Size(180, 45);

      Controls.Add(myButton);
    }
    static void Main() 
    {
      Application.Run(new Form1());
    }
  }

