Repetition count

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">

    <Ellipse Fill="Aqua" Width="240" Height="120">
      <Ellipse.Triggers>
        <EventTrigger RoutedEvent="Ellipse.Loaded">
          <BeginStoryboard>
            <Storyboard>
    
                
                <ColorAnimation From="Aqua" To="Yellow" Duration="0:0:1"
                                Storyboard.TargetProperty="(Ellipse.Fill).(SolidColorBrush.Color)"
                                RepeatBehavior="3x" />
                
    
    
            </Storyboard>
          </BeginStoryboard>
        </EventTrigger>
      </Ellipse.Triggers>
    </Ellipse>

</Page>

