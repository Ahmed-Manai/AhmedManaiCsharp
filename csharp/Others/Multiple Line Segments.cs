Multiple Line Segments

<Canvas xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Path Fill="Aqua" Stroke="Cyan" StrokeThickness="4">
        <Path.Data>
            <PathGeometry>
                <PathFigure StartPoint="120 60">
                    <LineSegment Point="240 250" />
                    <LineSegment Point="50 160" />
                    <LineSegment Point="240 120" />
                    <LineSegment Point="70 240" />
                </PathFigure>
            </PathGeometry>
        </Path.Data>
    </Path>
</Canvas>

