Nested Span elements

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      HorizontalAlignment="Center" VerticalAlignment="Center">


<TextBlock>
  <Span FontFamily="Arial">
    This uses <Span FontWeight="Normal">a
    <Span FontStyle="Italic">mixture</Span> of</Span> styles.
  </Span>
</TextBlock>


</Page>

