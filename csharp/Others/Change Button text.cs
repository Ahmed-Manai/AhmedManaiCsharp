Change Button text

using System;
using System.Windows.Forms;
using System.Drawing;

public class PushMe2 : Form {

  Button pushMeButton;

  public PushMe2() {
    pushMeButton = new Button(); 
    pushMeButton.Text = "Push Me";
    pushMeButton.Height = 50;
    pushMeButton.Width = 96;
    pushMeButton.Top = 70;
    pushMeButton.Left = 70;

    pushMeButton.Click += new EventHandler(ButtonClicked);

    this.Controls.Add(pushMeButton);

    this.Height = 250;
    this.Width = 250;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Visible = true;
  }

  public void ButtonClicked(object source, EventArgs e) {
    Button b = (Button)source;
    if ( b.Text == "Push Me" ) {
      b.Text = "Ouch";
    }
    else {
      b.Text = "Push Me";
    }
  }

  static void Main() {
    Application.Run(new PushMe2());
  }
}

