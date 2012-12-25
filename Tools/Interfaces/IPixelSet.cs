namespace Tools.Interfaces
{
    public interface IPixelSet
    {
        void DrawPixel(int x, int y);
        void DrawPreviewPixel(int x, int y);
        bool IsNotFilled(int x, int y);
        void FillCell(int x, int y);
        bool CellIsInArea(int x, int y);
        void AddPoint(int x, int y);
    }
}
