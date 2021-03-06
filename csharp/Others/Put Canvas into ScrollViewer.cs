Put Canvas into ScrollViewer

<Window x:Class="SimpleStyles.Window1"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  Title="SimpleStyles"
  Background="#F1F1F1">
  <ScrollViewer>
    <WrapPanel>
      <HeaderedItemsControl Header="ScrollViewer">
        <StackPanel>
          <ScrollViewer Width="250" Height="250" Style="{StaticResource LeftScrollViewer}">
            <Canvas Width="500" Height="500">
              <Canvas.Background>
                <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                  <GradientStop Color="#FCF" Offset="0"/>
                  <GradientStop Color="#AFA" Offset="1"/>
                </LinearGradientBrush>
              </Canvas.Background>
            </Canvas>
          </ScrollViewer>
        </StackPanel>
      </HeaderedItemsControl>
   
    </WrapPanel>
  </ScrollViewer>
</Window>

