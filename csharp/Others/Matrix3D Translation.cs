Matrix3D Translation

<Window x:Class="WpfApplication1.Matrix3DTransforms"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Matrix3D Transformations" Height="500" Width="600">
  <StackPanel>
    <TextBlock Margin="8,8,5,5" Text="Original Matrix:" />
    <TextBlock Name="tbOriginal" Margin="25,0,5,5" />
    <TextBlock Margin="8,0,5,5" Text="Scale:" />
    <TextBlock Name="tbResult" Margin="20,0,5,5" />

  </StackPanel>
</Window>

//File:Window.xaml.cs
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace WpfApplication1
{
    public partial class Matrix3DTransforms : Window
    {
        public Matrix3DTransforms()
        {
            InitializeComponent();
            Matrix3D M = new Matrix3D(1, 4, 3, 0,
                                      2, 2, 4, 0,
                                      0, 0, 4, 0,
                                      1, 3, 3, 1);


            tbOriginal.Text = "(" + M.ToString() + ")";

            //Translation: 
            M.Translate(new Vector3D(120, 200, 250));
            tbResult.Text = "(" + M.ToString() + ")";

        }
    }
}

