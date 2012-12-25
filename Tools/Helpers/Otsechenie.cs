using Tools.Arguments;

namespace Tools.Helpers
{
    public class Otsechenie
    {
        public static bool Vne(CuttingArguments cut, int x0, int y0, int x1, int y1)
        {
            if (Intersection(cut, x0, y0, x1, y1))
            {
                return false;
            }

            if (!(cut.MinX < x0 && x0 < cut.MaxX))
                return true;
            if (!(cut.MinX < x1 && x1 < cut.MaxX))
                return true;
            if (!(cut.MinY < y0 && y0 < cut.MaxY))
                return true;
            if (!(cut.MinY < y1 && y1 < cut.MaxY))
                return true;

            return false;
        }

        private static bool Intersection(CuttingArguments cut, int x0, int y0, int x1, int y1)
        {
            int ax1, ay1, ax2, ay2, bx1, by1, bx2, by2;
            ax1 = cut.MinX; ay1 = cut.MinY;
            ax2 = cut.MaxX; ay2 = cut.MinY;
            bx1 = x0; by1 = y0;
            bx2 = x1; by2 = y1;
            int v1 = (bx2 - bx1)*(ay1 - by1) - (by2 - by1)*(ax1 - bx1);
            int v2 = (bx2 - bx1)*(ay2 - by1) - (by2 - by1)*(ax2 - bx1);
            int v3 = (ax2 - ax1)*(by1 - ay1) - (ay2 - ay1)*(bx1 - ax1);
            int v4 = (ax2 - ax1)*(by2 - ay1) - (ay2 - ay1)*(bx2 - ax1);
            if ((v1*v2 <= 0) && (v3*v4 <= 0))
                return true;

            ax1 = cut.MaxX; ay1 = cut.MinY;
            ax2 = cut.MaxX; ay2 = cut.MaxY;
            bx1 = x0; by1 = y0;
            bx2 = x1; by2 = y1;
            v1 = (bx2 - bx1) * (ay1 - by1) - (by2 - by1) * (ax1 - bx1);
            v2 = (bx2 - bx1) * (ay2 - by1) - (by2 - by1) * (ax2 - bx1);
            v3 = (ax2 - ax1) * (by1 - ay1) - (ay2 - ay1) * (bx1 - ax1);
            v4 = (ax2 - ax1) * (by2 - ay1) - (ay2 - ay1) * (bx2 - ax1);
            if ((v1 * v2 <= 0) && (v3 * v4 <= 0))
                return true;

            ax1 = cut.MaxX; ay1 = cut.MaxY;
            ax2 = cut.MinX; ay2 = cut.MaxY;
            bx1 = x0; by1 = y0;
            bx2 = x1; by2 = y1;
            v1 = (bx2 - bx1) * (ay1 - by1) - (by2 - by1) * (ax1 - bx1);
            v2 = (bx2 - bx1) * (ay2 - by1) - (by2 - by1) * (ax2 - bx1);
            v3 = (ax2 - ax1) * (by1 - ay1) - (ay2 - ay1) * (bx1 - ax1);
            v4 = (ax2 - ax1) * (by2 - ay1) - (ay2 - ay1) * (bx2 - ax1);
            if ((v1 * v2 <= 0) && (v3 * v4 <= 0))
                return true;

            ax1 = cut.MinX; ay1 = cut.MaxY;
            ax2 = cut.MinX; ay2 = cut.MinY;
            bx1 = x0; by1 = y0;
            bx2 = x1; by2 = y1;
            v1 = (bx2 - bx1) * (ay1 - by1) - (by2 - by1) * (ax1 - bx1);
            v2 = (bx2 - bx1) * (ay2 - by1) - (by2 - by1) * (ax2 - bx1);
            v3 = (ax2 - ax1) * (by1 - ay1) - (ay2 - ay1) * (bx1 - ax1);
            v4 = (ax2 - ax1) * (by2 - ay1) - (ay2 - ay1) * (bx2 - ax1);
            if ((v1 * v2 <= 0) && (v3 * v4 <= 0))
                return true;

            return false;
        }

        internal static bool Vne(CuttingArguments cutArgs, int x2, int y2)
        {
            if (x2 < cutArgs.MinX)
                return true;
            if (y2 < cutArgs.MinY)
                return true;
            if (x2 > cutArgs.MaxX)
                return true;
            if (y2 > cutArgs.MaxY)
                return true;
            return false;
        }
    }
}