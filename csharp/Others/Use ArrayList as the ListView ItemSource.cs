Use ArrayList as the ListView ItemSource

<Window xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
      xmlns:sys="clr-namespace:System;assembly=mscorlib"
      xmlns:col="clr-namespace:System.Collections;assembly=mscorlib"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <StackPanel>
        <ListView>
            <ListView.View>
                <GridView>
                    <GridViewColumn DisplayMemberBinding="{Binding Year}" 
                          Header="Year"
                          Width="60"/>
                    <GridViewColumn DisplayMemberBinding="{Binding Month}" 
                          Header="Month"
                          Width="60"/>
                    <GridViewColumn DisplayMemberBinding="{Binding Day}" 
                          Header="Day"
                          Width="60"/>
                </GridView>
            </ListView.View>
            <ListView.ItemsSource>
                <col:ArrayList>
                    <sys:DateTime>2012/1/1</sys:DateTime>
                    <sys:DateTime>2012/1/2</sys:DateTime>
                </col:ArrayList>
            </ListView.ItemsSource>
        </ListView>
    </StackPanel>
</Window>

