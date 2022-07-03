namespace XGENO.Maui.Controls.Drwables;

internal class RatingCanvas : IDrawable
{
    #region Properties

    public int ItemCount { get; set; }
    public float ItemSize { get; set; }
    public float ItemSpacing { get; set; }
    public double Value { get; set; }

    public Color RatedFillColor { get; set; }
    public Color UnRatedFillColor { get; set; }

    public Color StrokeColor { get; set; }
    public float StrokeWidth { get; set; }

    public string ShapePath { get; set; }

    #endregion

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.Antialias = true;

        //Draw each rating item
        for (int itemIndex = 0; itemIndex < ItemCount; itemIndex++)
        {
            DrawRatingItem(canvas, dirtyRect, itemIndex);
        }
    }

    private void DrawRatingItem(ICanvas canvas, RectF dirtyRect, int itemIndex)
    {
        canvas.SaveState();

        //Position the Shape in the Canvas
        canvas.Translate(itemIndex * ItemSize + itemIndex * ItemSpacing + StrokeWidth, StrokeWidth);

        //Build the shape
        var pathBuilder = new PathBuilder();
        var shapePath = pathBuilder.BuildPath(ShapePath);
        var scaledShapePath = shapePath.AsScaledPath((ItemSize - StrokeWidth) / (shapePath.Bounds.Width < shapePath.Bounds.Height ? shapePath.Bounds.Width : shapePath.Bounds.Height));

        //Draw Empty Star as background
        DrawShape(canvas, scaledShapePath, StrokeColor, UnRatedFillColor, StrokeWidth, null);

        //Draw Filled Star
        if (itemIndex < Value)
        {
            var clippedPath = new PathF();
            clippedPath.AppendRectangle(0, 0, Convert.ToSingle(scaledShapePath.Bounds.Width * (Value - itemIndex)), scaledShapePath.Bounds.Height);

            DrawShape(canvas, scaledShapePath, StrokeColor, RatedFillColor, StrokeWidth, clippedPath);
        }

        canvas.RestoreState();
    }

    private void DrawShape(ICanvas canvas, PathF shapePath, Color strokeColor, Color fillColor, float strokeWidth, PathF clippedPath)
    {
        //Set item colors and strokes
        canvas.StrokeColor = strokeColor;
        canvas.StrokeSize = strokeWidth;
        canvas.FillColor = fillColor;

        //Clip if needed
        if (clippedPath is not null)
            canvas.ClipPath(clippedPath);

        //Draw the shape
        canvas.DrawPath(shapePath);
        canvas.FillPath(shapePath);
    }
}


