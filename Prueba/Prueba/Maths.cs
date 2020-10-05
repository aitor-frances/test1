namespace AppCalculosMatematicos
{
    class Maths
    {
        public static Equation2Solution SolveEquation1(double a, double b, double c)
        {
            double aux1, aux2;
            Equation2Solution result;

            result = new Equation2Solution();

            aux1 = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux1);

            result.solution1 = (-b + aux2) / (2.0 * a);
            result.solution1 = (-b - aux2) / (2.0 * a);

            return result;

        }
        public static double SolveEquation2(double a, double b)
        {
            double x;

            x = (-b / a);

            return x;
        }
        public static bool IsPrime(int number)
        {
            int i = 0;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
