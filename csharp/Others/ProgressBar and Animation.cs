ProgressBar and Animation

<Window x:Class="Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="UseProgressBar" Height="160" Width="360">
    <Grid>
        <ProgressBar Height="23" Name="prgTime" VerticalAlignment="Bottom" />
        <Button Height="24" Margin="90,16,90,0" Name="btnStart" VerticalAlignment="Top" Content="Start">
            <Button.Triggers>
                <EventTrigger RoutedEvent="Button.Click">
                    <EventTrigger.Actions>
                        <BeginStoryboard>
                            <Storyboard Duration="5">
                                <DoubleAnimation Storyboard.TargetName="prgTime"
                                    Storyboard.TargetProperty="Value"
                                    Duration="0:0:5" 
                                    From="0"
To="100" />
                                <DoubleAnimation Storyboard.TargetName="prgTime"
                                    Storyboard.TargetProperty="Value"
                                    BeginTime="0:0:6"
                                    Duration="0:0:0" 
                                    From="100"
To="0" />
                            </Storyboard>
                        </BeginStoryboard>
                    </EventTrigger.Actions>
                </EventTrigger>
            </Button.Triggers>
        </Button>
    </Grid>
</Window>

