Using a Style resource

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Title="RSS Reader">
      
      
<StackPanel xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" Orientation="Horizontal">
  <StackPanel.Resources>
    <Style x:Key="buttonStyle">
      <Setter Property="Button.FontSize" Value="24"/>
      <Setter Property="Button.Background" Value="Purple"/>
      <Setter Property="Button.Foreground" Value="White"/>
      <Setter Property="Button.Height" Value="60"/>
      <Setter Property="Button.Width" Value="60"/>
      <Setter Property="Button.RenderTransformOrigin" Value=".5,.5"/>
      <Setter Property="Button.RenderTransform">
        <Setter.Value>
          <RotateTransform Angle="10"/>
        </Setter.Value>
      </Setter>
    </Style>
  </StackPanel.Resources>
  <Button Style="{StaticResource buttonStyle}">1</Button>
</StackPanel>


</Window>

