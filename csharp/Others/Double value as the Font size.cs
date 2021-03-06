Double value as the Font size

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:s="clr-namespace:System;assembly=mscorlib">
    <Canvas.Resources>
        <FontFamily x:Key="fntfam">Times New Roman</FontFamily>
        <s:Double x:Key="fntsize">100</s:Double>

        <TransformGroup x:Key="xform">
            <ScaleTransform ScaleX="{Binding Source={StaticResource fntfam}, Path=Baseline}" />
            <ScaleTransform ScaleX="{StaticResource fntsize}" />
        </TransformGroup>

        <Style TargetType="{x:Type TextBlock}">
            <Setter Property="FontFamily" Value="{StaticResource fntfam}" />
            <Setter Property="FontSize" Value="{StaticResource fntsize}" />
            <Setter Property="Text" Value="Reflect" />
            <Setter Property="Canvas.Left" Value="360" />
            <Setter Property="Canvas.Top" Value="60" />
        </Style>
    </Canvas.Resources>

    <TextBlock>asdf</TextBlock>


</Canvas>

