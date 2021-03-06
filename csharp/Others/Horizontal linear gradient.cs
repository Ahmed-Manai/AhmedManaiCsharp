Horizontal linear gradient

<Window x:Class="WpfApplication1.LinearGradientBrushExample"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="LinearGradientBrush" Height="400" Width="450">
    <StackPanel Grid.Column="1" Grid.Row="0">
      <TextBlock Margin="4" Text="Horizontal linear gradient:" />
      <Rectangle Width="120" Height="90" Stroke="Maroon">
        <Rectangle.Fill>
          <LinearGradientBrush StartPoint="0,0"
            EndPoint="0,1">
            <GradientStop Color="Red" Offset="0" />
            <GradientStop Color="White" Offset="1" />
          </LinearGradientBrush>
        </Rectangle.Fill>
      </Rectangle>
    </StackPanel>
</Window>

