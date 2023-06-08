using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
   class Program
   {
      static void Main(string[] args)
      {
         Promedio miPromedio = new Promedio();
         Console.WriteLine("Bienvenido al promedio calculator");
         Console.WriteLine("Seleccione la opcion que desea:\n n-1:Ingresar valores \n n-2:Calcular Promedio \n n-3 Para salir");
         int opcion = Convert.ToInt32(Console.ReadLine());
         Console.Clear();  
         do
         {
            switch (opcion)
            {
               case 1:
                  Console.WriteLine("Ingrese por favor un valor");
                  int valor = Convert.ToInt32(Console.ReadLine());
                  miPromedio.AgregarValor(valor);
                  break;
               case 2:
                  Console.WriteLine("Calculo de promedio");
                  double promedio = miPromedio.CalcularPromedio();
                  Console.WriteLine("{0:f2}", promedio);
                  break;
               default:
                  Console.WriteLine("Opcion no valida, intente nuevamente");
                  break;
            }
            Console.WriteLine("Seleccione la opcion que desea:\n n-1:Ingresar nuevos valores \n n-2:Calcular Promedio \n n-3 Para salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
         } while (opcion != 3);
         Console.WriteLine("Disfrute el viajes");
         Console.ReadKey();
      }
   }
}
