Horizontal Line

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Example" >

   <Canvas> 
          <Path Stroke="Red" StrokeThickness="1">
            <Path.Data>
              <PathGeometry>
                <PathGeometry.Figures>
                  <PathFigureCollection>
                    <PathFigure StartPoint="90,40">
                      <PathFigure.Segments>
                        <PathSegmentCollection>
                          <LineSegment Point="180,40" />
                        </PathSegmentCollection>
                      </PathFigure.Segments>
                    </PathFigure>
                  </PathFigureCollection>
                </PathGeometry.Figures>
              </PathGeometry>
            </Path.Data>
          </Path>       
   </Canvas> 


</Window>

