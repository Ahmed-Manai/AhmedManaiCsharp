BorderLess Window

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
      this.ClientSize = new System.Drawing.Size(280, 320);
        
            this.ControlBox=false;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.FormBorderStyle=FormBorderStyle.None;

      myButton = new Button();
      myButton.Text = "Superman";
      myButton.Location = new System.Drawing.Point(69, 36);
      myButton.Size = new System.Drawing.Size(180, 50);
 
            myButton.Click+=new EventHandler(Close_Window);        
      
      Controls.Add(myButton);
    }
        public void Close_Window(object sender,EventArgs eArgs) {
           ((Form)((Button)sender).Parent).Close();
        }

    static void Main() 
    {
      Application.Run(new Form1());
    }
  }

