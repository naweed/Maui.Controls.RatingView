# MAUI Rating View Control
A simple and customizable Rating View control for use with .NET MAUI Apps. 

## Roadmap
This is a fully working RatingView control. However, this is only a display only version and does not allow users to change the rating. The following enhancements are in the pipeline:
* Implement IsReadOnly property to allow Interactions to change rating by tapping the RatingView control on the screen
* Release the control as a Nuget package

## How to use
1. Nuget version will be released soon. In the meanwhile, clone this repository and add the project reference to the Maui.Controls.RatingView.
2. Add the following namespace declaration in your Maui Form pages:
```
xmlns:controls="clr-namespace:XGENO.Maui.Controls;assembly=Maui.Controls.RatingView"
```
3. Add the control to the page and set the properties as necessary.
```
<controls:RatingView
    ItemCount="5"
    ItemSize="16"
    ItemSpacing="6"
    Value="4.3"
    RatedFillColor="Yellow"
    UnRatedFillColor="LightGrey"
    StrokeColor="Black"
    StrokeWidth="1"
    HorizontalOptions="Start" />
```

## RatingView Customizations
You can customize the control using any of the below properties
| Property | Data Type | Explanation |
| :--- | :----: | :--- |
| ItemCount      | Integer       | The number of rating items (e.g. stars) to draw. Defaulted to 5.   |
| ItemSize   | Float        | Defines the height of the item/star. Defaulted to 24f.      |
| ItemSpacing   | Float        | Defines the spacing between items/stars. Defaulted to 6f.      |
| Value   | Double        | The Value of the Rating used to fill the shape items/stars. Defaulted to 2.5d.      |
| RatedFillColor   | Color        | The color used to fill the shape items/stars with rating value. Defaulted to Yellow.     |
| UnRatedFillColor   | Color        | The color used to fill the empty shape items/stars. Defaulted to Light Grey.      |
| StrokeColor   | Color        | The color used to outline shape items/stars. Defaulted to Light Yellow.      |
| StrokeWidth   | Float        | Defines the stroke size of the outline. Defaulted to 1f.      |
| IsReadOnly   | Boolean        | This will be implemented in future and will be used to allow interactions to change the rating via user interactions. Currently defaulted to true.      |
| ShapePath   | String        | Used to define the shape of the item to draw. Defaulted to Star shape.      |

## Screen Shots
![RatingView](https://user-images.githubusercontent.com/103980/177027631-85160439-1e54-4a97-83b1-cf78efb25ba7.png)
