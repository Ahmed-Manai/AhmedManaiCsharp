Shadow effect by creating an outer glow

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="SDKSample.Window1" Title="Text Shadow"
  Background="FloralWhite">
  <StackPanel>

      <TextBlock FontSize="90" Text="{Binding Path=Text, ElementName=textblockMaster}"
        Foreground="Blue" Grid.Column="1" Grid.Row="4">
        <TextBlock.BitmapEffect>
          <OuterGlowBitmapEffect
            GlowSize="1.0"
            GlowColor="Red"
            Opacity="1.0"/>
        </TextBlock.BitmapEffect>
      </TextBlock>

  </StackPanel>
</Window>

