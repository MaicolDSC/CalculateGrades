/* 1.	Diseñe un programa que permita capturar n valores de notas de una prueba en una institución educativa así:
 • Por consola solicita el número de notas ha ingresar 
• Se ingresan las n notas y como salida debe indicar el promedio de notas. 
• Se debe evaluar usando condicionales cuantos estudiantes pasan y cuantos no. 
• La valoración es de 1.0 a 5.0 siendo la nota aprobatoria 3.0

Nombre: Maicol David Siachoque Cubides
Grupo: 104
Programa: Ingenieria de sistemas
Codigo funte: Autoria propia
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromEje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Este programa sirve para capturas notas de una prueba");
            Console.WriteLine("Calcula el promedio y cuantos estudiantes pasaron y cuantos perdieron");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("Ingrese la cantidad de notas que desea comprobar: ");
            int cantidad = int.Parse(Console.ReadLine());
          

            Notas notas=new Notas(cantidad); //adjuntamos nuestra clase notas

            notas.Setnotas();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            
            
            notas.Listadonotas();
            

            Console.WriteLine($"El promedio general de las notas ingresadas fue :{notas.Getpromedio()}");

            Console.WriteLine($"Los estudiantes que aprobaron fueron: {notas.Getaprobados()}");

            Console.WriteLine($"Los estudiantes que reprobaron fueron: {notas.Getdesaprobados()}");

            Console.ReadKey();
        }
    }
}
