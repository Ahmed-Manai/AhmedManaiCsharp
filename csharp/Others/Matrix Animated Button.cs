Matrix Animated Button

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Canvas.Resources>
        <PathGeometry x:Key="path"
                      Figures="M 0 0 C 320 0, 500 400, 800 200
                               S 0 300 500 576 S 400 700 400 200" />
    </Canvas.Resources>

    <Path Stroke="Black" Data="{StaticResource path}" />

    <Button>
        Button
        <Button.RenderTransform>
            <MatrixTransform x:Name="xform" />
        </Button.RenderTransform>
    </Button>

    <Canvas.Triggers>
        <EventTrigger RoutedEvent="Canvas.Loaded">
            <BeginStoryboard>
                <Storyboard RepeatBehavior="Forever">
                    <MatrixAnimationUsingPath 
                        Storyboard.TargetName="xform"
                        Storyboard.TargetProperty="Matrix"
                        Duration="0:0:10" 
                        PathGeometry="{StaticResource path}"
                        DoesRotateWithTangent="True" />
                </Storyboard>
            </BeginStoryboard>
        </EventTrigger>
    </Canvas.Triggers>
</Canvas>

