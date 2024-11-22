
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromEje1
{
    internal class Notas
    {
        double promedio;  //atributos
        int aprobados;
        double[] notasestudiantes;

        public Notas(int n)
        {
            notasestudiantes = new double[n];
        }
        public void Setnotas() 
        {
            for(int i = 0; i < notasestudiantes.Length; i++) 
            {
                Console.Write($"Nota {i + 1} ingrese el valor: ");
                notasestudiantes[i] = ValidarNota();
                //calcular cuantas notas fueron ingresadas y se repite con un ciclo for
            }
        }//metodos
        public double Getpromedio()
        {
            promedio = 0;
            double suma = 0;
            for (int i = 0; i < notasestudiantes.Length; i++)
            {
                suma += notasestudiantes[i];
            }
            promedio = suma / notasestudiantes.Length;
            return promedio;
            //suma la cantidad de notas ingresadas dividido en la cantidad de estudiantes 
        }
        public int Getaprobados()
        {
            aprobados = 0;
            for (int i = 0; i < notasestudiantes.Length; i++)
            {
                if (notasestudiantes[i] >= 3.0) 
                {
                    aprobados++;
                }
            }
            return aprobados;
        }
        public void Listadonotas() // nos muestra cuantas notas son 
        {
            for(int i = 0; i < notasestudiantes.Length; i++) 
            {
                Console.WriteLine($"Nota estudiante {i + 1}: {notasestudiantes[i]}");
            }
        }
        public int Getdesaprobados() 
        {
            return notasestudiantes.Length - aprobados;
        }
        private bool CalificacionValida(double n) 
        {
            return (n >= 0 && n <= 5.0);
        }

        private double ValidarNota()
        {
            double nota;
            bool error=true;
            while (error) 
            {
                nota=double.Parse(Console.ReadLine());
                if (CalificacionValida(nota)) 
                {
                    error=false;
                }
                else 
                {
                    Console.WriteLine("Digite una nota en el rango indicado");
                    error=true;
                    
                }
                return nota;
            }
            return 0;
        

        }
    }
}