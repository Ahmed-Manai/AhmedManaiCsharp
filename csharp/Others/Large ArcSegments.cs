Large ArcSegments

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">


<Canvas>
  <Ellipse Fill="Blue" Stroke="Black" Width="160" Height="70" />
  <Path Fill="Blue" Stroke="Black" Canvas.Left="200">
    <Path.Data>
      <PathGeometry>

        <PathFigure StartPoint="250,1" IsClosed="True">
          <ArcSegment Point="300,51" Size="80,30"
                      SweepDirection="Counterclockwise" IsLargeArc="True" />
        </PathFigure>

      </PathGeometry>
    </Path.Data>
  </Path>
</Canvas>


</Page>

