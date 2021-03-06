TextBox Style

<Window x:Class="WpfApplication1.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="WPF" Height="240" Width="360">
    <Window.Resources>
        <Style x:Key="BaseControlStyle" 
               TargetType="{x:Type Control}">
            <Setter Property="FontFamily" Value="Arial" />
            <Setter Property="FontSize" Value="24pt"/>
            <Setter Property="Margin" Value="4" />
        </Style>

        <Style TargetType="{x:Type Button}" 
               BasedOn="{StaticResource BaseControlStyle}">
            <Setter Property="FontWeight" Value="Bold" />
        </Style>

        <Style TargetType="{x:Type CheckBox}" 
               BasedOn="{StaticResource BaseControlStyle}">
        </Style>
        <Style TargetType="{x:Type TextBox}" 
               BasedOn="{StaticResource BaseControlStyle}">
        </Style>

    </Window.Resources>

    <Grid>
        <StackPanel>
            <CheckBox>CheckBox</CheckBox>
            <TextBox>TextBox</TextBox>
            <Button>Button</Button>
            <Button FontWeight="Light">Button with overridden style</Button>
            <TextBlock>TextBlock</TextBlock>
            <ComboBox>ComboBox</ComboBox>
        </StackPanel>
    </Grid>
</Window>

