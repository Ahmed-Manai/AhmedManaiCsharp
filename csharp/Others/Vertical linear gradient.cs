Vertical linear gradient

<Window x:Class="WpfApplication1.LinearGradientBrushExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="LinearGradientBrush" Height="400" Width="320">
    <StackPanel>
      <TextBlock Margin="4" Text="Vertical linear gradient:" />
      <Rectangle Width="120" Height="80" Stroke="Red">
        <Rectangle.Fill>
          <LinearGradientBrush StartPoint="0,0" EndPoint="1,0">
            <GradientStop Color="Black" Offset="0" />
            <GradientStop Color="Blue" Offset="1" />
          </LinearGradientBrush>
        </Rectangle.Fill>
      </Rectangle>
    </StackPanel>
</Window>

