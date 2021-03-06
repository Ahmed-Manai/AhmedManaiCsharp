Shaking Button

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <StackPanel.Resources>
        <Style TargetType="{x:Type Button}">
            <Setter Property="HorizontalAlignment" Value="Center" />
            <Setter Property="Margin" Value="15" />
            <Setter Property="RenderTransformOrigin" Value="0.5 0.5" />
            <Setter Property="RenderTransform">
                <Setter.Value>
                    <RotateTransform />
                </Setter.Value>
            </Setter>
            <Style.Triggers>
                <EventTrigger RoutedEvent="Button.Click">
                    <BeginStoryboard>
                        <Storyboard TargetProperty="RenderTransform.Angle">
                            <DoubleAnimation 
                                From="-5" To="5" Duration="0:0:0.05" 
                                AutoReverse="True"
                                RepeatBehavior="3x"
                                FillBehavior="Stop" />
                        </Storyboard>
                    </BeginStoryboard>
                </EventTrigger>
            </Style.Triggers>
        </Style>
    </StackPanel.Resources>

    <Button>Click me to shake</Button>
</StackPanel>

