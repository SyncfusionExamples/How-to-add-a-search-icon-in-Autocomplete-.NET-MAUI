# How to add a search icon in .NET MAUI Autocomplete
This repository contains a sample explaining how to add a search icon in Autocomplete .NET MAUI

## Adding a Search Icon in the AutoComplete .NET MAUI

You can integrate a search icon into the SfAutoComplete control in .NET MAUI by customizing the control layout. Here’s how you can achieve this:

**XAML**
```xml
<VerticalStackLayout Spacing="10" Padding="20">
    <!-- Title Label -->
    <Label Text="AutoComplete With Search Icon" 
           HorizontalOptions="Center"
           FontSize="14"
           FontAttributes="Bold"/>

    <!-- AutoComplete with Search Icon -->
    <Border  
        WidthRequest="270" 
        StrokeShape="RoundRectangle 6" 
        StrokeThickness="1" 
        Stroke="LightGray"
        BackgroundColor="White"
        HorizontalOptions="Center">

        <Grid ColumnDefinitions="*,40">
            <!-- SfAutoComplete -->
            <editors:SfAutoComplete ShowBorder="False"
                                     IsClearButtonVisible="False"
                                     x:Name="autocomplete"
                                     BackgroundColor="Transparent"
                                     DisplayMemberPath="Name"
                                     DropdownWidth="270"
                                     ItemsSource="{Binding SocialMedias}"
                                     VerticalOptions="Center"/>

            <!-- Search Icon -->
            <Label Text="&#xF349;" 
                   Grid.Column="1" 
                   FontSize="20"  
                   VerticalTextAlignment="Center" 
                   HorizontalTextAlignment="Center"
                   FontFamily="MaterialDesignIcons"
                   TextColor="Gray"
                   BackgroundColor="Transparent">
                <Label.GestureRecognizers>
                    <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped"/>
                </Label.GestureRecognizers>
            </Label>
        </Grid>
    </Border>
</VerticalStackLayout>
```

**C#**
```csharp
private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
{
    // Perform search operation here
    DisplayAlert("Search Text", $"You searched for: {autocomplete.Text}", "OK");
}
```
**Output:**

![autocompleteSearchIcon.png](https://support.syncfusion.com/kb/agent/attachment/article/17496/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM2NDk2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.fdQvyiT0NjPfbkYQjhlwvkQv7vNvdw5fGLqAOQepEHk)
