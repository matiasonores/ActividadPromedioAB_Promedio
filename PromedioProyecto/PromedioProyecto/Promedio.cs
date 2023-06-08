using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioProyecto
{
   public class Promedio
   {
      private int con = 0;
      private double acum = 0;

        public Promedio()
        {
        }

      public void AgregarValor(int valor)
      {
         con++;
         acum += valor;
      }

      public double CalcularPromedio()
      {
         if (con != 0) 
         {
            return acum / con;
         }
         else
         {
            return 0;
         }
      }
    }
}
