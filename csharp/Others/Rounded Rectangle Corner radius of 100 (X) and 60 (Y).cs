Rounded Rectangle Corner radius of 100 (X) and 60 (Y)

<Window x:Class="Drawing.RoundedRectangles"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="RoundedRectangles" Height="500" Width="400"
    >
  <StackPanel>


    <TextBlock Margin="4,4,0,0">Corner radius of 100 (X) and 60 (Y).</TextBlock>
    <Rectangle Fill="Yellow" Stroke="Aqua" RadiusX="100" RadiusY="60"
               Width="100" Height="60" Margin="4"  HorizontalAlignment="Left"></Rectangle>
  </StackPanel>
</Window>

