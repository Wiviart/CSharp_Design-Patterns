class Widget
{
    DialogDirector director;

    public Widget(DialogDirector dialogDirector)
    {
        director = dialogDirector;
    }

    public virtual void Changed()
    {
        director.WidgetChanged(this);
    }
}


class ListBox : Widget
{
    private List<string> listItems;
    public ListBox(DialogDirector dialogDirector)
    : base(dialogDirector)
    {
        listItems = new List<string>();
    }

    public virtual string GetSelection()
    {
        Random random = new Random();
        return listItems[random.Next(0, listItems.Count)];
    }

    public virtual void SetList(List<string> listItems)
    {
        this.listItems = listItems;
    }
}

class EntryField : Widget
{
    private string text = "";
    public EntryField(DialogDirector dialogDirector)
    : base(dialogDirector) { }
    public virtual void SetText(string text)
    {
        this.text = text;
    }
    public virtual string GetText()
    {
        return text;
    }
}

class Button : Widget
{
    public Button(DialogDirector dialogDirector)
    : base(dialogDirector) { }
}

class DialogDirector
{
    protected DialogDirector() { }
    public virtual void ShowDialog() { }
    public virtual void WidgetChanged(Widget theChangedWidget) { }
    protected virtual void CreateWidgets() { }
}

class FontDialogDirector : DialogDirector
{
    private Button ok;
    public Button OK => ok;

    private Button cancel;
    public Button Cancel => cancel;

    private ListBox fontList;
    public ListBox FontList => fontList;

    private EntryField fontName;
    public EntryField FontName => fontName;

    public FontDialogDirector()
    {
        ok = new Button(this);
        cancel = new Button(this);
        fontList = new ListBox(this);
        fontName = new EntryField(this);
    }

    public override void WidgetChanged(Widget theChangedWidget)
    {
        if (theChangedWidget == fontList)
        {
            fontName.SetText(fontList.GetSelection());
            Console.WriteLine(fontName.GetText());
        }
        else if (theChangedWidget == ok)
        {
            Console.WriteLine("OK");
        }
        else if (theChangedWidget == cancel)
        {
            Console.WriteLine("Cancel");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FontDialogDirector dialogDirector = new FontDialogDirector();
        Button ok = dialogDirector.OK;
        Button cancel = dialogDirector.Cancel;
        ListBox fontList = dialogDirector.FontList;

        List<string> listItems = new List<string>
        {
            "Arial", "Times New Roman", "Verdana"
        };

        ok.Changed();
        cancel.Changed();
        fontList.SetList(listItems);
        fontList.Changed();
    }
}