Disabled Button with ToolTipService

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="160" Width="360">
    <StackPanel>
       <Button Content="Disabled Button with ToolTipService" 
            Height="24" IsEnabled="False" Margin="8" Name="button2" 
                ToolTipService.ShowOnDisabled="True" Width="250">
            <Button.ToolTip>
                ToolTip on a disabled control
            </Button.ToolTip>
        </Button>
 
    </StackPanel>
</Window>

