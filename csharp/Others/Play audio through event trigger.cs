Play audio through event trigger

<Window x:Class="SoundAndVideo.SoundPlayerTest"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="SoundPlayerTest" Height="360" Width="660">
    <StackPanel>
        <Button>
        <Button.Content>Play Through Wrapper</Button.Content>
        <Button.Style>
          <Style>
            <Style.Triggers>
              <EventTrigger RoutedEvent="Button.Click">
                <EventTrigger.Actions>
                  <SoundPlayerAction Source="test.wav"></SoundPlayerAction>
                </EventTrigger.Actions>
              </EventTrigger>
            </Style.Triggers>
          </Style>
        </Button.Style>
      </Button>
    </StackPanel>
</Window>

