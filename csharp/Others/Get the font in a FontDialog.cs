Get the font in a FontDialog

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


public class MainClass {
    private FontDialog fontDlg = new FontDialog();
    private Font currFont = new Font("Arial", 16);

    public static void Main() {
        FontDialog fontDlg = new FontDialog();
        if (fontDlg.ShowDialog() != DialogResult.Cancel) {
            Console.WriteLine(fontDlg.Font);
        }
    }
}

