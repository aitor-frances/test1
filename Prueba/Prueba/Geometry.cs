namespace AppCalculosMatematicos
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            double length = System.Math.Sqrt(aux);

            return length;
        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux2 = x * x + y * y + z * z;
            double length = System.Math.Sqrt(aux2);

            return length;
        }

        public static double GetCicleArea(double r)
        {
            double area = System.Math.PI * (r * r);

            return area;
        }

        public static double GetDistence2D(double x1, double y1, double x2, double y2)
        {
            double distance;
            double vx;
            double vy;

            vx = x2 - x1;
            vy = y2 - y1;

            distance = GetVector2DLength(vx, vy);

            return distance;
        }

        public static bool AreIntersecting(double x1, double y1, double r1, double x2, double y2, double r2)
        {
            double distance = GetDistence2D(x1, y1, x2, y2);
            double intersecting = distance - (r1 + r2);
            return Misc.IsPositive(intersecting);
        }
    }
}
