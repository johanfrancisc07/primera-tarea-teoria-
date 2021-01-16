using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodelLibroCShar
{
    class Capitulo3
    {
        public void Ejercicio3_1()
        {
            int num;
            Console.WriteLine("Decir si el numero digitado es par o impar");
            Console.WriteLine("Digite Un Numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 2)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("es Impar");
                 
            }


        }

        public void Ejercicio3_4()
        {
            int op;
            Console.Clear();
            Console.WriteLine("Menu de dia de  la semana");
            Console.WriteLine("1.Lunes\n" +
                "2.Martes" +
                "3.Miercoles\n" + 
                "4.Jueves\n" + 
                "5.Viernes\n" + 
                "6.Sabado\n" + 
                "7.Domingo");
             op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine(" es Lunes");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" es Martes");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(" es Miercoles");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine(" es Jueves");
                        Console.ReadKey();

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" es Viernes");
                        Console.ReadKey();
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine(" es Sabado");
                        Console.ReadKey();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(" es Domingo");
                        Console.ReadKey();
                        break;
                    }
            }

            Console.ReadKey();
        }
        public void Ejecircio3_5()
        {
            int op;
            Console.WriteLine("Cacular el area y el perimetro de un poligino Regular  y elegir cual desea calcular");
            Console.WriteLine("Menu\n" + "1.Calcular Area:\n " + "2.Calcular Perimetro: \n"+"Elija una opcion");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        float lado, longitud;
                        Console.WriteLine("Digite Cantidad de lados: ");
                          lado = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Digite la longitud: ");
                         longitud = Convert.ToSingle(Console.ReadLine());
                        lado *= longitud / 2;
                        Console.WriteLine("el area es: " + lado);
                        Console.ReadKey();
                        break;

                    }
                case 2:
                    {
                        float lado, longitud;
                        Console.WriteLine("Digite Cantidad de lados: ");
                        lado = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Digite la longitud: ");
                        longitud = Convert.ToSingle(Console.ReadLine());
                        lado *= longitud ;
                        Console.WriteLine("el area es: " + lado);
                        Console.ReadKey();
                        break;

                    }
            }
            
                
              
        }

        public void Menu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("Menu" + "\n" +
                "1.Ejercicio 3_1\n" +
                "2.Ejercicio 3_4\n"+
                "3.Ejercicio 3_5\n"+
                "Elija una Opcion: "
                );

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Ejercicio3_1();
                        break;
                    }
                case 2:
                    {
                        Ejercicio3_4();
                        break;
                    }
                case 3:
                    {
                        Ejecircio3_5();
                        break;
                    }
            }
        }



    }
}

