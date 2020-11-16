using System.Drawing;
using System.Reflection.PortableExecutable;

namespace Imagen
{
    class Program
    {
        //Distamcia entre dos puntos
        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt(vx * vx + vy * vy);
        }

        public static void FillImage(Bitmap bitmap, Color color)
        {
           
            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                    bitmap.SetPixel(x, y, color);
        }

        public static void FillCircle(Bitmap bitmap, Color color, double centerx, double centery, double ratio)
        {
            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (GetDistance2D(centerx, centery, x, y) < ratio || y == 0 || y == bitmap.Height - 1 || x == 0 || x == bitmap.Width - 1)
                    {
                        bitmap.SetPixel(x, y, color);
                    }
                }
        }

        public static void PaintJapaneseFlag(Bitmap bm)
        {
            //Vamos a rellenar la imagen de rojo
            FillImage(bm, Color.White);

            //Vamos a poner un círculo
            FillCircle(bm, Color.Red, 250, 150, 50);

            //Vamos a poner un marco negro
            for (int y = 0; y < bm.Height; y++)
                for (int x = 0; x < bm.Width; x++)
                {
                    if (y == 0 || y == bm.Height - 1 || x == 0 || x == bm.Width - 1)
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
        }

        public static void PaintRomanFace(Bitmap bm)
        {
            //cara
            FillCircle(bm, Color.Black, (bm.Width / 2), (bm.Height / 2), 120);
            FillCircle(bm, Color.Yellow, (bm.Width / 2), (bm.Height / 2), 118);

            //boca
            FillCircle(bm, Color.Black, (bm.Width / 2), (bm.Height / 2) + 55, 35);
            FillCircle(bm, Color.Yellow, (bm.Width / 2), (bm.Height / 2) + 55, 33);

            //nariz
            FillCircle(bm, Color.Black, (bm.Width / 2), (bm.Height / 2), 4);

            //pecas
            FillCircle(bm, Color.Black, (bm.Width / 2) + 58, (bm.Height / 2) + 5, 2);
            FillCircle(bm, Color.Black, (bm.Width / 2) + 70, (bm.Height / 2) + 5, 2);
            FillCircle(bm, Color.Black, (bm.Width / 2) + 65, (bm.Height / 2) + 10, 2);

            //ojo izquierda
            FillCircle(bm, Color.Black, (bm.Width / 2) - 44, (bm.Height / 2) - 40, 37);
            FillCircle(bm, Color.Yellow, (bm.Width / 2) - 44, (bm.Height / 2) - 40, 35);
            FillCircle(bm, Color.Black, (bm.Width / 2) - 44, (bm.Height / 2) - 40, 12);
            FillCircle(bm, Color.Yellow, (bm.Width / 2) - 44, (bm.Height / 2) - 40, 10);

            //ojo derecha
            FillCircle(bm, Color.Black, (bm.Width / 2) + 44, (bm.Height / 2) - 40, 26);
            FillCircle(bm, Color.Yellow, (bm.Width / 2) + 44, (bm.Height / 2) - 40, 24);
            FillCircle(bm, Color.Black, (bm.Width / 2) + 44, (bm.Height / 2) - 40, 10);
            FillCircle(bm, Color.Yellow, (bm.Width / 2) + 44, (bm.Height / 2) - 40, 8);
        }

        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(500, 300);

            //PaintJapaneseFlag(bitmap);
            PaintRomanFace(bitmap);

            bitmap.Save("C:\\Users\\aitor\\OneDrive\\Escritorio\\repos\\prueba.png");
        }
    }
}
