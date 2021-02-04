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
            Thread piso2 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 2:");
            piso2.Start();
            Thread piso3 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 3:");
            piso3.Start();
            Thread piso4 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 4:");
            piso4.Start();
            Thread piso5 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 5:");
            piso5.Start();
            Thread piso6 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 6:");
            piso6.Start();
            Thread piso7 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 7:");
            piso7.Start();
            Thread piso8 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 8:");
            piso8.Start();
            Thread piso9 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 9:");
            piso9.Start();
            Thread piso10 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 10:");
            piso10.Start();
            Thread piso11 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 11:");
            piso11.Start();
            Thread piso12 = new Thread(NumeroDePersonas);
            Console.WriteLine("Piso 12:");
            piso12.Start();


            piso1.Join();
            piso2.Join();
            piso3.Join();
            piso4.Join();
            piso5.Join();
            piso6.Join();
            piso7.Join();
            piso8.Join();
            piso9.Join();
            piso10.Join();
            piso11.Join();
            piso12.Join();

        }
        public static void NumeroDePersonas()
        {
            var Apartamento = 0;

            for (int i = 0; i <= 11; i++)
            {
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var randomDepartamento = new Random();
                if (Apartamento <= 7)
                {
                    Apartamento ++;
                }


                var random = new Random();
                var value = random.Next(0, 6);

                Console.WriteLine($"Piso {i} - departamentos {Apartamento} - cantidad de personas {value}");
            }
        }
    }
}




        }
    }
}

            
           
            
            

            
            