Label with ControlTemplate

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="120" Width="240">

    <Window.Resources>
        <ControlTemplate x:Key="labelTemplate" TargetType="{x:Type Label}">
            <Border x:Name="border" CornerRadius="4" BorderThickness="3" BorderBrush="DarkGray" Background="{TemplateBinding Property=Background}">
                <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
            </Border>
        </ControlTemplate>
    </Window.Resources>
    <Grid>
        <Label Width="120" Height="36" 
               Margin="5" Content="Custom Label"
               Template="{StaticResource labelTemplate}"
               Background="Red"/>
    </Grid>
</Window>

