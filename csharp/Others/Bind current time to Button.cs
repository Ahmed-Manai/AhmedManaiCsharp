Bind current time to Button

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:s="clr-namespace:System;assembly=mscorlib">
    <StackPanel Width="400">

        <Button Content="{x:Static s:DateTime.Now}"
                HorizontalAlignment="Center" />

    </StackPanel>
</Page>

