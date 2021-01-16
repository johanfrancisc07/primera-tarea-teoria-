using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodelLibroCShar
{
    class Capitulo2
    {
        public void Ejercicio2_1()
        {
            Console.WriteLine("Calcular Perimetro de Poligono Regular");
              float lado = 0, longitud = 0;
            Console.WriteLine("Digite caunto lado tiene el poligono: ");
              lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite cuanto Longitud tiene el poligono: ");
              longitud = Convert.ToSingle(Console.ReadLine());
               lado *= longitud;
            Console.WriteLine("El perimetro es:" + lado);
            Console.ReadKey();


        }

        public void Ejercicio2_3()
        {
            float grado = 0, radianes = 0;
            Console.WriteLine("Convertir de Grados a Radianes: ");
            Console.WriteLine("Digite la temperatura en grados: ");
            grado = Convert.ToSingle(Console.ReadLine());
            radianes = grado * ((float)Math.PI / 100);
            Console.WriteLine("La Temperatura en Radianes: " + radianes);
            Console.ReadKey();
            
                
        }

        public void Ejercicio2_4()
        {
            float grados;
            Console.WriteLine("Convertir de grado a Fahrenheit");
            Console.WriteLine("Digite la Temperatura en Grado: ");
              grados = Convert.ToSingle(Console.ReadLine());
              grados = (grados * 1.8F)+32;
            Console.WriteLine("La Temperatura en  Fahrenheit es: " + grados);
            Console.ReadKey();


        }

        public void Ejercicio2_5()
        {
            float euros, dollar,cambio;
            Console.WriteLine("Convertir de Dollar a Euros: ");
            Console.WriteLine("Digite la taza del dia: ");
            cambio = Convert.ToSingle(Console.ReadKey());
            Console.WriteLine("Digite cantidad de dollar a convertir: ");
             dollar = Convert.ToSingle(Console.ReadKey());
             euros = dollar * cambio;
            Console.WriteLine("Su total en Euro es: " + euros);
            Console.ReadKey();


        }
        public void Menu()
        {
            int op=0;
            Console.WriteLine("Menu" + "\n" +
                "1.Ejercicio_2.1\n" +
                "1.Ejercicio_2.3\n" +
                "1.Ejercicio_2.4\n"+
                "2.Ejercicio_2.5"
                );
            Console.WriteLine("Digite la Opcion deseada");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Ejercicio2_1();
                        break;
                    }
                case 2:
                    {
                        
                        Ejercicio2_3();
                        break;

                    }
                case 3:
                    {
                        Ejercicio2_4();
                        break;

                    }
                case 4:
                    {
                        Ejercicio2_5();
                        break;
                    }
            }
        }
    }
}
