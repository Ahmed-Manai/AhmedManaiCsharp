Skew the text using a TranslateTransform

<Window x:Class="SDKSample.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="Text Transform Samples"
  Background="Blue"
  Height="700">

    <StackPanel>

      <TextBlock FontSize="32" FontWeight="Bold"  Foreground="Black" Text="I Love Clementine" Margin="100, 0, 0, 0">
        <TextBlock.RenderTransform>
          <TranslateTransform X="2" Y="2" />
        </TextBlock.RenderTransform>
      </TextBlock>

    </StackPanel>
</Window>

