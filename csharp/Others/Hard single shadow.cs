Hard single shadow

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="SDKSample.Window1" Title="Text Shadow"
  Background="White">
  <StackPanel>
      <TextBlock
        FontSize="72"
        Text="Superman"
        Foreground="Blue"
        Grid.Column="1" Grid.Row="1">
        <TextBlock.BitmapEffect>
          <DropShadowBitmapEffect
            ShadowDepth="6"
            Direction="135"
            Color="Blue"
            Opacity="0.35"
            Softness="0.0" />
        </TextBlock.BitmapEffect>
      </TextBlock>


  </StackPanel>
</Window>

