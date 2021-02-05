using System;
using System.Threading;

namespace EdisonMolinaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("En este edificio hay 12 pisos" +
                " en el cual hay 8 departamentos por piso ");
            //Numero de pisos 12

            Thread piso1 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 1:");
            piso1.Start();
            Piso1.Join();
            
            Thread piso2 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 2:");
            piso2.Start();
             Piso2.Join();
            
            Thread piso3 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 3:");
            piso3.Start();
            Piso3.Join();
            
            Thread piso4 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 4:");
            piso4.Start();
             Piso4.Join();
            
            Thread piso5 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 5:");
            piso5.Start();
            Piso5.Join();
            
            Thread piso6 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 6:");
            piso6.Start();
             Piso6.Join();
            
            Thread piso7 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 7:");
            piso7.Start();
            Piso7.Join();
            
            Thread piso8 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 8:");
            piso8.Start();
            Piso8.Join();
            
            
            
            Thread piso9 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 9:");
            piso9.Start();
             Piso9.Join();
            
            Thread piso10 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 10:");
            piso10.Start();
            
            Piso10.Join();
            
            Thread piso11 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 11:");
            piso11.Start();
            
            Piso11.Join();
            
            Thread piso12 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 12:");
            piso12.Start();
               Piso12.Join();

        
        }
        public static void NumeroDePersonas()
        {
            var Apartamento = 0;

            for (int i = 0; i <= 12; i++)
            {
                var guia = Guia.NewGuid();
                var nummeros = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var randomApartamento = new Random();
                if (Apartamento <= 8)
                {
                    Apartamento ++;
                }
                var random = new Random();
                var value = random.Next(0, 12);

                Console.WriteLine($"Piso {i} - Apartamentos {Apartamento} - cantidad de personas dentro del edificio {value}");
            }
        }
    }
}


            

            
            
