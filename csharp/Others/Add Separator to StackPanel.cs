Add Separator to StackPanel

<Window x:Class="Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="Window1" Height="180" Width="18">
    <Grid>
        <StackPanel Name="StackPanel1">
            <Button Height="25" Name="Button1">Button</Button>
            <Button Height="25" Name="Button2" Width="Auto">Button</Button>
            <Separator Height="5" Name="Separator1" Width="Auto" />
            <Button Height="25" Name="Button3" >Button</Button>
        </StackPanel>
    </Grid>
</Window>

