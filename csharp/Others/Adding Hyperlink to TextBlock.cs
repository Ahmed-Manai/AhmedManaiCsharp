Adding Hyperlink to TextBlock

<Page x:Class="NavigationApplication.LinkToAssemblyPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    Title="LinkToAssemblyPage">
  <StackPanel Margin="4">
    <TextBlock Margin="4" TextWrapping="Wrap">
      This is a simple page.
      Click <Hyperlink NavigateUri="/PageLibrary;component/SharedPage.xaml">here</Hyperlink>.
    </TextBlock>


  </StackPanel>
</Page>

