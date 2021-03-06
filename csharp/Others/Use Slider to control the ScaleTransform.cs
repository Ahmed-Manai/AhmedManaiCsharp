Use Slider to control the ScaleTransform

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Label Content="ScaleX" />
    <ScrollBar Name="xscroll" Orientation="Horizontal" Value="1" Minimum="-16" Maximum="16" />
    <TextBlock HorizontalAlignment="Center" Text="{Binding ElementName=xscroll, Path=Value}" />

    <Label Content="ScaleY" />
    <ScrollBar Name="yscroll" Orientation="Horizontal" Value="1" Minimum="-16" Maximum="16" />
    <TextBlock HorizontalAlignment="Center" Text="{Binding ElementName=yscroll, Path=Value}" />

    <Label Content="CenterX" />
    <ScrollBar Name="xcenter" Orientation="Horizontal" Value="0" Minimum="-120" Maximum="120" /> 
    <TextBlock HorizontalAlignment="Center" Margin="12" Text="{Binding ElementName=xcenter, Path=Value}" />

    <Label Content="CenterY" />
    <ScrollBar Name="ycenter" Orientation="Horizontal" Value="0" Minimum="-120" Maximum="120" />
    <TextBlock HorizontalAlignment="Center" Margin="12" Text="{Binding ElementName=ycenter, Path=Value}" />

    <Canvas>
        <Button Name="btn" Content="Button" Canvas.Left="120" Canvas.Top="120">
            <Button.RenderTransform>
                <ScaleTransform
                    ScaleX="{Binding ElementName=xscroll, Path=Value}"
                    ScaleY="{Binding ElementName=yscroll, Path=Value}" 
                    CenterX="{Binding ElementName=xcenter, Path=Value}"
                    CenterY="{Binding ElementName=ycenter, Path=Value}" />
            </Button.RenderTransform>
        </Button>

        <StackPanel>
            <TextBlock Text="{Binding ElementName=btn, Path=ActualWidth}" />
            <TextBlock Text="::" />
            <TextBlock Text="{Binding ElementName=btn, Path=ActualHeight}" />
        </StackPanel>
    </Canvas>
</StackPanel>

