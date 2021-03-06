Underline decoration with dashes

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  x:Class="TextDecorationExample.Window1"
  Title="TextDecoration Example"
  Width="800"
  Height="450">
  <StackPanel>
      <TextBlock FontSize="24" Width="200" VerticalAlignment="Center">
        I Love Clementine
        <TextBlock.TextDecorations>
          <TextDecoration Location="Underline" 
            PenThicknessUnit="FontRecommended">
            <TextDecoration.Pen>
              <Pen Brush="Red" Thickness="1">
                <Pen.DashStyle>
                  <DashStyle Dashes="5"/>
                </Pen.DashStyle>
              </Pen>
            </TextDecoration.Pen>
          </TextDecoration>
        </TextBlock.TextDecorations>
      </TextBlock>

  </StackPanel>
</Window>

