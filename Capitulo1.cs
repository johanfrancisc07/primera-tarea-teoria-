using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodelLibroCShar
{
    class Capitulo1
    {
        public void Ejercicio1()
        {
            Console.WriteLine("johan hernandez");
            Console.ReadKey();
        }

       public void Ejercicio5()
        {
            Console.WriteLine("johan hernandez ");
            Console.WriteLine("Matricula: 2015-0005");
            Console.WriteLine("Carrera: Ingenieria en Sistema");
            Console.ReadKey();

        }

        public void Menu()
        {
           int op=0;
            Console.WriteLine("Menu" + "\n" +
                "1.Ejercicio_1.1\n" +
                "2.Ejercicio_1.5" 
                );
            Console.WriteLine("Digite la Opcion deseada");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                   Ejercicio1();
                    break;
                    }
                case 2:
                    {
                     Ejercicio5();
                     break;
                    }
            }
            }
        
            

    }
}
