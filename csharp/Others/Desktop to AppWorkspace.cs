Desktop to AppWorkspace

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Examples" >

   <Canvas> 
        <Button Width="160" Height="36">
          <Button.Background>
            <RadialGradientBrush>
              <RadialGradientBrush.GradientStops>
                  <GradientStop Offset="0" Color="{x:Static SystemColors.DesktopColor}"/>
                  <GradientStop Offset="1" Color="{x:Static SystemColors.AppWorkspaceColor}"/>
              </RadialGradientBrush.GradientStops>
            </RadialGradientBrush>
          </Button.Background>
        </Button>   

   </Canvas> 


</Window>

