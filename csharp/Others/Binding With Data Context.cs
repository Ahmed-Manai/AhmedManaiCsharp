Binding With Data Context

<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <ScrollBar Name="scroll"
               Orientation="Horizontal" Margin="25" 
               Maximum="150" LargeChange="16" SmallChange="1" />

    <Label HorizontalAlignment="Center"
           DataContext="{Binding ElementName=scroll}"
           Content="{Binding Path=Value}" />

</StackPanel>

