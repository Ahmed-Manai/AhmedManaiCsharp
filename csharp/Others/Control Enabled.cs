Control Enabled

using System;
using System.Drawing;
using System.Windows.Forms;

class MainWindow : Form {
    private TextBox firstNameBox = new TextBox();
    private Button btnShowControls = new Button();

    public MainWindow() {
        this.Text = "Simple Controls";
        this.Width = 360;
        this.Height = 240;
        CenterToScreen();

        firstNameBox.Text = "Superman";
        firstNameBox.Size = new Size(120, 60);
        firstNameBox.Location = new Point(10, 10);
        this.Controls.Add(firstNameBox);

        btnShowControls.Text = "Click Me";
        btnShowControls.Size = new Size(90, 30);
        btnShowControls.Location = new Point(10, 70);
        btnShowControls.BackColor = Color.DodgerBlue;
        btnShowControls.Click += new EventHandler(btnShowControls_Clicked);
        this.Controls.Add(btnShowControls);
    }

    private void btnShowControls_Clicked(object sender, EventArgs e) {
        string ctrlInfo = "";
        foreach (Control c in this.Controls) {
            ctrlInfo += string.Format("Control: {0}\n",c.ToString());
        }
        MessageBox.Show(ctrlInfo, "Controls on Form");
        DisableAllButtons();
    }

    private void DisableAllButtons() {
        foreach (Control c in this.Controls) {
            if (c is Button)
                ((Button)c).Enabled = false;
        }
    }
    public static void Main(string[] args) {
        Application.Run(new MainWindow());
    }
}

