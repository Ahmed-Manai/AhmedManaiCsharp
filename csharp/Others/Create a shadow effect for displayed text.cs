Create a shadow effect for displayed text

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="SDKSample.Window1" Title="Text Shadow"
  Background="FloralWhite">
  <StackPanel>
      <TextBlock FontSize="80" Text="Shadow Text" Foreground="Teal">
        <TextBlock.BitmapEffect>
          <DropShadowBitmapEffect ShadowDepth="6" Direction="320" Color="Red" Opacity="0.5" Softness="0.25" />
        </TextBlock.BitmapEffect>
      </TextBlock>
  </StackPanel>
</Window>

