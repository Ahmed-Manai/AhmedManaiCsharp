A hierarchy of timelines

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">


<StackPanel Orientation="Horizontal" VerticalAlignment="Center">
  <StackPanel.Triggers>
    <EventTrigger RoutedEvent="StackPanel.Loaded">
      <BeginStoryboard>
        <Storyboard>
          <ParallelTimeline RepeatBehavior="Forever">

            <DoubleAnimation BeginTime="0:0:0" Duration="0:0:0.2"
                Storyboard.TargetName="mybutton1"
                Storyboard.TargetProperty="(Button.Height)"
                By="30" AutoReverse="True" />

            <DoubleAnimation BeginTime="0:0:1" Duration="0:0:0.2"
                Storyboard.TargetName="mybutton2"
                Storyboard.TargetProperty="(Button.Height)"
                By="30" AutoReverse="True" />

            <ParallelTimeline BeginTime="0:0:2">

            <DoubleAnimation BeginTime="0:0:0" Duration="0:0:0.2"
                  Storyboard.TargetName="mybutton3"
                  Storyboard.TargetProperty="(Button.Height)"
                  By="30" AutoReverse="True" />


            </ParallelTimeline>

          </ParallelTimeline>
        </Storyboard>
      </BeginStoryboard>
    </EventTrigger>
  </StackPanel.Triggers>

  <Button Name="mybutton1" Height="25">One</Button>
  <Button Name="mybutton2" Height="25">Two</Button>
  <Button Name="mybutton3" Height="25">Three</Button>
</StackPanel>

</Page>

