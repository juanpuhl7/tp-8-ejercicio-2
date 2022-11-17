using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CANTDIAS=5;

            string [] arreglos_Dias ={"Lunes","Martes","Miercoles","Jueves","Viernes"};

          
            Console.WriteLine("DIAS DE LA SEMANA");
            for(int i=0; i<CANTDIAS; i ++){
                   Console.WriteLine(arreglos_Dias[i]);   
            }
            
            Console.WriteLine("DIAS DE LA SEMANA AL REVES");
            for(int i=4; i>=0; i --){
                   Console.WriteLine(arreglos_Dias[i]);   
            }
          
          
          Console.WriteLine("Presione una tecla para terminar...");
          Console.ReadKey();

        }
    }
}
