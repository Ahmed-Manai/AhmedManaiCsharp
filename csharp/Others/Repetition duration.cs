Repetition duration

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">

    <Ellipse Fill="Aqua" Width="220" Height="120">
      <Ellipse.Triggers>
        <EventTrigger RoutedEvent="Ellipse.Loaded">
          <BeginStoryboard>
            <Storyboard>
    
                <DoubleAnimation By="20" Duration="0:0:0.25"
                                 Storyboard.TargetProperty="(Ellipse.Width)"
                                 RepeatBehavior="0:0:2" />
                
    
    
            </Storyboard>
          </BeginStoryboard>
        </EventTrigger>
      </Ellipse.Triggers>
    </Ellipse>

</Page>

