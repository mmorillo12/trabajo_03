using System;

namespace vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practica 1
           int valor,suma = 0;
        Console.WriteLine("Bienvenido a su programa de adicion si desea dejar de sumar presione 0 o un numero negativo"); 
           
            do{ 
            Console.Write("Ingrese sus numeros: ");
            valor = int.Parse(Console.ReadLine());
            if(valor < 0){
              Console.WriteLine(suma);
            }
            suma += valor;
            }
            while((valor != 0)||(valor !< 0));
            
         Console.WriteLine(suma);
        }
    }
}
