Basic DialogBox

<Window x:Class="Styles.BasicDialogBox"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="BasicDialogBox" Height="250" Width="250" MinHeight="150" MinWidth="200">
  <Window.Resources>
    <Thickness x:Key="BasicMargin" Bottom="4" Top="4" Left="4" Right="4"></Thickness>
  </Window.Resources>
  <DockPanel LastChildFill="True">
    <StackPanel DockPanel.Dock="Bottom" HorizontalAlignment="Right" Orientation="Horizontal">
      <Button Margin="{StaticResource BasicMargin}" Padding="3,3,3,3">OK</Button>
      <Button Margin="{StaticResource BasicMargin}" Padding="3,3,3,3">Cancel</Button>
      
    </StackPanel>
    <TextBox DockPanel.Dock="Top" Margin="10">This is a test.</TextBox>
  </DockPanel>
</Window>

