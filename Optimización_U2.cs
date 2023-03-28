using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizacion_1{
    internal class Program{
        static void Main(string[] args){
            // Opción de salida de menú.
            int opc = 0;
            do{
                // Variable para opción del menú.
                string m ;
                // Opciones del menú
                Console.WriteLine("---------Programas de Optimización----------\n");
                Console.WriteLine("1.Programa con Arreglo");
                Console.WriteLine("2.Programa con Hash");
                Console.WriteLine("3.Programa con Lista");
                Console.WriteLine("4.Salir");
                // Captura de opción del menú
                Console.Write("Selecciona una opción:");
                m = Console.ReadLine();         
                switch (m){
                    case "1":
                        Console.Clear();
                        ProgramaSinHash();
                        Console.WriteLine("\nPresiona <Enter> para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        ProgramaConHash();
                        Console.WriteLine("\nPresiona <Enter> para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        ProgramaConList();
                        Console.WriteLine("\nPresiona <Enter> para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        opc = 1;
                        Console.WriteLine("Saliendo de la aplicación...");
                        Console.WriteLine("\nPresiona <Enter> para continuar...");
                        break;
                }

            } while (opc == 0);
            
            Console.ReadKey();
        }

        // Método para el programa sin tabla hash.
        private static void ProgramaSinHash(){
            // Variable para número de datos de entrada
            int entrada1;

            // Captura de cantidad de datos que se desean ingresar
            Console.Write("Ingrese el número de datos de entrada: ");
            entrada1 = Convert.ToInt32(Console.ReadLine());

            // <Inicio de captura y despliegue de datos>
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            int[] ArregloEntradas = new int[entrada1];
            for (int i = ArregloEntradas.Length-1; i >= 0; i--)
            {
                ArregloEntradas[i] = i;
            }
            for (int i = ArregloEntradas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ArregloEntradas[i].ToString());
  
            }
            Console.WriteLine("Cantidad de datos almacenados en el arreglo: {0}", ArregloEntradas.Length);
            Console.WriteLine("Tiempo de Ejecución programa 1: " + stopwatch1.ElapsedMilliseconds.ToString() + " Milisegundos");
            stopwatch1.Stop();
        }
        // Método de para el programa con tabla Hash
        private static void ProgramaConHash()
        {
            // Variable para número de datos de entrada
            int entrada2;

            // Captura de cantidad de datos que se desean ingresar
            Console.Write("Ingresa el número de entradas: ");
            entrada2 = Convert.ToInt32(Console.ReadLine());

            // <Inicio de captura y despliegue de datos>
            // Tiempo de ejecución
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            Hashtable tablaHash = new Hashtable();     
            for (int i = entrada2 - 1;i>=0;i--) 
            {
                tablaHash.Add(i, i);  
            } 
            foreach (DictionaryEntry data in tablaHash)
            {
                Console.WriteLine("num a:" + data.Key + ": " + data.Value);
            }
            Console.WriteLine($"Número de entradas en la tabla hash: {tablaHash.Count}");
            // Despliegue de tiempo de ejecución
            Console.WriteLine("Tiempo de Ejecución programa 2: " + stopwatch2.ElapsedMilliseconds.ToString() + " Milisegundos");
            stopwatch2.Stop();

        }
        // Método de para el programa con list
        private static void ProgramaConList()
        {
            // Variable para número de datos de entrada
            int entrada3;

            // Captura de cantidad de datos que se desean ingresar
            Console.Write("Ingresa el número de entradas: ");
            entrada3 = Convert.ToInt32(Console.ReadLine());

            // <Inicio de captura y despliegue de datos>
            // Tiempo de ejecución
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            List<int> list = new List<int>();

            for (int i = entrada3 - 1; i >= 0; i--)
            {
                list.Add(i);
            }
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine($"Número de entradas en la tabla hash: {list.Count}");
            // Despliegue de tiempo de ejecución
            Console.WriteLine("Tiempo de Ejecución programa 2: " + stopwatch3.ElapsedMilliseconds.ToString() + " Milisegundos");
            stopwatch3.Stop();

        }
    }
}