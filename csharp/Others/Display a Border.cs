Display a Border

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="400" Width="500">
    <UniformGrid>
        <UniformGrid.Resources>
            <Style TargetType="{x:Type TextBlock}">
                <Setter Property="FontSize" Value="16" />
                <Setter Property="HorizontalAlignment" Value="Center" />
                <Setter Property="VerticalAlignment" Value="Center" />
            </Style>
        </UniformGrid.Resources>
        <Border CornerRadius="80" Background="Blue" BorderThickness="2px"
                Margin="10">
            <TextBlock Text="A circular border" />
        </Border>
    </UniformGrid>
</Window>

