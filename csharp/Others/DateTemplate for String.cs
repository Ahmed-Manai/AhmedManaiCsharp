DateTemplate for String

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:s="clr-namespace:System;assembly=mscorlib">
    <Page.Resources>

        <DataTemplate DataType="{x:Type s:String}">
            <StackPanel Orientation="Horizontal">
                <TextBlock Text="String: " />
                <TextBlock Text="{Binding}" />
            </StackPanel>
        </DataTemplate>

    </Page.Resources>

    <StackPanel>
        <Button>
            <s:String>1</s:String>
        </Button>

    </StackPanel>
</Page>

