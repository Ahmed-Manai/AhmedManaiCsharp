Create an animated Popup control

<Window x:Class="SDKSample.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="AnimatedPopup">
  <StackPanel>
    <CheckBox Name="myCheckBox" Margin="25,25,0,0" Content="Select CheckBox to see Popup"/>
    <Button HorizontalAlignment="Left" Width="240" Margin="20,10,0,0">
      <Button.Triggers>
        <EventTrigger RoutedEvent="Button.Click">
          <BeginStoryboard>
            <Storyboard>
              <DoubleAnimation 
                Storyboard.TargetName="theTransform"
                Storyboard.TargetProperty="(RotateTransform.Angle)" 
                From="0" To="360" Duration="0:0:5" AutoReverse="True"/>
            </Storyboard>
          </BeginStoryboard>
        </EventTrigger>
      </Button.Triggers>
      Click to see the Popup animate
    </Button>


  </StackPanel>
</Window>

