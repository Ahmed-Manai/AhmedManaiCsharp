Multiple Subpaths with PathFigure

<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    x:Class="SDKSample.SampleViewer"
    Title="Sample" >

   <Canvas> 
          <Path Stroke="Black" StrokeThickness="1">
            <Path.Data>
              <PathGeometry>
                <PathGeometry.Figures>
                  <PathFigureCollection>
                    <PathFigure IsClosed="True" StartPoint="24,240">
                      <PathFigure.Segments>
                        <PathSegmentCollection>
                          <LineSegment Point="80,240" />
                          <LineSegment Point="240,50" />
                        </PathSegmentCollection>
                      </PathFigure.Segments>
                    </PathFigure>
                    <PathFigure IsClosed="True" StartPoint="10,10">
                      <PathFigure.Segments>
                        <PathSegmentCollection>
                          <LineSegment Point="90,10" />
                          <LineSegment Point="90,40" />
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

