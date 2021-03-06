Resource Lookup

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            Orientation="Horizontal">

    <StackPanel.Resources>
        <SolidColorBrush x:Key="brushText" Color="Aqua" />
    </StackPanel.Resources>

    <StackPanel>
        <StackPanel.Resources>
            <SolidColorBrush x:Key="brushText" Color="Red" />
        </StackPanel.Resources>

        <Button HorizontalAlignment="Center" 
                VerticalAlignment="Center" 
                Margin="25"
                Foreground="{StaticResource brushText}">
            Button with Red text
        </Button>
    </StackPanel>

    <StackPanel>
        <Button HorizontalAlignment="Center" 
                VerticalAlignment="Center" 
                Margin="25"
                Foreground="{StaticResource brushText}">
            Button with Aqua text
        </Button>
    </StackPanel>

</StackPanel>

