using System;

namespace vscode
{
    class Program
    {
        static void Main(string[] args)
        {
        //Practica 3
        int numero = 101;
        for(int i = 1;(i<=20)&&(numero > 100);i++){
            if(numero%2==0){
                Console.WriteLine(numero);
            }
            numero += 1;
        }
    } 
}}