Style With Data Trigger

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <StackPanel.Resources>
        <Style TargetType="{x:Type Button}">
            <Setter Property="FontSize" Value="24" />
            <Setter Property="HorizontalAlignment" Value="Center" />
            <Setter Property="Margin" Value="24" />

            <Style.Triggers>
                <DataTrigger Binding="{Binding ElementName=txtbox, 
                                               Path=Text.Length}"
                             Value="0">
                    <Setter Property="IsEnabled" Value="False" />
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </StackPanel.Resources>

    <TextBox Name="txtbox" HorizontalAlignment="Center" 
             Width="2in" Margin="24" />

    <Button>
        Button Number 1
    </Button>
</StackPanel>

