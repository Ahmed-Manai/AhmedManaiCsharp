Set border corner radius

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="360" Width="500">
    <UniformGrid>
        <UniformGrid.Resources>
            <Style TargetType="{x:Type TextBlock}">
                <Setter Property="FontSize" Value="16" />
                <Setter Property="HorizontalAlignment" Value="Center" />
                <Setter Property="VerticalAlignment" Value="Center" />
            </Style>
        </UniformGrid.Resources>

        <Border CornerRadius="15" BorderBrush="Cyan" 
                BorderThickness="2px, 5px, 2px, 5px" Margin="8">
            <TextBlock Text="A rounded border" />
        </Border>


    </UniformGrid>
</Window>

