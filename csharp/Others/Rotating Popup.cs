Rotating Popup

<Window x:Class="SDKSample.Window1"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="AnimatedPopup">
  <StackPanel>
    <Popup IsOpen="{Binding ElementName=myCheckBox,Path=IsChecked}" 
           PlacementTarget="{Binding ElementName=myCheckBox}"            
           AllowsTransparency="True"
           PopupAnimation="Slide"
           HorizontalOffset="50"
           VerticalOffset="50"
           >
      <Canvas Width="120" Height="120" Background="Blue"
              Margin="160">
        <Canvas.RenderTransform>
          <RotateTransform x:Name="theTransform" />
        </Canvas.RenderTransform>
        <TextBlock TextWrapping="Wrap" Foreground="White">
          Rotating Popup
        </TextBlock>
      </Canvas>
    </Popup>


  </StackPanel>
</Window>

