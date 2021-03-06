Matrix3D scale transformation

<Window x:Class="WpfApplication1.Matrix3DTransforms"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Matrix3D Transformations" Height="400" Width="500">
  <StackPanel>
    <TextBlock Margin="8,8,5,5" Text="Original Matrix:" />
    <TextBlock Name="tbOriginal" Margin="25,0,4,4" />
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
            Matrix3D M = new Matrix3D(1, 4, 2, 1,
                                      2, 4, 4, 3,
                                      2, 2, 1, 0,
                                      1, 3, 0, 1);


            Matrix3D M1 = M;
            tbOriginal.Text = "(" + M.ToString() + ")";

            //Scale: 
            M.Scale(new Vector3D(0.5, 1.5, 2.5));
            tbResult.Text = "(" + M.ToString() + ")";

        }
    }
}

