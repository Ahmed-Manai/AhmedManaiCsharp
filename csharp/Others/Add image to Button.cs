Add image to Button

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class Form1 : Form
{
    private System.Windows.Forms.Button button1;

  public Form1() {
        InitializeComponent();
  }

    private void InitializeComponent()
    {
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.button1.Image = new Bitmap("Sun.jpg");
        this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
        this.button1.Location = new System.Drawing.Point(13, 96);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(120, 69);
        this.button1.TabIndex = 1;
        this.button1.Text = "button1";
        this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.button1.UseVisualStyleBackColor = true;
 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(320, 250);

        this.Controls.Add(this.button1);
        this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Name = "ImagesInCommonControls";
        this.Text = "ImagesInCommonControls";
        this.ResumeLayout(false);

    }

  [STAThread]
  static void Main()
  {
    Application.EnableVisualStyles();
    Application.Run(new Form1());
  }

}
