using XGENO.Maui.Controls.Drwables;

namespace XGENO.Maui.Controls;


public class RatingView : GraphicsView
{
    //Rating Drawable Canvas
    private RatingCanvas _drawableCanvas;

    #region Bindable Properties

    public static readonly BindableProperty ItemCountProperty = BindableProperty.Create(
        nameof(ItemCount),
        typeof(int),
        typeof(RatingView),
        5,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateItemCount();
        });

    public int ItemCount
    {
        get => (int)GetValue(ItemCountProperty);
        set => SetValue(ItemCountProperty, value);
    }

    private void UpdateItemCount()
    {
        _drawableCanvas.ItemCount = ItemCount;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty ItemSizeProperty = BindableProperty.Create(
        nameof(ItemSize),
        typeof(float),
        typeof(RatingView),
        24f,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateItemSize();
        });

    public float ItemSize
    {
        get => (float)GetValue(ItemSizeProperty);
        set => SetValue(ItemSizeProperty, value);
    }

    private void UpdateItemSize()
    {
        _drawableCanvas.ItemSize = ItemSize;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty ItemSpacingProperty = BindableProperty.Create(
        nameof(ItemSpacing),
        typeof(float),
        typeof(RatingView),
        6f,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateItemSpacing();
        });

    public float ItemSpacing
    {
        get => (float)GetValue(ItemSpacingProperty);
        set => SetValue(ItemSpacingProperty, value);
    }

    private void UpdateItemSpacing()
    {
        _drawableCanvas.ItemSpacing = ItemSpacing;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty ValueProperty = BindableProperty.Create(
        nameof(Value),
        typeof(double),
        typeof(RatingView),
        2.5d,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateValue();
        });

    public double Value
    {
        get => (double)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    private void UpdateValue()
    {
        _drawableCanvas.Value = Value;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty RatedFillColorProperty = BindableProperty.Create(
        nameof(RatedFillColor),
        typeof(Color),
        typeof(RatingView),
        Color.FromArgb("#FFFF00"),
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateRatedFillColor();
        });

    public Color RatedFillColor
    {
        get => (Color)GetValue(RatedFillColorProperty);
        set => SetValue(RatedFillColorProperty, value);
    }

    private void UpdateRatedFillColor()
    {
        _drawableCanvas.RatedFillColor = RatedFillColor;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty UnRatedFillColorProperty = BindableProperty.Create(
        nameof(UnRatedFillColor),
        typeof(Color),
        typeof(RatingView),
        Color.FromArgb("#D3D3D3"),
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateUnRatedFillColor();
        });

    public Color UnRatedFillColor
    {
        get => (Color)GetValue(UnRatedFillColorProperty);
        set => SetValue(UnRatedFillColorProperty, value);
    }

    private void UpdateUnRatedFillColor()
    {
        _drawableCanvas.UnRatedFillColor = UnRatedFillColor;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty StrokeColorProperty = BindableProperty.Create(
        nameof(StrokeColor),
        typeof(Color),
        typeof(RatingView),
        Color.FromArgb("#FFFFE0"),
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateStrokeColor();
        });

    public Color StrokeColor
    {
        get => (Color)GetValue(StrokeColorProperty);
        set => SetValue(StrokeColorProperty, value);
    }

    private void UpdateStrokeColor()
    {
        _drawableCanvas.StrokeColor = StrokeColor;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty StrokeWidthProperty = BindableProperty.Create(
        nameof(StrokeWidth),
        typeof(float),
        typeof(RatingView),
        1f,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateStrokeWidth();
        });

    public float StrokeWidth
    {
        get => (float)GetValue(StrokeWidthProperty);
        set => SetValue(StrokeWidthProperty, value);
    }

    private void UpdateStrokeWidth()
    {
        _drawableCanvas.StrokeWidth = StrokeWidth;
        SetSize();
        Invalidate();
    }

    public static readonly BindableProperty IsReadOnlyProperty = BindableProperty.Create(
        nameof(IsReadOnly),
        typeof(bool),
        typeof(RatingView),
        true,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateIsReadOnly();
        });

    public bool IsReadOnly
    {
        get => (bool)GetValue(IsReadOnlyProperty);
        set => SetValue(IsReadOnlyProperty, value);
    }

    private void UpdateIsReadOnly()
    {
        ////TODO: Implement Interactions
    }

    public static readonly BindableProperty ShapePathProperty = BindableProperty.Create(
        nameof(ShapePath),
        typeof(string),
        typeof(RatingView),
        "M885.344,319.071l-258-3.8l-102.7-264.399c-19.8-48.801-88.899-48.801-108.6,0l-102.7,264.399l-258,3.8\n\t\tc-53.4,3.101-75.1,70.2-33.7,103.9l209.2,181.4l-71.3,247.7c-14,50.899,41.1,92.899,86.5,65.899l224.3-122.7l224.3,122.601\n\t\tc45.4,27,100.5-15,86.5-65.9l-71.3-247.7l209.2-181.399C960.443,389.172,938.744,322.071,885.344,319.071z",
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is RatingView rating && newValue != oldValue)
                rating.UpdateShapePath();
        });


    public string ShapePath
    {
        get => (string)GetValue(ShapePathProperty);
        set => SetValue(ShapePathProperty, value);
    }

    private void UpdateShapePath()
    {
        _drawableCanvas.ShapePath = ShapePath;
        SetSize();
        Invalidate();
    }

    #endregion

    private void SetSize()
    {
        HeightRequest = ItemSize + StrokeWidth * 2;
        WidthRequest = ItemSize * ItemCount + ItemSpacing * (ItemCount - 1) + StrokeWidth * 2;
    }

    protected override void OnParentSet()
    {
        base.OnParentSet();

        if (Parent is null)
            return;

        //Update Local Properties
        UpdateRatedFillColor();
        UpdateUnRatedFillColor();
        UpdateStrokeColor();
        UpdateStrokeWidth();
        UpdateShapePath();
        UpdateItemSpacing();
        UpdateItemSize();
        UpdateItemCount();
        UpdateValue();
    }

    public RatingView()
    {
        //Create and set Drawable Canvas
        _drawableCanvas = new RatingCanvas();

        Drawable = _drawableCanvas;
    }
}