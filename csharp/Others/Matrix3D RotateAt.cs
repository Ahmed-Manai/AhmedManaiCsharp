Matrix3D RotateAt

<Window x:Class="WpfApplication1.Matrix3DTransforms"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Matrix3D Transformations" Height="400" Width="600">
  <StackPanel>
    <TextBlock Margin="8,8,5,5" Text="Original Matrix:" />
    <TextBlock Name="tbOriginal" Margin="25,0,4,4" />
    <TextBlock Margin="8,0,5,5" Text="Scale:" />
    <TextBlock Name="tbResult" Margin="25,0,4,4" />

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
            Matrix3D M = new Matrix3D(1, 4, 2, 4,
                                      4, 1, 0, 1,
                                      0, 0, 1, 0,
                                      1, 3, 3, 1);


            tbOriginal.Text = "(" + M.ToString() + ")";

            //Translation: 
            M.RotateAt(new Quaternion(new Vector3D(1, 2, 3), 45),new Point3D(15, 25, 40));
            tbResult.Text = "(" + M.ToString() + ")";
        }
    }
}

