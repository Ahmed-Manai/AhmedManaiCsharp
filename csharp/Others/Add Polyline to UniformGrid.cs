Add Polyline to UniformGrid

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="200" Width="360">
    <UniformGrid Columns="3" HorizontalAlignment="Center" VerticalAlignment="Center">
        <Polyline Margin="10" Stroke="Red" StrokeThickness="5" Points="110,0 120,0 100,130 0,300 0,20 180,120 80,180 20,180, 210,410 610,410 610,610 40,60" />
    </UniformGrid>
</Window>

