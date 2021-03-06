Painting a 3D surface with a bitmap

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Stretch" VerticalAlignment="Stretch">

<Viewport3D>
  <Viewport3D.Camera>
    <PerspectiveCamera Position="0,1,10" LookDirection="0,-1,-10"  />
  </Viewport3D.Camera>
  <ModelVisual3D>
    <ModelVisual3D.Content>
      <Model3DGroup>
        <DirectionalLight Direction="0,-1,-10" />
        <DirectionalLight Direction="3,2,2" />
            <GeometryModel3D>
              <GeometryModel3D.Geometry>
                <MeshGeometry3D Positions="-1,1,0  1,1,0  -1,-1,0, 1,-1,0"
                                Normals="0,0,1  0,0,1  0,0,1 0,0,1"
                                TextureCoordinates="0,0 1,0 0,1 1,1"
                                TriangleIndices="0,2,3 0,3,1" />
              </GeometryModel3D.Geometry>            
              <GeometryModel3D.Material>
                <DiffuseMaterial>
                  <DiffuseMaterial.Brush>
                    <ImageBrush ImageSource="c\image.jpg" />
                  </DiffuseMaterial.Brush>
                </DiffuseMaterial>
              </GeometryModel3D.Material>
            </GeometryModel3D>
      </Model3DGroup>
    </ModelVisual3D.Content>
  </ModelVisual3D>
</Viewport3D>

</Page>

