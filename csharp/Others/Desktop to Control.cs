Desktop to Control

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Examples" >

   <Canvas> 
        <Button Width="150" Height="36">
          <Button.Background>
            <LinearGradientBrush>
              <LinearGradientBrush.GradientStops>
                  <GradientStop Offset="0" Color="{x:Static SystemColors.DesktopColor}"/>
                  <GradientStop Offset="1" Color="{x:Static SystemColors.ControlColor}"/>
              </LinearGradientBrush.GradientStops>
            </LinearGradientBrush>
          </Button.Background>
        </Button> 

   </Canvas> 


</Window>

