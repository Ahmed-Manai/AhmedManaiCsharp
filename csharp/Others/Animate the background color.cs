Animate the background color

<Window x:Class="Main"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="" Height="250" Width="250"
  Background="Black">
  <Window.Triggers>
    <EventTrigger RoutedEvent="Window.Loaded">
      <BeginStoryboard>
        <Storyboard AutoReverse="True" RepeatBehavior="Forever">
          <ColorAnimation Storyboard.TargetProperty="Background.Color" To="Red" />
          <ColorAnimation Storyboard.TargetName="rect" Storyboard.TargetProperty="(Shape.Fill).(SolidColorBrush.Color)" To="Firebrick" />
        </Storyboard>
      </BeginStoryboard>
    </EventTrigger>
  </Window.Triggers>
  <Rectangle x:Name="rect" Width="120" Height="120" Fill="WhiteSmoke" />
</Window>

