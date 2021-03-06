Sharing a Style

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Title="RSS Reader">
      
    <StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Orientation="Horizontal">
      <StackPanel.Resources>
        <Style x:Key="controlStyle">
          <Setter Property="Control.FontSize" Value="24"/>
          <Setter Property="Control.Background" Value="Maroon"/>
          <Setter Property="Control.Foreground" Value="Aqua"/>
          <Setter Property="Control.Height" Value="60"/>
          <Setter Property="Control.Width" Value="60"/>
          <Setter Property="Control.RenderTransformOrigin" Value=".5,.5"/>
          <Setter Property="Control.RenderTransform">
            <Setter.Value>
              <RotateTransform Angle="10"/>
            </Setter.Value>
          </Setter>
        </Style>
      </StackPanel.Resources>
      <ComboBox Style="{StaticResource controlStyle}">
        <ComboBox.Items>2</ComboBox.Items>
      </ComboBox>
      <Expander Style="{StaticResource controlStyle}" Content="3"/>
      <TabControl Style="{StaticResource controlStyle}">
        <TabControl.Items>4</TabControl.Items>
      </TabControl>
      <ToolBar Style="{StaticResource controlStyle}">
        <ToolBar.Items>5</ToolBar.Items>
      </ToolBar>
      <InkCanvas Style="{StaticResource controlStyle}"/>
      <TextBox Style="{StaticResource controlStyle}" Text="7"/>
    </StackPanel>

</Window>

