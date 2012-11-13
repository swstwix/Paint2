namespace Tools.Interfaces
{
    public interface IPaintTool
    {
        void OnMouseClick(int x, int y);
        void OnMouseClicked(int x, int y);
        void OnMouseMoved(int x, int y);

        void Draw(IGraphics graphics);
    }
}
