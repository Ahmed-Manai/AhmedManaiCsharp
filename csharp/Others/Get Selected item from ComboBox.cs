Get Selected item from ComboBox

using System;
using System.Drawing;
using System.Windows.Forms;
public class Select : Form {
  private Button draw = new Button();
  private ComboBox color = new ComboBox();

  public Select( ) {
    draw.Text = "Draw";
    color.Text = "Choose a color";
    Size = new Size(600,300);

    int w = 20;
    draw.Location = new Point(30,40);
    color.Location = new Point(w += 10 + color.Width, 30);

    color.Items.Add("Red");
    color.Items.Add("Green");
    color.Items.Add("Blue");

    Controls.Add(draw);
    Controls.Add(color);

    draw.Click += new EventHandler(Draw_Click);
  } 

  protected void Draw_Click(Object sender, EventArgs e) {
    if (color.SelectedItem.ToString() == "Red" )
      Console.WriteLine("It is red.");
    else if (color.SelectedItem.ToString() == "Green")
      Console.WriteLine("It is green.");
    else
      Console.WriteLine("It is blue.");
  }
  static void Main() {
    Application.Run(new Select());
  }
}

