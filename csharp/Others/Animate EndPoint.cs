Animate EndPoint

<Window x:Class="Main"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="" Height="250" Width="250">
  <Grid>
    <Path Stroke="Black" StrokeThickness="1">
      <Path.Data>
        <GeometryGroup>
          <LineGeometry x:Name="line1" StartPoint="25,25" EndPoint="250,36" />
        </GeometryGroup>
      </Path.Data>
      <Path.Triggers>
        <EventTrigger RoutedEvent="Path.Loaded">
          <BeginStoryboard>
            <Storyboard AutoReverse="True" RepeatBehavior="Forever">
              <PointAnimation To="40,20" 
                              Storyboard.TargetName="line1" 
                              Storyboard.TargetProperty="EndPoint" />
            </Storyboard>
          </BeginStoryboard>
        </EventTrigger>
      </Path.Triggers>
    </Path>
  </Grid>
</Window>

