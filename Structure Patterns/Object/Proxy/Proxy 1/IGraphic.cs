interface IGraphic
{
    void Draw();
    void HandleMouse();
    void Load(StreamReader reader);
    void Save(StreamWriter writer);
}