Hard shadow on top of soft shadow

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="SDKSample.Window1" Title="Text Shadow"
  Background="White">
  <StackPanel>

      <TextBlock FontSize="72" Text="Superman" Foreground="Blue">
        <TextBlock.BitmapEffect>
          <BitmapEffectGroup>
            <DropShadowBitmapEffect ShadowDepth="5" Direction="320" Color="Orange"
              Opacity="0.75"
              Softness="0.50" />
            <DropShadowBitmapEffect
              ShadowDepth="2"
              Direction="320"
              Color="Red"
              Opacity="0.5"
              Softness="0.0" />
          </BitmapEffectGroup>
        </TextBlock.BitmapEffect>
      </TextBlock>


  </StackPanel>
</Window>

