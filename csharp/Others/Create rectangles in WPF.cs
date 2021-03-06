Create rectangles in WPF

<Window x:Class="RectangleShape"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Rectangles" Height="360" Width="250">
  <Grid>
    <StackPanel>
      <TextBlock Text="RadiusX = 0, RadiusY = 0:"
        Margin="8 8 8 5" />
      <Rectangle Width="150" Height="70" Fill="LightGray"
        Stroke="Red" />
      <TextBlock Text="RadiusX = 20, RadiusY = 10:"
        Margin="8 8 8 5" />
      <Rectangle Width="150" Height="70" RadiusX="20" RadiusY="10"
        Fill="LightGray" Stroke="Red" />
      <TextBlock Text="RadiusX = 75, RadiusY = 35:"
        Margin="8 8 8 5" />
      <Rectangle Width="120" Height="80" RadiusX="75" RadiusY="35"
        Fill="LightGray" Stroke="Red" />
    </StackPanel>
  </Grid>
</Window>

