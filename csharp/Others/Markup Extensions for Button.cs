Markup Extensions for Button

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">



<Button xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Background="{x:Null}"
        Height="{x:Static SystemParameters.IconHeight}"
        Content="{Binding Path=Height, RelativeSource={RelativeSource Self}}"/>

</Page>

