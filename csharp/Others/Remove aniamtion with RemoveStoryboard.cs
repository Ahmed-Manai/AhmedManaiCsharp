Remove aniamtion with RemoveStoryboard

<Window x:Class="Wpf1Application.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="" Height="450" Width="550">
  <Window.Resources>
    <Storyboard x:Key="Storyboard1">
      <ParallelTimeline>
        <DoubleAnimation x:Name="Animation1" Storyboard.TargetProperty="Width" From="150" To="60"
          AutoReverse="True" RepeatBehavior="Forever" />
        <DoubleAnimation Storyboard.TargetProperty="Opacity" To="0.5" AutoReverse="True" RepeatBehavior="Forever" />
      </ParallelTimeline>
    </Storyboard>
  </Window.Resources>

  <UniformGrid>
    <Button Margin="5" Content="Method 1">
      <Button.Triggers>
        <EventTrigger RoutedEvent="Button.Loaded">
          <BeginStoryboard Storyboard="{DynamicResource Storyboard1}" x:Name="BeginStoryboard1" />
        </EventTrigger>
        <EventTrigger RoutedEvent="Button.Click">
          <RemoveStoryboard BeginStoryboardName="BeginStoryboard1" />
        </EventTrigger>
      </Button.Triggers>
    </Button>
  </UniformGrid>
</Window>

