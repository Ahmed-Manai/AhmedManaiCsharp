Vertical Line

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Examples" >

   <Canvas> 
          <Path Stroke="Red" StrokeThickness="1">
            <Path.Data>
              <PathGeometry>
                <PathGeometry.Figures>
                  <PathFigureCollection>
                    <PathFigure StartPoint="80,40">
                      <PathFigure.Segments>
                        <PathSegmentCollection>
                          <LineSegment Point="10,160" />
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

