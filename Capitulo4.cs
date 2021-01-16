using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodelLibroCShar
{
    class Capitulo4

    {
        public void Ejercicio4_1()
        {
            int num1 = 11, num2 = 2, y = 0, x = 0, res;


            for (x = 1; x < num1; x++)
            {
                for (y = 1; y < num2; y++)
                {
                    res = x * y;
                    Console.Write(x + " * " + y + "= " + res);
                    Console.WriteLine("\n");
                }
            }





            Console.ReadKey();
        }

        public void Ejercicio4_2()
        {
            int num, potencia, temp = 1, y;
            Console.WriteLine("4.2 Cacular la potencia de numero: ");
            Console.WriteLine("Digite el numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());
            for (y = 1; y <= potencia; y++)
            {
                temp *= num;


            }
            Console.WriteLine("la potencia es: " + temp);

            Console.ReadKey();
        }

        public void Ejercicio4_5()
        {
            int tam, cont = 0, edad;
            Console.WriteLine("Digite el numero de persona del grupo: ");
            tam = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.Write("Edad de la Persona{0}:", (i + 1));
                edad = Convert.ToInt32(Console.ReadLine());
                cont += edad;
                arr[i] = edad;
            }

            Console.WriteLine("Edad Promedio: " + cont / tam);

            int Mayor = 0;

            for (int i = 0; i < tam; i++)
            {
                if (arr[i] > Mayor)
                {
                    Mayor = arr[i];
                }
            }

            int Menor = Mayor;
            for (int i = 0; i < tam; i++)
            {
                if (arr[i] < Menor)
                {
                    Menor = arr[i];
                }
            }

            Console.WriteLine("La Persona Mayor Tiene una edad: " + Mayor);
            Console.WriteLine("La PersonaMenor tiene una edad: " + Menor);
            Console.ReadKey();
        }
        public void Menu() {
            int op = 0;
            Console.Clear();
            Console.WriteLine("Menu" + "\n" +
                "1.Ejercicio 4_1\n" +
                "2.Ejercicio 4_2\n" +
                "3.Ejercicio 4_5\n" +
                "Elija una Opcion: "
                );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Ejercicio4_1();
                        break;
                    }
                case 2:
                    {
                        Ejercicio4_2();
                        break;
                    }
                case 3:
                    {
                        Ejercicio4_5();
                        break;
                    }
            }
        }
    

    }
}

