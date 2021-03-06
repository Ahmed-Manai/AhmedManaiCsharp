Define Double value as resource

<Window x:Class="Styles.ReuseFontWithResources"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="ReuseFontWithResources" Height="400" Width="450"
    xmlns:s="clr-namespace:System;assembly=mscorlib"
    >
  <Window.Resources>    
    <FontFamily x:Key="ButtonFontFamily">Times New Roman</FontFamily>
    <s:Double x:Key="ButtonFontSize">20</s:Double>
    <FontWeight x:Key="ButtonFontWeight">Bold</FontWeight>    
  </Window.Resources>
  <StackPanel Margin="5">
    <Button Padding="5" Margin="5"
            FontFamily="{StaticResource ButtonFontFamily}"
            FontWeight="{StaticResource ButtonFontWeight}"
            FontSize="{StaticResource ButtonFontSize}" 
              >A Customized Button</Button>
  </StackPanel>
</Window>

