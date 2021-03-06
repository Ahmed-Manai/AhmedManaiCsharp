Controlling The Storyboard

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <StackPanel>
        <Canvas Width="360" Height="240">
            <Rectangle Canvas.Left="120" Canvas.Top="60" Fill="Aqua" Width="60" Height="180">
                <Rectangle.RenderTransform>
                    <TransformGroup>
                        <RotateTransform x:Name="xform1" Angle="-90" CenterX="0" CenterY="150" />
                    </TransformGroup>
                </Rectangle.RenderTransform>
            </Rectangle>
        </Canvas>

        <StackPanel Orientation="Horizontal" HorizontalAlignment="Center">
            <Button Name="btnBegin" Content="Begin" />
            <Button Name="btnPause" Content="Pause" />
            <Button Name="btnResume" Content="Resume" />
            <Button Name="btnStop" Content="Stop" />
            <Button Name="btnSkip" Content="Skip to End" />
            <Button Name="btnCenter" Content="Skip to Center" />
        </StackPanel>

        <StackPanel.Triggers>
            <EventTrigger SourceName="btnBegin" RoutedEvent="Button.Click">
                <BeginStoryboard Name="storybrd">
                    <Storyboard >
                        <DoubleAnimation 
                            Storyboard.TargetName="xform1"
                            Storyboard.TargetProperty="Angle"
                            From="-90" To="0" Duration="0:0:5" />
                    </Storyboard>
                </BeginStoryboard>
            </EventTrigger>

            <EventTrigger SourceName="btnPause" RoutedEvent="Button.Click">
                <PauseStoryboard BeginStoryboardName="storybrd" />
            </EventTrigger>

            <EventTrigger SourceName="btnResume" RoutedEvent="Button.Click">
                <ResumeStoryboard BeginStoryboardName="storybrd" />
            </EventTrigger>

            <EventTrigger SourceName="btnStop" RoutedEvent="Button.Click">
                <StopStoryboard BeginStoryboardName="storybrd" />
            </EventTrigger>

            <EventTrigger SourceName="btnSkip" RoutedEvent="Button.Click">
                <SkipStoryboardToFill BeginStoryboardName="storybrd" />
            </EventTrigger>

            <EventTrigger SourceName="btnCenter" RoutedEvent="Button.Click">
                <SeekStoryboard BeginStoryboardName="storybrd"
                                Offset="0:0:5" />
            </EventTrigger>

        </StackPanel.Triggers>
    </StackPanel>
</Page>

