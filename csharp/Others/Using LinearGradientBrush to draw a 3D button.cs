Using LinearGradientBrush to draw a 3D button

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
    <Rectangle Width="90" Height="30">
        <Rectangle.Fill>
            <VisualBrush>
                <VisualBrush.Visual>
                    <Grid Width="90" Height="26">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="2*" />
                            <RowDefinition Height="*" />
                        </Grid.RowDefinitions>
                        <Rectangle Grid.RowSpan="2" RadiusX="13" RadiusY="13">
                            <Rectangle.Fill>
                                <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">
                                    <GradientStop Color="Blue" Offset="0" />
                                    <GradientStop Color="DarkBlue" Offset="1" />
                                </LinearGradientBrush>
                            </Rectangle.Fill>
         
                        </Rectangle>

                        <Rectangle Margin="3,2" RadiusX="8" RadiusY="12">
                            <Rectangle.Fill>
                                <LinearGradientBrush StartPoint="0,0" EndPoint="0,1">
                                    <GradientStop Color="#ccff" Offset="0" />
                                    <GradientStop Color="#ccaa" Offset="1" />
                                </LinearGradientBrush>
                            </Rectangle.Fill>
                        </Rectangle>

                    </Grid>
                </VisualBrush.Visual>
            </VisualBrush>
        </Rectangle.Fill>
    </Rectangle>

</Page>

