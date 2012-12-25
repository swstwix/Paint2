using Tools.Arguments;

namespace Tools.Interfaces
{
    public interface IPaintTool
    {
        void OnMouseClick(int x, int y);
        void OnMouseClicked(int x, int y);
        void OnMouseMoved(int x, int y);

        void Draw(IPixelSet pixelSet, IDrawingArea drawingArea);

        void Move(int x, int y);
        void Rotate(int x, int y);
        void Cutting(CuttingArguments cut);
    }
}
