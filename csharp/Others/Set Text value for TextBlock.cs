Set Text value for TextBlock

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="200" Width="440">
    <Grid>
            <TextBlock Foreground="Cyan" 
                       VerticalAlignment="Center" 
                       HorizontalAlignment="Center"
                       ToolTip="This is a custom tooltip"
                       Text="Mouse Over for tooltip"/>
    </Grid>
    
</Window>

