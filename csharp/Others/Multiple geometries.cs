Multiple geometries

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">


        <Path Fill="Cyan" Stroke="Maroon">
          <Path.Data>
            <GeometryGroup>
              <RectangleGeometry Rect="0,0,500,60" />
              <EllipseGeometry Center="550,320" RadiusX="40" RadiusY="12" />
            </GeometryGroup>
          </Path.Data>
        </Path>


</Page>

