namespace Tools.Helpers
{
    public class SplineHelper
    {
        public class Splaynn
        {
            private SplaynFunc[] functions;

            public void splayn(double[] x, double[] y)
            {
                functions = new SplaynFunc[x.Length];

                for (int i = 0; i < x.Length; ++i)
                {
                    functions[i] = new SplaynFunc();
                    functions[i].x = x[i];
                    functions[i].a = y[i];
                }

                functions[0].c = 0.0;
                functions[x.Length - 1].c = 0.0;
                progonka(x, y);

                for (int i = x.Length - 1; i > 0; --i)
                {
                    double o = x[i] - x[i - 1];
                    functions[i].d = (functions[i].c - functions[i - 1].c)/o;
                    functions[i].b = o*(2.0*functions[i].c + functions[i - 1].c)
                                     /6.0 + (y[i] - y[i - 1])/o;
                }
            }

            private void progonka(double[] x, double[] y)
            {
                var al = new double[x.Length - 1];
                var bl = new double[y.Length - 1];

                al[0] = 0.0;
                bl[0] = 0.0;

                for (int i = 1; i < x.Length - 1; ++i)
                {
                    double o = x[i] - x[i - 1];
                    double o1 = x[i + 1] - x[i];
                    double e = 2.0*(o + o1);
                    double q = o1;
                    double r = 6.0*((y[i + 1] - y[i])/o1 - (y[i] - y[i - 1])/o);
                    double z = (o*al[i - 1] + e);
                    al[i] = -q/z;
                    bl[i] = (r - o*bl[i - 1])/z;
                }

                for (int i = x.Length - 2; i > 0; --i)
                {
                    functions[i].c = al[i]*functions[i + 1].c + bl[i];
                }
            }

            public double func(double x)
            {
                SplaynFunc s;

                int i = 0, j = functions.Length - 1;
                while (i + 1 < j)
                {
                    int k = i + (j - i)/2;
                    if (x <= functions[k].x)
                    {
                        j = k;
                    }
                    else
                    {
                        i = k;
                    }
                }
                s = functions[j];

                double dx = (x - s.x);
                return s.a + (s.b + (s.c/2.0 + s.d*dx/6.0)*dx)*dx;
            }

            private class SplaynFunc
            {
                public double a, b, c;
                public double d;
                public double x;
            }
        }
    }
}