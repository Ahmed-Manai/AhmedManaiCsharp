Play mp3 file

<Window x:Class="SoundAndVideo.MultipleSounds"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="MultipleSounds" Height="360" Width="660">
    <Grid>
      <Grid.RowDefinitions>
        <RowDefinition></RowDefinition>
        <RowDefinition></RowDefinition>
      </Grid.RowDefinitions>
      <MediaElement x:Name="media1" Volume="0.25"></MediaElement>
      <MediaElement x:Name="media2" Volume="1"></MediaElement>
      <Button>
        <Button.Content>Click.</Button.Content>
        <Button.Triggers>
          <EventTrigger RoutedEvent="Button.Click">
            <EventTrigger.Actions>
            <BeginStoryboard>
              <Storyboard>
                <MediaTimeline Source="c:\song.mp3" Storyboard.TargetName="media1"></MediaTimeline>
              </Storyboard>
            </BeginStoryboard>
            </EventTrigger.Actions>
          </EventTrigger>
        </Button.Triggers>
      </Button>

      <Button Grid.Row="1">
        <Button.Content >wav</Button.Content>
        <Button.Triggers>
          <EventTrigger RoutedEvent="Button.Click">
            <EventTrigger.Actions>
              <BeginStoryboard>
                <Storyboard>
                  <MediaTimeline Source="c:\song.wav" Storyboard.TargetName="media2"></MediaTimeline>
                </Storyboard>
              </BeginStoryboard>
            </EventTrigger.Actions>
          </EventTrigger>
        </Button.Triggers>
      </Button>
    </Grid>
</Window>

