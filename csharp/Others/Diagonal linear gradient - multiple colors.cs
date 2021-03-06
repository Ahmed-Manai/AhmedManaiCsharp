Diagonal linear gradient - multiple colors

<Window x:Class="WpfApplication1.LinearGradientBrushExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="LinearGradientBrush" Height="450" Width="360">
    <StackPanel Grid.Column="0" Grid.Row="2">
      <TextBlock Margin="4,10,4,0"
        Text="Vertical linear gradient" />
      <TextBlock Margin="4,0,4,5" Text="- multiple colors" />
      <Rectangle Width="120" Height="80" Stroke="Black">
        <Rectangle.Fill>
          <LinearGradientBrush StartPoint="0,0"
            EndPoint="1,0">
            <GradientStop Color="Red" Offset="0.3" />
            <GradientStop Color="Green" Offset="0.5" />
            <GradientStop Color="Blue" Offset="0.8" />
          </LinearGradientBrush>
        </Rectangle.Fill>
      </Rectangle>
    </StackPanel>
</Window>

