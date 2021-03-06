Bouncing Ball

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:s="clr-namespace:System;assembly=mscorlib">


    <Ellipse Name="elips" Width="40" Height="40" Fill="Red" Canvas.Left="80">

        <Ellipse.Triggers>
            <EventTrigger RoutedEvent="Ellipse.Loaded">
                <BeginStoryboard>
                    <Storyboard TargetName="elips" 
                                TargetProperty="(Canvas.Top)"
                                RepeatBehavior="Forever">
                        <DoubleAnimationUsingKeyFrames>
                            <DiscreteDoubleKeyFrame KeyTime="0:0:0" Value="96" />
                            <SplineDoubleKeyFrame KeyTime="0:0:1" Value="480" 
                                                  KeySpline="0.25 0, 0.6 0.2" />
                            <SplineDoubleKeyFrame KeyTime="0:0:2" Value="96"
                                                  KeySpline="0.75 1, 0.4 0.8" />
                        </DoubleAnimationUsingKeyFrames>
                    </Storyboard>
                </BeginStoryboard>
            </EventTrigger>
        </Ellipse.Triggers>
    </Ellipse>
</Canvas>

