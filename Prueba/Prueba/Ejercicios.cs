using AppCalculosMatematicos;

namespace Prueba
{
    class Ejercicios
    {
        // Ejercicio1: Hacer una función que imprima por pantalla los números del 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                //contador = contador + 1;
                //contador += 1;
                contador++;
            }
        }

        //Ejercicio2: Hacer una función que imprima todos los numeros pares desde 0 hasta n.

        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);

                i++;
            }
        }

        //Ejercicio3: Hacer un programa que imprima si un numero es primo o no.
        public static void Ejercicio3(int n)
        {
            System.Console.WriteLine(Maths.IsPrime(n));
        }
    }
}
