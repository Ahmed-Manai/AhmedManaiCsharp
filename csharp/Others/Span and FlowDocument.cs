Span and FlowDocument

<FlowDocument xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
  <Paragraph>
    <Bold>bold</Bold>
    <Italic>italic</Italic>
    <Underline>underline</Underline>
    <Hyperlink>hyperlink</Hyperlink>
    <Span BaselineAlignment="Superscript">superscript</Span>
    <Span BaselineAlignment="Subscript">subscript</Span>
    <Span>
      <Span.TextDecorations>
        <TextDecoration Location="Strikethrough"/>
      </Span.TextDecorations>
      strikethrough
    </Span>
  </Paragraph>
</FlowDocument>

