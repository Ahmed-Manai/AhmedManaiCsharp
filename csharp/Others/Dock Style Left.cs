Dock Style: Left

  using System;
  using System.Drawing;
  using System.Collections;
  using System.ComponentModel;
  using System.Windows.Forms;
  using System.Data;

  public class AnchorForm : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Button button1;

    public AnchorForm()
    {
      InitializeComponent();
      CenterToScreen();
    }
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.Controls.AddRange(new System.Windows.Forms.Control[] {this.button1});
      this.Text = "Anchoring (and Docking) Controls";
      
            // dock Left

      button1.Dock = DockStyle.Left;
      button1.Text = "Anchor: " + button1.Anchor.ToString() + 
        "\nDock: " + button1.Dock.ToString();
    }
    static void Main() 
    {
      Application.Run(new AnchorForm());
    }

  }

