using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodelLibroCShar
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo1 cap1 = new Capitulo1();
            Capitulo2 cap2 = new Capitulo2();
            Capitulo3 cap3 = new Capitulo3();
            Capitulo4 cap4 = new Capitulo4();
            int op = 0;
            Console.WriteLine("Menu" + "\n" +
                "1.Capitulo_1 \n"+
                "2.Capitulo_2\n"+
                "3.Capitulo_3\n"+
                "Selecciones la opcion Deseada: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        cap1.Menu();

                        break;
                    }

                case 2:
                    {
                        cap2.Menu();
                        break;
                    }
                case 3:
                    {
                        cap3.Menu();
                        break;

                    }
                case 4:

                    cap4.Menu();
                        break;
                    }

                    
            }
        }
    }

