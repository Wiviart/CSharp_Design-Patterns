/*
    This class is an adapter for the ITextView class. 
    It adapts the ITextView class to the Shape class.
*/

public class TextShape : Shape
{
    protected ITextView _textView;
    protected int _width, _height, _left;
    public TextShape(ITextView textView)
    {
        _textView = textView;
    }
    public override void BoundingBox(
       out Point bottomLeft, out Point topRight)
    {
        Coord bottom, left, width, height;
        _textView.GetOrigin(out bottom, out left);
        _textView.GetExtent(out width, out height);

        _height = height.Value;
        _width = width.Value;
        _left = left.Value;

        bottomLeft = new Point(bottom.Value, left.Value);
        topRight = new Point(
            bottom.Value + width.Value,
            left.Value + height.Value);
    }
    public override bool IsEmpty() => _textView.IsEmpty();
    public override Manipulator CreateManipulator()
         => new TextManipulator(this);

    public void DrawShape()
    {
        Console.WriteLine("Drawing a text shape with width " + _width + " and height " + _height + " and margin point " + _left);
        
        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _left; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < _width; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}