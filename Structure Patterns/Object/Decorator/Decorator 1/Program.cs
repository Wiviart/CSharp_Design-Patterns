do
{
    Window window = new Window();
    TextView textView = new TextView();
    Random random = new Random();
    ScrollDecorator scrollDecorator = new ScrollDecorator(textView);
    BorderDecorator borderDecorator = new BorderDecorator(scrollDecorator, random.Next(1, 10));

    window.SetContents(borderDecorator);

    Thread.Sleep(1000);
} while (true);