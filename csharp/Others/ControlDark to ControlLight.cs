ControlDark to ControlLight

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Examples" >

   <Canvas> 
        <Rectangle>
          <Rectangle.Fill>
            <RadialGradientBrush>
              <RadialGradientBrush.GradientStops>
                  <GradientStop Offset="0" Color="{x:Static SystemColors.ControlDarkColor}"/>
                  <GradientStop Offset="1" Color="{x:Static SystemColors.ControlLightColor}"/>
              </RadialGradientBrush.GradientStops>
            </RadialGradientBrush>
          </Rectangle.Fill>
        </Rectangle>

   </Canvas> 


</Window>

