Add items to combo box

using System;
using System.Drawing;
using System.Windows.Forms;
public class Select : Form {
  private Button draw = new Button();
  private ComboBox color = new ComboBox();

  public Select( ) {
    draw.Text = "Draw";
    color.Text = "Choose a color";
    Size = new Size(400,240);

    int w = 20;
    draw.Location = new Point(20,30);
    color.Location = new Point(w += 10 + color.Width, 30);

    color.Items.Add("Black");
    color.Items.Add("Red");
    color.Items.Add("Blue");

    Controls.Add(draw);
    Controls.Add(color);

    draw.Click += new EventHandler(Draw_Click);
  } 

  protected void Draw_Click(Object sender, EventArgs e) {
    if (color.SelectedItem.ToString() == "Red" )
      Console.WriteLine("It is red.");
    else if (color.SelectedItem.ToString() == "Red")
      Console.WriteLine("It is Red.");
    else
      Console.WriteLine("It is blue.");
  }
  static void Main() {
    Application.Run(new Select());
  }
}

