TabControl and Frame source

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Opacity Masking Examples" >

  <TabControl>
    <TabItem Header="GradientBrush Example">
      <Frame Source="GradientBrushExample.xaml" />
    </TabItem>
    <TabItem Header="ImageBrush Example">
      <Frame Source="ImageBrushExample.xaml" />
    </TabItem>
    <TabItem Header="DrawingBrush Example">
      <Frame Source="DrawingBrushExample.xaml" />
    </TabItem>
  </TabControl>



</Window>

