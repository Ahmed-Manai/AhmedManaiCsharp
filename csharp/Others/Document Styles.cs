Document Styles

<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      Title="title">
    <Page.Resources>

        <Style TargetType="{x:Type Paragraph}" x:Key="Normal">
            <Setter Property="TextIndent" Value="0.25in" />
        </Style>

        <Style TargetType="{x:Type Paragraph}" x:Key="ChapterHead">
            <Setter Property="TextAlignment" Value="Center" />
            <Setter Property="FontSize" Value="12pt" />
        </Style>

    </Page.Resources>
    <FlowDocumentReader>
        <FlowDocument>
            <Paragraph Style="{StaticResource ChapterHead}">
                 Chapter I
            </Paragraph>
            <Paragraph Style="{StaticResource ChapterHead}">
                 Chapter Head
            </Paragraph>
            <Paragraph Style="{StaticResource Normal}">
                this is a test
            </Paragraph>
            <Paragraph Style="{StaticResource Normal}">
                ...
            </Paragraph>
        </FlowDocument>
    </FlowDocumentReader>
</Page>

